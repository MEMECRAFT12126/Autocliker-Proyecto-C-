using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace AUTOCLIKER
{
    public partial class Main : Form
    {
        // DLL Imports para simular clicks
        [DllImport("user32.dll")]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        private static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        // Constantes para mouse events
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x20;
        private const int MOUSEEVENTF_MIDDLEUP = 0x40;

        // Constantes para modificadores
        private const uint MOD_ALT = 0x0001;
        private const uint MOD_CONTROL = 0x0002;
        private const uint MOD_SHIFT = 0x0004;
        private const uint MOD_WIN = 0x0008;

        // Estados
        private enum ClickerState
        {
            Detenido,
            Iniciado,
            Pausado
        }

        private ClickerState currentState = ClickerState.Detenido;
        private Thread clickThread;
        private bool isRunning = false;
        private bool isPaused = false;
        private int clickCount = 0;
        private int totalClicks = 0;
        private Random random = new Random();

        // Configuración
        private string selectedButton = "Izquierdo";
        private int clickType = 1; // 1: Simple, 2: Doble, 3: Triple
        private bool infiniteMode = true;
        private int maxClicks = 100;
        private int clickInterval = 100;
        private bool randomDelay = false;
        private int minDelay = 50;
        private int maxDelay = 150;
        private bool useCurrentPos = true;
        private int fixedX = 500;
        private int fixedY = 400;

        // Hotkeys
        private int hotkeyStartStop = 0;
        private int hotkeyPause = 0;
        private int hotkeySingle = 0;
        private int hotkeyDouble = 0;
        private uint modStartStop = 0;
        private uint modPause = 0;
        private uint modSingle = 0;
        private uint modDouble = 0;

        // IDs para hotkeys
        private const int HOTKEY_ID_STARTSTOP = 1;
        private const int HOTKEY_ID_PAUSE = 2;
        private const int HOTKEY_ID_SINGLE = 3;
        private const int HOTKEY_ID_DOUBLE = 4;

        public Main()
        {
            InitializeComponent();
            InitializeEvents();
            LoadSettings();
            UpdateUI();
        }

        private void InitializeEvents()
        {
            // Eventos del header
            this.btnClose.Click += (s, e) => CloseApp();
            this.btnMinimize.Click += (s, e) => this.WindowState = FormWindowState.Minimized;
            this.btnTray.Click += (s, e) => MinimizeToTray();

            // Eventos de configuración
            this.rbLeft.CheckedChanged += (s, e) => { if (rbLeft.Checked) selectedButton = "Izquierdo"; };
            this.rbRight.CheckedChanged += (s, e) => { if (rbRight.Checked) selectedButton = "Derecho"; };
            this.rbMiddle.CheckedChanged += (s, e) => { if (rbMiddle.Checked) selectedButton = "Medio"; };

            this.rbSingle.CheckedChanged += (s, e) => { if (rbSingle.Checked) clickType = 1; };
            this.rbDouble.CheckedChanged += (s, e) => { if (rbDouble.Checked) clickType = 2; };
            this.rbTriple.CheckedChanged += (s, e) => { if (rbTriple.Checked) clickType = 3; };

            this.rbInfinite.CheckedChanged += (s, e) =>
            {
                infiniteMode = rbInfinite.Checked;
                nudClicks.Enabled = !infiniteMode;
            };

            this.rbLimited.CheckedChanged += (s, e) =>
            {
                infiniteMode = !rbLimited.Checked;
                nudClicks.Enabled = !infiniteMode;
            };

            this.nudClicks.ValueChanged += (s, e) => maxClicks = (int)nudClicks.Value;

            this.tbSpeed.ValueChanged += (s, e) =>
            {
                clickInterval = 500 - (tbSpeed.Value * 4);
                if (clickInterval < 1) clickInterval = 1;
                lblSpeedValue.Text = $"{clickInterval} ms";
            };

            this.chkRandom.CheckedChanged += (s, e) =>
            {
                randomDelay = chkRandom.Checked;
                pnlRandom.Visible = randomDelay;
            };

            this.nudMin.ValueChanged += (s, e) => minDelay = (int)nudMin.Value;
            this.nudMax.ValueChanged += (s, e) => maxDelay = (int)nudMax.Value;

            this.rbCurrentPos.CheckedChanged += (s, e) =>
            {
                useCurrentPos = rbCurrentPos.Checked;
                txtX.Enabled = !useCurrentPos;
                txtY.Enabled = !useCurrentPos;
                btnGetPos.Enabled = !useCurrentPos;
            };

            this.rbFixedPos.CheckedChanged += (s, e) =>
            {
                useCurrentPos = !rbFixedPos.Checked;
                txtX.Enabled = !useCurrentPos;
                txtY.Enabled = !useCurrentPos;
                btnGetPos.Enabled = !useCurrentPos;
            };

            this.btnGetPos.Click += (s, e) => GetCurrentPosition();

            // Botones de control
            this.btnStart.Click += (s, e) => StartClicking();
            this.btnPause.Click += (s, e) => PauseClicking();
            this.btnStop.Click += (s, e) => StopClicking();

            // Eventos de hotkeys
            this.cmbStartStop.SelectedIndexChanged += (s, e) => ParseHotkey(cmbStartStop, ref hotkeyStartStop, ref modStartStop);
            this.cmbPause.SelectedIndexChanged += (s, e) => ParseHotkey(cmbPause, ref hotkeyPause, ref modPause);
            this.cmbSingle.SelectedIndexChanged += (s, e) => ParseHotkey(cmbSingle, ref hotkeySingle, ref modSingle);
            this.cmbDouble.SelectedIndexChanged += (s, e) => ParseHotkey(cmbDouble, ref hotkeyDouble, ref modDouble);

            // Eventos de bandeja
            this.chkTopMost.CheckedChanged += (s, e) => this.TopMost = chkTopMost.Checked;

            // Tray menu
            this.tsShow.Click += (s, e) => ShowFromTray();
            this.tsStart.Click += (s, e) => StartClicking();
            this.tsPause.Click += (s, e) => PauseClicking();
            this.tsStop.Click += (s, e) => StopClicking();
            this.tsExit.Click += (s, e) => Application.Exit();

            this.notifyIcon.DoubleClick += (s, e) => ShowFromTray();

            // Timer
            this.timerHotkey.Tick += TimerHotkey_Tick;
            this.timerHotkey.Start();
        }

        private void ParseHotkey(Guna.UI2.WinForms.Guna2ComboBox combo, ref int keyCode, ref uint modifiers)
        {
            string selected = combo.SelectedItem?.ToString() ?? "Ninguna";

            if (selected == "Ninguna")
            {
                keyCode = 0;
                modifiers = 0;
                return;
            }

            modifiers = 0;
            string key = selected;

            if (selected.Contains("+"))
            {
                string[] parts = selected.Split('+');
                key = parts[1].Trim();

                if (selected.Contains("Ctrl"))
                    modifiers |= MOD_CONTROL;
                if (selected.Contains("Alt"))
                    modifiers |= MOD_ALT;
                if (selected.Contains("Shift"))
                    modifiers |= MOD_SHIFT;
            }

            keyCode = GetKeyCode(key);
        }

        private int GetKeyCode(string key)
        {
            switch (key)
            {
                case "F1": return 0x70;
                case "F2": return 0x71;
                case "F3": return 0x72;
                case "F4": return 0x73;
                case "F5": return 0x74;
                case "F6": return 0x75;
                case "F7": return 0x76;
                case "F8": return 0x77;
                case "F9": return 0x78;
                case "F10": return 0x79;
                case "F11": return 0x7A;
                case "F12": return 0x7B;
                case "Insert": return 0x2D;
                case "Home": return 0x24;
                case "PageUp": return 0x21;
                case "Delete": return 0x2E;
                case "End": return 0x23;
                case "PageDown": return 0x22;
                default: return 0;
            }
        }

        private void GetCurrentPosition()
        {
            Point cursorPos = new Point();
            GetCursorPos(ref cursorPos);
            txtX.Text = cursorPos.X.ToString();
            txtY.Text = cursorPos.Y.ToString();
        }

        private void LoadSettings()
        {
            // Valores por defecto
            cmbStartStop.SelectedIndex = 5; // F6
            cmbPause.SelectedIndex = 0; // Ninguna
            cmbSingle.SelectedIndex = 0;
            cmbDouble.SelectedIndex = 0;
            tbSpeed.Value = 50;
            nudClicks.Value = 100;
            nudMin.Value = 50;
            nudMax.Value = 150;
            txtX.Text = "500";
            txtY.Text = "400";
        }

        private void UpdateUI()
        {
            switch (currentState)
            {
                case ClickerState.Detenido:
                    lblStatus.Text = "Estado: Detenido";
                    lblStatus.ForeColor = Color.Gray;
                    btnStart.Enabled = true;
                    btnPause.Enabled = false;
                    btnStop.Enabled = false;
                    tsStart.Enabled = true;
                    tsPause.Enabled = false;
                    tsStop.Enabled = false;
                    break;

                case ClickerState.Iniciado:
                    lblStatus.Text = $"Estado: Iniciado ({clickCount}/{(infiniteMode ? "∞" : maxClicks.ToString())})";
                    lblStatus.ForeColor = Color.FromArgb(50, 200, 100);
                    btnStart.Enabled = false;
                    btnPause.Enabled = true;
                    btnStop.Enabled = true;
                    tsStart.Enabled = false;
                    tsPause.Enabled = true;
                    tsStop.Enabled = true;
                    break;

                case ClickerState.Pausado:
                    lblStatus.Text = $"Estado: Pausado ({clickCount}/{(infiniteMode ? "∞" : maxClicks.ToString())})";
                    lblStatus.ForeColor = Color.FromArgb(255, 170, 50);
                    btnStart.Enabled = true;
                    btnPause.Enabled = false;
                    btnStop.Enabled = true;
                    tsStart.Enabled = true;
                    tsPause.Enabled = false;
                    tsStop.Enabled = true;
                    break;
            }
        }

        private void StartClicking()
        {
            if (currentState == ClickerState.Pausado)
            {
                isPaused = false;
                currentState = ClickerState.Iniciado;
                UpdateUI();
                return;
            }

            if (currentState == ClickerState.Detenido)
            {
                clickCount = 0;
                isRunning = true;
                isPaused = false;
                currentState = ClickerState.Iniciado;

                // Obtener posición fija si está configurada
                if (!useCurrentPos)
                {
                    int.TryParse(txtX.Text, out fixedX);
                    int.TryParse(txtY.Text, out fixedY);
                }

                clickThread = new Thread(ClickLoop);
                clickThread.IsBackground = true;
                clickThread.Start();

                UpdateUI();
            }
        }

        private void PauseClicking()
        {
            if (currentState == ClickerState.Iniciado)
            {
                isPaused = true;
                currentState = ClickerState.Pausado;
                UpdateUI();
            }
        }

        private void StopClicking()
        {
            isRunning = false;
            isPaused = false;
            currentState = ClickerState.Detenido;
            clickCount = 0;
            UpdateUI();
        }

        private void ClickLoop()
        {
            while (isRunning)
            {
                if (!isPaused)
                {
                    try
                    {
                        // Obtener posición
                        int x, y;

                        if (useCurrentPos)
                        {
                            Point cursorPos = new Point();
                            GetCursorPos(ref cursorPos);
                            x = cursorPos.X;
                            y = cursorPos.Y;
                        }
                        else
                        {
                            x = fixedX;
                            y = fixedY;
                        }

                        // Realizar click(s)
                        PerformClick(x, y, clickType);

                        clickCount++;

                        // Verificar límite
                        if (!infiniteMode && clickCount >= maxClicks)
                        {
                            this.Invoke(new Action(() => StopClicking()));
                            break;
                        }

                        // Calcular delay
                        int delay = randomDelay ? random.Next(minDelay, maxDelay) : clickInterval;
                        Thread.Sleep(delay);

                        // Actualizar UI
                        this.Invoke(new Action(() => UpdateUI()));
                    }
                    catch { }
                }
                else
                {
                    Thread.Sleep(100);
                }
            }
        }

        private void PerformClick(int x, int y, int type)
        {
            SetCursorPos(x, y);

            uint downFlag = MOUSEEVENTF_LEFTDOWN;
            uint upFlag = MOUSEEVENTF_LEFTUP;

            switch (selectedButton)
            {
                case "Derecho":
                    downFlag = MOUSEEVENTF_RIGHTDOWN;
                    upFlag = MOUSEEVENTF_RIGHTUP;
                    break;
                case "Medio":
                    downFlag = MOUSEEVENTF_MIDDLEDOWN;
                    upFlag = MOUSEEVENTF_MIDDLEUP;
                    break;
            }

            for (int i = 0; i < type; i++)
            {
                mouse_event(downFlag, (uint)x, (uint)y, 0, 0);
                mouse_event(upFlag, (uint)x, (uint)y, 0, 0);

                if (type > 1 && i < type - 1)
                {
                    Thread.Sleep(30); // Pausa entre clicks múltiples
                }
            }
        }

        private void TimerHotkey_Tick(object sender, EventArgs e)
        {
            // Detectar hotkey Start/Stop
            if (hotkeyStartStop != 0 && IsKeyPressed(modStartStop, hotkeyStartStop))
            {
                if (currentState == ClickerState.Detenido || currentState == ClickerState.Pausado)
                    StartClicking();
                else if (currentState == ClickerState.Iniciado)
                    StopClicking();
            }

            // Detectar hotkey Pause
            if (hotkeyPause != 0 && IsKeyPressed(modPause, hotkeyPause))
            {
                if (currentState == ClickerState.Iniciado)
                    PauseClicking();
                else if (currentState == ClickerState.Pausado)
                    StartClicking();
            }

            // Detectar hotkey Click Simple
            if (hotkeySingle != 0 && IsKeyPressed(modSingle, hotkeySingle))
            {
                PerformOneClick();
            }

            // Detectar hotkey Doble Click
            if (hotkeyDouble != 0 && IsKeyPressed(modDouble, hotkeyDouble))
            {
                PerformDoubleClick();
            }
        }

        private bool IsKeyPressed(uint modifiers, int keyCode)
        {
            // Verificar modificadores
            bool ctrlOk = (modifiers & MOD_CONTROL) == 0 || (Control.ModifierKeys & Keys.Control) != 0;
            bool altOk = (modifiers & MOD_ALT) == 0 || (Control.ModifierKeys & Keys.Alt) != 0;
            bool shiftOk = (modifiers & MOD_SHIFT) == 0 || (Control.ModifierKeys & Keys.Shift) != 0;

            if (!ctrlOk || !altOk || !shiftOk)
                return false;

            // Verificar tecla
            return (GetAsyncKeyState(keyCode) & 0x8000) != 0;
        }

        private void PerformOneClick()
        {
            Point cursorPos = new Point();
            GetCursorPos(ref cursorPos);
            PerformClick(cursorPos.X, cursorPos.Y, 1);
        }

        private void PerformDoubleClick()
        {
            Point cursorPos = new Point();
            GetCursorPos(ref cursorPos);
            PerformClick(cursorPos.X, cursorPos.Y, 2);
        }

        private void MinimizeToTray()
        {
            this.Hide();
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(1000, "AutoClicker Pro", "La aplicación se ha minimizado a la bandeja", ToolTipIcon.Info);
        }

        private void ShowFromTray()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
            notifyIcon.Visible = false;
        }

        private void CloseApp()
        {
            if (chkTray.Checked)
            {
                MinimizeToTray();
            }
            else
            {
                Application.Exit();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (chkTray.Checked && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                MinimizeToTray();
            }
            else
            {
                isRunning = false;
                notifyIcon.Visible = false;
                notifyIcon.Dispose();
                base.OnFormClosing(e);
            }
        }

        protected override void WndProc(ref Message m)
        {
            // Para hotkeys globales (opcional)
            base.WndProc(ref m);
        }
    }
}