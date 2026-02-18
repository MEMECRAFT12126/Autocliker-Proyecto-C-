namespace AUTOCLIKER
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnMinimize;
        private Guna.UI2.WinForms.Guna2Button btnTray;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2TabControl tabControl;
        private System.Windows.Forms.TabPage tabPrincipal;
        private System.Windows.Forms.TabPage tabHotkeys;
        private System.Windows.Forms.TabPage tabAbout;

        // Controles de la pestaña principal
        private Guna.UI2.WinForms.Guna2GroupBox gbClickType;
        private Guna.UI2.WinForms.Guna2RadioButton rbLeft;
        private Guna.UI2.WinForms.Guna2RadioButton rbRight;
        private Guna.UI2.WinForms.Guna2RadioButton rbMiddle;
        private Guna.UI2.WinForms.Guna2RadioButton rbSingle;
        private Guna.UI2.WinForms.Guna2RadioButton rbDouble;
        private Guna.UI2.WinForms.Guna2RadioButton rbTriple;

        private Guna.UI2.WinForms.Guna2GroupBox gbClickMode;
        private Guna.UI2.WinForms.Guna2RadioButton rbInfinite;
        private Guna.UI2.WinForms.Guna2RadioButton rbLimited;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudClicks;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblClicks;

        private Guna.UI2.WinForms.Guna2GroupBox gbSpeed;
        private Guna.UI2.WinForms.Guna2TrackBar tbSpeed;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSpeedValue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSpeedText;
        private Guna.UI2.WinForms.Guna2CheckBox chkRandom;
        private Guna.UI2.WinForms.Guna2Panel pnlRandom;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMin;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudMin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMax;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudMax;

        private Guna.UI2.WinForms.Guna2GroupBox gbPosition;
        private Guna.UI2.WinForms.Guna2RadioButton rbCurrentPos;
        private Guna.UI2.WinForms.Guna2RadioButton rbFixedPos;
        private Guna.UI2.WinForms.Guna2TextBox txtX;
        private Guna.UI2.WinForms.Guna2TextBox txtY;
        private Guna.UI2.WinForms.Guna2Button btnGetPos;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblX;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblY;

        // Controles de la pestaña Hotkeys
        private Guna.UI2.WinForms.Guna2GroupBox gbHotkeyMain;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStartStop;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStartStop;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPause;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPause;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSingle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSingle;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDouble;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDouble;

        private Guna.UI2.WinForms.Guna2GroupBox gbTray;
        private Guna.UI2.WinForms.Guna2CheckBox chkTray;
        private Guna.UI2.WinForms.Guna2CheckBox chkStartMinimized;
        private Guna.UI2.WinForms.Guna2CheckBox chkTopMost;

        // Controles de la pestaña About
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAbout;
        private Guna.UI2.WinForms.Guna2PictureBox pictureLogo;

        // Panel de control inferior
        private Guna.UI2.WinForms.Guna2Panel panelFooter;
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private Guna.UI2.WinForms.Guna2Button btnStop;
        private Guna.UI2.WinForms.Guna2Button btnPause;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStatus;

        // Otros componentes
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem tsShow;
        private System.Windows.Forms.ToolStripMenuItem tsStart;
        private System.Windows.Forms.ToolStripMenuItem tsPause;
        private System.Windows.Forms.ToolStripMenuItem tsStop;
        private System.Windows.Forms.ToolStripSeparator tsSeparator;
        private System.Windows.Forms.ToolStripMenuItem tsExit;
        private System.Windows.Forms.Timer timerHotkey;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTray = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPrincipal = new System.Windows.Forms.TabPage();
            this.gbClickType = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rbLeft = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbRight = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbMiddle = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbSingle = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbDouble = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbTriple = new Guna.UI2.WinForms.Guna2RadioButton();
            this.gbClickMode = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rbInfinite = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbLimited = new Guna.UI2.WinForms.Guna2RadioButton();
            this.nudClicks = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblClicks = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gbSpeed = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tbSpeed = new Guna.UI2.WinForms.Guna2TrackBar();
            this.lblSpeedValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSpeedText = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.chkRandom = new Guna.UI2.WinForms.Guna2CheckBox();
            this.pnlRandom = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nudMin = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblMax = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nudMax = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.gbPosition = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rbCurrentPos = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbFixedPos = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lblX = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtX = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblY = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtY = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnGetPos = new Guna.UI2.WinForms.Guna2Button();
            this.tabHotkeys = new System.Windows.Forms.TabPage();
            this.gbHotkeyMain = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblStartStop = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbStartStop = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPause = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbPause = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblSingle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbSingle = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblDouble = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbDouble = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gbTray = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chkTray = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkStartMinimized = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkTopMost = new Guna.UI2.WinForms.Guna2CheckBox();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.pictureLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblAbout = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.lblStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnPause = new Guna.UI2.WinForms.Guna2Button();
            this.btnStop = new Guna.UI2.WinForms.Guna2Button();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsShow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPause = new System.Windows.Forms.ToolStripMenuItem();
            this.tsStop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.timerHotkey = new System.Windows.Forms.Timer(this.components);
            this.panelHeader.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.gbClickType.SuspendLayout();
            this.gbClickMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudClicks)).BeginInit();
            this.gbSpeed.SuspendLayout();
            this.pnlRandom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            this.gbPosition.SuspendLayout();
            this.tabHotkeys.SuspendLayout();
            this.gbHotkeyMain.SuspendLayout();
            this.gbTray.SuspendLayout();
            this.tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.trayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 25;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.btnTray);
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(700, 45);
            this.panelHeader.TabIndex = 0;
            // 
            // btnTray
            // 
            this.btnTray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTray.Animated = true;
            this.btnTray.BackColor = System.Drawing.Color.Transparent;
            this.btnTray.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTray.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTray.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTray.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTray.FillColor = System.Drawing.Color.Transparent;
            this.btnTray.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTray.ForeColor = System.Drawing.Color.White;
            this.btnTray.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.btnTray.Location = new System.Drawing.Point(590, 8);
            this.btnTray.Name = "btnTray";
            this.btnTray.Size = new System.Drawing.Size(30, 30);
            this.btnTray.TabIndex = 3;
            this.btnTray.Text = "▼";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Animated = true;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinimize.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.btnMinimize.Location = new System.Drawing.Point(625, 8);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "─";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Animated = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnClose.Location = new System.Drawing.Point(660, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "×";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(15, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(146, 27);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "AutoClicker DLL";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPrincipal);
            this.tabControl.Controls.Add(this.tabHotkeys);
            this.tabControl.Controls.Add(this.tabAbout);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tabControl.ItemSize = new System.Drawing.Size(150, 40);
            this.tabControl.Location = new System.Drawing.Point(15, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(670, 430);
            this.tabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabControl.TabButtonSize = new System.Drawing.Size(150, 40);
            this.tabControl.TabIndex = 1;
            this.tabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.tabPrincipal.Controls.Add(this.gbClickType);
            this.tabPrincipal.Controls.Add(this.gbClickMode);
            this.tabPrincipal.Controls.Add(this.gbSpeed);
            this.tabPrincipal.Controls.Add(this.pnlRandom);
            this.tabPrincipal.Controls.Add(this.gbPosition);
            this.tabPrincipal.Location = new System.Drawing.Point(4, 44);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.Padding = new System.Windows.Forms.Padding(15);
            this.tabPrincipal.Size = new System.Drawing.Size(662, 382);
            this.tabPrincipal.TabIndex = 0;
            this.tabPrincipal.Text = "Principal";
            // 
            // gbClickType
            // 
            this.gbClickType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.gbClickType.BorderThickness = 2;
            this.gbClickType.Controls.Add(this.rbLeft);
            this.gbClickType.Controls.Add(this.rbRight);
            this.gbClickType.Controls.Add(this.rbMiddle);
            this.gbClickType.Controls.Add(this.rbSingle);
            this.gbClickType.Controls.Add(this.rbDouble);
            this.gbClickType.Controls.Add(this.rbTriple);
            this.gbClickType.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.gbClickType.FillColor = System.Drawing.Color.Black;
            this.gbClickType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbClickType.ForeColor = System.Drawing.Color.DimGray;
            this.gbClickType.Location = new System.Drawing.Point(15, 15);
            this.gbClickType.Name = "gbClickType";
            this.gbClickType.Size = new System.Drawing.Size(310, 120);
            this.gbClickType.TabIndex = 0;
            this.gbClickType.Text = "Tipo de Click";
            // 
            // rbLeft
            // 
            this.rbLeft.AutoSize = true;
            this.rbLeft.BackColor = System.Drawing.Color.Transparent;
            this.rbLeft.Checked = true;
            this.rbLeft.CheckedState.BorderThickness = 0;
            this.rbLeft.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbLeft.ForeColor = System.Drawing.Color.White;
            this.rbLeft.Location = new System.Drawing.Point(20, 42);
            this.rbLeft.Name = "rbLeft";
            this.rbLeft.Size = new System.Drawing.Size(103, 19);
            this.rbLeft.TabIndex = 0;
            this.rbLeft.TabStop = true;
            this.rbLeft.Text = "Click Izquierdo";
            this.rbLeft.UncheckedState.BorderThickness = 0;
            this.rbLeft.UseVisualStyleBackColor = false;
            // 
            // rbRight
            // 
            this.rbRight.AutoSize = true;
            this.rbRight.BackColor = System.Drawing.Color.Transparent;
            this.rbRight.CheckedState.BorderThickness = 0;
            this.rbRight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbRight.ForeColor = System.Drawing.Color.White;
            this.rbRight.Location = new System.Drawing.Point(20, 67);
            this.rbRight.Name = "rbRight";
            this.rbRight.Size = new System.Drawing.Size(98, 19);
            this.rbRight.TabIndex = 1;
            this.rbRight.Text = "Click Derecho";
            this.rbRight.UncheckedState.BorderThickness = 0;
            this.rbRight.UseVisualStyleBackColor = false;
            // 
            // rbMiddle
            // 
            this.rbMiddle.AutoSize = true;
            this.rbMiddle.BackColor = System.Drawing.Color.Transparent;
            this.rbMiddle.CheckedState.BorderThickness = 0;
            this.rbMiddle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbMiddle.ForeColor = System.Drawing.Color.White;
            this.rbMiddle.Location = new System.Drawing.Point(20, 92);
            this.rbMiddle.Name = "rbMiddle";
            this.rbMiddle.Size = new System.Drawing.Size(88, 19);
            this.rbMiddle.TabIndex = 2;
            this.rbMiddle.Text = "Click Medio";
            this.rbMiddle.UncheckedState.BorderThickness = 0;
            this.rbMiddle.UseVisualStyleBackColor = false;
            // 
            // rbSingle
            // 
            this.rbSingle.AutoSize = true;
            this.rbSingle.BackColor = System.Drawing.Color.Transparent;
            this.rbSingle.Checked = true;
            this.rbSingle.CheckedState.BorderThickness = 0;
            this.rbSingle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbSingle.ForeColor = System.Drawing.Color.White;
            this.rbSingle.Location = new System.Drawing.Point(170, 42);
            this.rbSingle.Name = "rbSingle";
            this.rbSingle.Size = new System.Drawing.Size(90, 19);
            this.rbSingle.TabIndex = 3;
            this.rbSingle.TabStop = true;
            this.rbSingle.Text = "Click Simple";
            this.rbSingle.UncheckedState.BorderThickness = 0;
            this.rbSingle.UseVisualStyleBackColor = false;
            // 
            // rbDouble
            // 
            this.rbDouble.AutoSize = true;
            this.rbDouble.BackColor = System.Drawing.Color.Transparent;
            this.rbDouble.CheckedState.BorderThickness = 0;
            this.rbDouble.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbDouble.ForeColor = System.Drawing.Color.White;
            this.rbDouble.Location = new System.Drawing.Point(170, 67);
            this.rbDouble.Name = "rbDouble";
            this.rbDouble.Size = new System.Drawing.Size(85, 19);
            this.rbDouble.TabIndex = 4;
            this.rbDouble.Text = "Doble Click";
            this.rbDouble.UncheckedState.BorderThickness = 0;
            this.rbDouble.UseVisualStyleBackColor = false;
            // 
            // rbTriple
            // 
            this.rbTriple.AutoSize = true;
            this.rbTriple.BackColor = System.Drawing.Color.Transparent;
            this.rbTriple.CheckedState.BorderThickness = 0;
            this.rbTriple.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbTriple.ForeColor = System.Drawing.Color.White;
            this.rbTriple.Location = new System.Drawing.Point(170, 92);
            this.rbTriple.Name = "rbTriple";
            this.rbTriple.Size = new System.Drawing.Size(82, 19);
            this.rbTriple.TabIndex = 5;
            this.rbTriple.Text = "Triple Click";
            this.rbTriple.UncheckedState.BorderThickness = 0;
            this.rbTriple.UseVisualStyleBackColor = false;
            // 
            // gbClickMode
            // 
            this.gbClickMode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.gbClickMode.BorderThickness = 2;
            this.gbClickMode.Controls.Add(this.rbInfinite);
            this.gbClickMode.Controls.Add(this.rbLimited);
            this.gbClickMode.Controls.Add(this.nudClicks);
            this.gbClickMode.Controls.Add(this.lblClicks);
            this.gbClickMode.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.gbClickMode.FillColor = System.Drawing.Color.Black;
            this.gbClickMode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbClickMode.ForeColor = System.Drawing.Color.White;
            this.gbClickMode.Location = new System.Drawing.Point(340, 15);
            this.gbClickMode.Name = "gbClickMode";
            this.gbClickMode.Size = new System.Drawing.Size(300, 120);
            this.gbClickMode.TabIndex = 1;
            this.gbClickMode.Text = "Modo de Repetición";
            // 
            // rbInfinite
            // 
            this.rbInfinite.AutoSize = true;
            this.rbInfinite.BackColor = System.Drawing.Color.Transparent;
            this.rbInfinite.Checked = true;
            this.rbInfinite.CheckedState.BorderThickness = 0;
            this.rbInfinite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbInfinite.ForeColor = System.Drawing.Color.White;
            this.rbInfinite.Location = new System.Drawing.Point(11, 67);
            this.rbInfinite.Name = "rbInfinite";
            this.rbInfinite.Size = new System.Drawing.Size(152, 19);
            this.rbInfinite.TabIndex = 0;
            this.rbInfinite.TabStop = true;
            this.rbInfinite.Text = "Repetir indefinidamente";
            this.rbInfinite.UncheckedState.BorderThickness = 0;
            this.rbInfinite.UseVisualStyleBackColor = false;
            // 
            // rbLimited
            // 
            this.rbLimited.AutoSize = true;
            this.rbLimited.CheckedState.BorderThickness = 0;
            this.rbLimited.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbLimited.ForeColor = System.Drawing.Color.White;
            this.rbLimited.Location = new System.Drawing.Point(20, 126);
            this.rbLimited.Name = "rbLimited";
            this.rbLimited.Size = new System.Drawing.Size(120, 19);
            this.rbLimited.TabIndex = 1;
            this.rbLimited.Text = "Número de clicks:";
            this.rbLimited.UncheckedState.BorderThickness = 0;
            // 
            // nudClicks
            // 
            this.nudClicks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.nudClicks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudClicks.Enabled = false;
            this.nudClicks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudClicks.ForeColor = System.Drawing.Color.White;
            this.nudClicks.Location = new System.Drawing.Point(170, 58);
            this.nudClicks.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudClicks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudClicks.Name = "nudClicks";
            this.nudClicks.Size = new System.Drawing.Size(80, 26);
            this.nudClicks.TabIndex = 2;
            this.nudClicks.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblClicks
            // 
            this.lblClicks.BackColor = System.Drawing.Color.Transparent;
            this.lblClicks.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblClicks.ForeColor = System.Drawing.Color.Gray;
            this.lblClicks.Location = new System.Drawing.Point(170, 85);
            this.lblClicks.Name = "lblClicks";
            this.lblClicks.Size = new System.Drawing.Size(75, 15);
            this.lblClicks.TabIndex = 3;
            this.lblClicks.Text = "Total de clicks";
            // 
            // gbSpeed
            // 
            this.gbSpeed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.gbSpeed.BorderThickness = 2;
            this.gbSpeed.Controls.Add(this.tbSpeed);
            this.gbSpeed.Controls.Add(this.lblSpeedValue);
            this.gbSpeed.Controls.Add(this.lblSpeedText);
            this.gbSpeed.Controls.Add(this.chkRandom);
            this.gbSpeed.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.gbSpeed.FillColor = System.Drawing.Color.Black;
            this.gbSpeed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbSpeed.ForeColor = System.Drawing.Color.Black;
            this.gbSpeed.Location = new System.Drawing.Point(15, 150);
            this.gbSpeed.Name = "gbSpeed";
            this.gbSpeed.Size = new System.Drawing.Size(310, 150);
            this.gbSpeed.TabIndex = 2;
            this.gbSpeed.Text = "Velocidad";
            // 
            // tbSpeed
            // 
            this.tbSpeed.BackColor = System.Drawing.Color.Transparent;
            this.tbSpeed.Location = new System.Drawing.Point(20, 43);
            this.tbSpeed.Minimum = 1;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(270, 30);
            this.tbSpeed.TabIndex = 0;
            this.tbSpeed.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            // 
            // lblSpeedValue
            // 
            this.lblSpeedValue.BackColor = System.Drawing.Color.Transparent;
            this.lblSpeedValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSpeedValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.lblSpeedValue.Location = new System.Drawing.Point(130, 75);
            this.lblSpeedValue.Name = "lblSpeedValue";
            this.lblSpeedValue.Size = new System.Drawing.Size(56, 23);
            this.lblSpeedValue.TabIndex = 1;
            this.lblSpeedValue.Text = "100 ms";
            // 
            // lblSpeedText
            // 
            this.lblSpeedText.BackColor = System.Drawing.Color.Transparent;
            this.lblSpeedText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSpeedText.ForeColor = System.Drawing.Color.White;
            this.lblSpeedText.Location = new System.Drawing.Point(20, 80);
            this.lblSpeedText.Name = "lblSpeedText";
            this.lblSpeedText.Size = new System.Drawing.Size(93, 17);
            this.lblSpeedText.TabIndex = 2;
            this.lblSpeedText.Text = "Velocidad actual:";
            // 
            // chkRandom
            // 
            this.chkRandom.AutoSize = true;
            this.chkRandom.BackColor = System.Drawing.Color.Transparent;
            this.chkRandom.CheckedState.BorderRadius = 0;
            this.chkRandom.CheckedState.BorderThickness = 0;
            this.chkRandom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkRandom.ForeColor = System.Drawing.Color.White;
            this.chkRandom.Location = new System.Drawing.Point(20, 110);
            this.chkRandom.Name = "chkRandom";
            this.chkRandom.Size = new System.Drawing.Size(104, 19);
            this.chkRandom.TabIndex = 3;
            this.chkRandom.Text = "Delay aleatorio";
            this.chkRandom.UncheckedState.BorderRadius = 0;
            this.chkRandom.UncheckedState.BorderThickness = 0;
            this.chkRandom.UseVisualStyleBackColor = false;
            // 
            // pnlRandom
            // 
            this.pnlRandom.Controls.Add(this.lblMin);
            this.pnlRandom.Controls.Add(this.nudMin);
            this.pnlRandom.Controls.Add(this.lblMax);
            this.pnlRandom.Controls.Add(this.nudMax);
            this.pnlRandom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.pnlRandom.Location = new System.Drawing.Point(35, 210);
            this.pnlRandom.Name = "pnlRandom";
            this.pnlRandom.Size = new System.Drawing.Size(290, 45);
            this.pnlRandom.TabIndex = 3;
            this.pnlRandom.Visible = false;
            // 
            // lblMin
            // 
            this.lblMin.BackColor = System.Drawing.Color.Transparent;
            this.lblMin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMin.ForeColor = System.Drawing.Color.White;
            this.lblMin.Location = new System.Drawing.Point(10, 15);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(27, 17);
            this.lblMin.TabIndex = 0;
            this.lblMin.Text = "Mín:";
            // 
            // nudMin
            // 
            this.nudMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.nudMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudMin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudMin.ForeColor = System.Drawing.Color.White;
            this.nudMin.Location = new System.Drawing.Point(45, 10);
            this.nudMin.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudMin.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(70, 26);
            this.nudMin.TabIndex = 1;
            this.nudMin.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblMax
            // 
            this.lblMax.BackColor = System.Drawing.Color.Transparent;
            this.lblMax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMax.ForeColor = System.Drawing.Color.White;
            this.lblMax.Location = new System.Drawing.Point(130, 15);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(29, 17);
            this.lblMax.TabIndex = 2;
            this.lblMax.Text = "Máx:";
            // 
            // nudMax
            // 
            this.nudMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.nudMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudMax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudMax.ForeColor = System.Drawing.Color.White;
            this.nudMax.Location = new System.Drawing.Point(170, 10);
            this.nudMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMax.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(70, 26);
            this.nudMax.TabIndex = 3;
            this.nudMax.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // gbPosition
            // 
            this.gbPosition.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.gbPosition.BorderThickness = 2;
            this.gbPosition.Controls.Add(this.rbCurrentPos);
            this.gbPosition.Controls.Add(this.rbFixedPos);
            this.gbPosition.Controls.Add(this.lblX);
            this.gbPosition.Controls.Add(this.txtX);
            this.gbPosition.Controls.Add(this.lblY);
            this.gbPosition.Controls.Add(this.txtY);
            this.gbPosition.Controls.Add(this.btnGetPos);
            this.gbPosition.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.gbPosition.FillColor = System.Drawing.Color.Black;
            this.gbPosition.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbPosition.ForeColor = System.Drawing.Color.White;
            this.gbPosition.Location = new System.Drawing.Point(340, 150);
            this.gbPosition.Name = "gbPosition";
            this.gbPosition.Size = new System.Drawing.Size(300, 150);
            this.gbPosition.TabIndex = 4;
            this.gbPosition.Text = "Posición del Click";
            // 
            // rbCurrentPos
            // 
            this.rbCurrentPos.AutoSize = true;
            this.rbCurrentPos.BackColor = System.Drawing.Color.Transparent;
            this.rbCurrentPos.Checked = true;
            this.rbCurrentPos.CheckedState.BorderThickness = 0;
            this.rbCurrentPos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbCurrentPos.ForeColor = System.Drawing.Color.White;
            this.rbCurrentPos.Location = new System.Drawing.Point(19, 58);
            this.rbCurrentPos.Name = "rbCurrentPos";
            this.rbCurrentPos.Size = new System.Drawing.Size(125, 19);
            this.rbCurrentPos.TabIndex = 0;
            this.rbCurrentPos.TabStop = true;
            this.rbCurrentPos.Text = "Posición del cursor";
            this.rbCurrentPos.UncheckedState.BorderThickness = 0;
            this.rbCurrentPos.UseVisualStyleBackColor = false;
            // 
            // rbFixedPos
            // 
            this.rbFixedPos.AutoSize = true;
            this.rbFixedPos.BackColor = System.Drawing.Color.Transparent;
            this.rbFixedPos.CheckedState.BorderThickness = 0;
            this.rbFixedPos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbFixedPos.ForeColor = System.Drawing.Color.White;
            this.rbFixedPos.Location = new System.Drawing.Point(19, 83);
            this.rbFixedPos.Name = "rbFixedPos";
            this.rbFixedPos.Size = new System.Drawing.Size(92, 19);
            this.rbFixedPos.TabIndex = 1;
            this.rbFixedPos.Text = "Posición fija:";
            this.rbFixedPos.UncheckedState.BorderThickness = 0;
            this.rbFixedPos.UseVisualStyleBackColor = false;
            // 
            // lblX
            // 
            this.lblX.BackColor = System.Drawing.Color.Transparent;
            this.lblX.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblX.ForeColor = System.Drawing.Color.White;
            this.lblX.Location = new System.Drawing.Point(150, 62);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(13, 17);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "X:";
            // 
            // txtX
            // 
            this.txtX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.txtX.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.txtX.BorderRadius = 5;
            this.txtX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtX.DefaultText = "500";
            this.txtX.Enabled = false;
            this.txtX.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtX.ForeColor = System.Drawing.Color.White;
            this.txtX.Location = new System.Drawing.Point(166, 58);
            this.txtX.MaxLength = 4;
            this.txtX.Name = "txtX";
            this.txtX.PlaceholderText = "";
            this.txtX.SelectedText = "";
            this.txtX.Size = new System.Drawing.Size(50, 25);
            this.txtX.TabIndex = 3;
            // 
            // lblY
            // 
            this.lblY.BackColor = System.Drawing.Color.Transparent;
            this.lblY.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblY.ForeColor = System.Drawing.Color.White;
            this.lblY.Location = new System.Drawing.Point(226, 62);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(13, 17);
            this.lblY.TabIndex = 4;
            this.lblY.Text = "Y:";
            // 
            // txtY
            // 
            this.txtY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.txtY.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.txtY.BorderRadius = 5;
            this.txtY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtY.DefaultText = "400";
            this.txtY.Enabled = false;
            this.txtY.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtY.ForeColor = System.Drawing.Color.White;
            this.txtY.Location = new System.Drawing.Point(246, 58);
            this.txtY.MaxLength = 4;
            this.txtY.Name = "txtY";
            this.txtY.PlaceholderText = "";
            this.txtY.SelectedText = "";
            this.txtY.Size = new System.Drawing.Size(50, 25);
            this.txtY.TabIndex = 5;
            // 
            // btnGetPos
            // 
            this.btnGetPos.Animated = true;
            this.btnGetPos.BorderRadius = 5;
            this.btnGetPos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGetPos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGetPos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGetPos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGetPos.Enabled = false;
            this.btnGetPos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnGetPos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGetPos.ForeColor = System.Drawing.Color.White;
            this.btnGetPos.Location = new System.Drawing.Point(150, 95);
            this.btnGetPos.Name = "btnGetPos";
            this.btnGetPos.Size = new System.Drawing.Size(130, 30);
            this.btnGetPos.TabIndex = 6;
            this.btnGetPos.Text = "Obtener posición";
            // 
            // tabHotkeys
            // 
            this.tabHotkeys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.tabHotkeys.Controls.Add(this.gbHotkeyMain);
            this.tabHotkeys.Controls.Add(this.gbTray);
            this.tabHotkeys.Location = new System.Drawing.Point(4, 44);
            this.tabHotkeys.Name = "tabHotkeys";
            this.tabHotkeys.Padding = new System.Windows.Forms.Padding(15);
            this.tabHotkeys.Size = new System.Drawing.Size(662, 382);
            this.tabHotkeys.TabIndex = 1;
            this.tabHotkeys.Text = "Teclas Rápidas";
            // 
            // gbHotkeyMain
            // 
            this.gbHotkeyMain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.gbHotkeyMain.BorderThickness = 2;
            this.gbHotkeyMain.Controls.Add(this.lblStartStop);
            this.gbHotkeyMain.Controls.Add(this.cmbStartStop);
            this.gbHotkeyMain.Controls.Add(this.lblPause);
            this.gbHotkeyMain.Controls.Add(this.cmbPause);
            this.gbHotkeyMain.Controls.Add(this.lblSingle);
            this.gbHotkeyMain.Controls.Add(this.cmbSingle);
            this.gbHotkeyMain.Controls.Add(this.lblDouble);
            this.gbHotkeyMain.Controls.Add(this.cmbDouble);
            this.gbHotkeyMain.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.gbHotkeyMain.FillColor = System.Drawing.Color.Black;
            this.gbHotkeyMain.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbHotkeyMain.ForeColor = System.Drawing.Color.Black;
            this.gbHotkeyMain.Location = new System.Drawing.Point(15, 15);
            this.gbHotkeyMain.Name = "gbHotkeyMain";
            this.gbHotkeyMain.Size = new System.Drawing.Size(625, 180);
            this.gbHotkeyMain.TabIndex = 0;
            this.gbHotkeyMain.Text = "Configuración de Teclas Rápidas";
            // 
            // lblStartStop
            // 
            this.lblStartStop.BackColor = System.Drawing.Color.Transparent;
            this.lblStartStop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStartStop.ForeColor = System.Drawing.Color.White;
            this.lblStartStop.Location = new System.Drawing.Point(20, 64);
            this.lblStartStop.Name = "lblStartStop";
            this.lblStartStop.Size = new System.Drawing.Size(91, 19);
            this.lblStartStop.TabIndex = 0;
            this.lblStartStop.Text = "Iniciar/Detener:";
            // 
            // cmbStartStop
            // 
            this.cmbStartStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.cmbStartStop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStartStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartStop.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.cmbStartStop.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.cmbStartStop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStartStop.ForeColor = System.Drawing.Color.White;
            this.cmbStartStop.ItemHeight = 30;
            this.cmbStartStop.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "Insert",
            "Home",
            "PageUp",
            "Delete",
            "End",
            "PageDown",
            "F1 + Ctrl",
            "F2 + Ctrl",
            "F3 + Ctrl",
            "F4 + Ctrl",
            "F5 + Ctrl",
            "F6 + Ctrl",
            "F1 + Alt",
            "F2 + Alt",
            "F3 + Alt",
            "F4 + Alt",
            "F5 + Alt",
            "F6 + Alt"});
            this.cmbStartStop.Location = new System.Drawing.Point(180, 59);
            this.cmbStartStop.Name = "cmbStartStop";
            this.cmbStartStop.Size = new System.Drawing.Size(150, 36);
            this.cmbStartStop.TabIndex = 1;
            // 
            // lblPause
            // 
            this.lblPause.BackColor = System.Drawing.Color.Transparent;
            this.lblPause.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPause.ForeColor = System.Drawing.Color.White;
            this.lblPause.Location = new System.Drawing.Point(20, 121);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(45, 19);
            this.lblPause.TabIndex = 2;
            this.lblPause.Text = "Pausar:";
            // 
            // cmbPause
            // 
            this.cmbPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.cmbPause.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPause.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPause.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.cmbPause.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.cmbPause.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPause.ForeColor = System.Drawing.Color.White;
            this.cmbPause.ItemHeight = 30;
            this.cmbPause.Items.AddRange(new object[] {
            "Ninguna",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "Insert",
            "Home",
            "PageUp",
            "Delete",
            "End",
            "PageDown"});
            this.cmbPause.Location = new System.Drawing.Point(180, 104);
            this.cmbPause.Name = "cmbPause";
            this.cmbPause.Size = new System.Drawing.Size(150, 36);
            this.cmbPause.TabIndex = 3;
            // 
            // lblSingle
            // 
            this.lblSingle.BackColor = System.Drawing.Color.Transparent;
            this.lblSingle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSingle.ForeColor = System.Drawing.Color.White;
            this.lblSingle.Location = new System.Drawing.Point(380, 64);
            this.lblSingle.Name = "lblSingle";
            this.lblSingle.Size = new System.Drawing.Size(75, 19);
            this.lblSingle.TabIndex = 4;
            this.lblSingle.Text = "Click Simple:";
            // 
            // cmbSingle
            // 
            this.cmbSingle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.cmbSingle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSingle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSingle.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.cmbSingle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.cmbSingle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSingle.ForeColor = System.Drawing.Color.White;
            this.cmbSingle.ItemHeight = 30;
            this.cmbSingle.Items.AddRange(new object[] {
            "Ninguna",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "Insert",
            "Home",
            "PageUp",
            "Delete",
            "End",
            "PageDown"});
            this.cmbSingle.Location = new System.Drawing.Point(470, 59);
            this.cmbSingle.Name = "cmbSingle";
            this.cmbSingle.Size = new System.Drawing.Size(130, 36);
            this.cmbSingle.TabIndex = 5;
            // 
            // lblDouble
            // 
            this.lblDouble.BackColor = System.Drawing.Color.Transparent;
            this.lblDouble.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDouble.ForeColor = System.Drawing.Color.White;
            this.lblDouble.Location = new System.Drawing.Point(380, 109);
            this.lblDouble.Name = "lblDouble";
            this.lblDouble.Size = new System.Drawing.Size(71, 19);
            this.lblDouble.TabIndex = 6;
            this.lblDouble.Text = "Doble Click:";
            // 
            // cmbDouble
            // 
            this.cmbDouble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.cmbDouble.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDouble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDouble.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.cmbDouble.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.cmbDouble.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDouble.ForeColor = System.Drawing.Color.White;
            this.cmbDouble.ItemHeight = 30;
            this.cmbDouble.Items.AddRange(new object[] {
            "Ninguna",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "Insert",
            "Home",
            "PageUp",
            "Delete",
            "End",
            "PageDown"});
            this.cmbDouble.Location = new System.Drawing.Point(470, 104);
            this.cmbDouble.Name = "cmbDouble";
            this.cmbDouble.Size = new System.Drawing.Size(130, 36);
            this.cmbDouble.TabIndex = 7;
            // 
            // gbTray
            // 
            this.gbTray.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.gbTray.BorderThickness = 2;
            this.gbTray.Controls.Add(this.chkTray);
            this.gbTray.Controls.Add(this.chkStartMinimized);
            this.gbTray.Controls.Add(this.chkTopMost);
            this.gbTray.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.gbTray.FillColor = System.Drawing.Color.Black;
            this.gbTray.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbTray.ForeColor = System.Drawing.Color.White;
            this.gbTray.Location = new System.Drawing.Point(15, 210);
            this.gbTray.Name = "gbTray";
            this.gbTray.Size = new System.Drawing.Size(625, 126);
            this.gbTray.TabIndex = 1;
            this.gbTray.Text = "Configuración de Bandeja";
            // 
            // chkTray
            // 
            this.chkTray.AutoSize = true;
            this.chkTray.BackColor = System.Drawing.Color.Transparent;
            this.chkTray.CheckedState.BorderRadius = 0;
            this.chkTray.CheckedState.BorderThickness = 0;
            this.chkTray.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkTray.ForeColor = System.Drawing.Color.White;
            this.chkTray.Location = new System.Drawing.Point(20, 44);
            this.chkTray.Name = "chkTray";
            this.chkTray.Size = new System.Drawing.Size(190, 19);
            this.chkTray.TabIndex = 0;
            this.chkTray.Text = "Minimizar a la bandeja al cerrar";
            this.chkTray.UncheckedState.BorderRadius = 0;
            this.chkTray.UncheckedState.BorderThickness = 0;
            this.chkTray.UseVisualStyleBackColor = false;
            // 
            // chkStartMinimized
            // 
            this.chkStartMinimized.AutoSize = true;
            this.chkStartMinimized.BackColor = System.Drawing.Color.Transparent;
            this.chkStartMinimized.CheckedState.BorderRadius = 0;
            this.chkStartMinimized.CheckedState.BorderThickness = 0;
            this.chkStartMinimized.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkStartMinimized.ForeColor = System.Drawing.Color.White;
            this.chkStartMinimized.Location = new System.Drawing.Point(20, 69);
            this.chkStartMinimized.Name = "chkStartMinimized";
            this.chkStartMinimized.Size = new System.Drawing.Size(185, 19);
            this.chkStartMinimized.TabIndex = 1;
            this.chkStartMinimized.Text = "Iniciar minimizado en bandeja";
            this.chkStartMinimized.UncheckedState.BorderRadius = 0;
            this.chkStartMinimized.UncheckedState.BorderThickness = 0;
            this.chkStartMinimized.UseVisualStyleBackColor = false;
            // 
            // chkTopMost
            // 
            this.chkTopMost.AutoSize = true;
            this.chkTopMost.BackColor = System.Drawing.Color.Transparent;
            this.chkTopMost.Checked = true;
            this.chkTopMost.CheckedState.BorderRadius = 0;
            this.chkTopMost.CheckedState.BorderThickness = 0;
            this.chkTopMost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTopMost.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkTopMost.ForeColor = System.Drawing.Color.White;
            this.chkTopMost.Location = new System.Drawing.Point(20, 94);
            this.chkTopMost.Name = "chkTopMost";
            this.chkTopMost.Size = new System.Drawing.Size(158, 19);
            this.chkTopMost.TabIndex = 2;
            this.chkTopMost.Text = "Mantener siempre visible";
            this.chkTopMost.UncheckedState.BorderRadius = 0;
            this.chkTopMost.UncheckedState.BorderThickness = 0;
            this.chkTopMost.UseVisualStyleBackColor = false;
            // 
            // tabAbout
            // 
            this.tabAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.tabAbout.Controls.Add(this.pictureLogo);
            this.tabAbout.Controls.Add(this.lblAbout);
            this.tabAbout.Location = new System.Drawing.Point(4, 44);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(15);
            this.tabAbout.Size = new System.Drawing.Size(662, 382);
            this.tabAbout.TabIndex = 2;
            this.tabAbout.Text = "Acerca de";
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.ImageRotate = 0F;
            this.pictureLogo.Location = new System.Drawing.Point(50, 50);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(128, 128);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // lblAbout
            // 
            this.lblAbout.BackColor = System.Drawing.Color.Transparent;
            this.lblAbout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAbout.ForeColor = System.Drawing.Color.White;
            this.lblAbout.Location = new System.Drawing.Point(200, 50);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(336, 325);
            this.lblAbout.TabIndex = 1;
            this.lblAbout.Text = resources.GetString("lblAbout.Text");
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.Transparent;
            this.panelFooter.Controls.Add(this.lblStatus);
            this.panelFooter.Controls.Add(this.btnPause);
            this.panelFooter.Controls.Add(this.btnStop);
            this.panelFooter.Controls.Add(this.btnStart);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.panelFooter.Location = new System.Drawing.Point(0, 500);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(700, 70);
            this.panelFooter.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.Location = new System.Drawing.Point(20, 25);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(103, 19);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Estado: Detenido";
            // 
            // btnPause
            // 
            this.btnPause.Animated = true;
            this.btnPause.BorderRadius = 10;
            this.btnPause.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPause.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPause.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPause.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPause.Enabled = false;
            this.btnPause.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(50)))));
            this.btnPause.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(70)))));
            this.btnPause.Location = new System.Drawing.Point(380, 15);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(100, 40);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "PAUSAR";
            // 
            // btnStop
            // 
            this.btnStop.Animated = true;
            this.btnStop.BorderRadius = 10;
            this.btnStop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStop.Enabled = false;
            this.btnStop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnStop.Location = new System.Drawing.Point(490, 15);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 40);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "DETENER";
            // 
            // btnStart
            // 
            this.btnStart.Animated = true;
            this.btnStart.BorderRadius = 10;
            this.btnStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(220)))), ((int)(((byte)(120)))));
            this.btnStart.Location = new System.Drawing.Point(270, 15);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 40);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "INICIAR";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.trayMenu;
            this.notifyIcon.Text = "AutoClicker Pro";
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsShow,
            this.tsStart,
            this.tsPause,
            this.tsStop,
            this.tsSeparator,
            this.tsExit});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.Size = new System.Drawing.Size(116, 120);
            // 
            // tsShow
            // 
            this.tsShow.Name = "tsShow";
            this.tsShow.Size = new System.Drawing.Size(115, 22);
            this.tsShow.Text = "Mostrar";
            // 
            // tsStart
            // 
            this.tsStart.Name = "tsStart";
            this.tsStart.Size = new System.Drawing.Size(115, 22);
            this.tsStart.Text = "Iniciar";
            // 
            // tsPause
            // 
            this.tsPause.Enabled = false;
            this.tsPause.Name = "tsPause";
            this.tsPause.Size = new System.Drawing.Size(115, 22);
            this.tsPause.Text = "Pausar";
            // 
            // tsStop
            // 
            this.tsStop.Enabled = false;
            this.tsStop.Name = "tsStop";
            this.tsStop.Size = new System.Drawing.Size(115, 22);
            this.tsStop.Text = "Detener";
            // 
            // tsSeparator
            // 
            this.tsSeparator.Name = "tsSeparator";
            this.tsSeparator.Size = new System.Drawing.Size(112, 6);
            // 
            // tsExit
            // 
            this.tsExit.Name = "tsExit";
            this.tsExit.Size = new System.Drawing.Size(115, 22);
            this.tsExit.Text = "Salir";
            // 
            // timerHotkey
            // 
            this.timerHotkey.Interval = 50;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(700, 570);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoClicker Pro";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPrincipal.ResumeLayout(false);
            this.gbClickType.ResumeLayout(false);
            this.gbClickType.PerformLayout();
            this.gbClickMode.ResumeLayout(false);
            this.gbClickMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudClicks)).EndInit();
            this.gbSpeed.ResumeLayout(false);
            this.gbSpeed.PerformLayout();
            this.pnlRandom.ResumeLayout(false);
            this.pnlRandom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            this.gbPosition.ResumeLayout(false);
            this.gbPosition.PerformLayout();
            this.tabHotkeys.ResumeLayout(false);
            this.gbHotkeyMain.ResumeLayout(false);
            this.gbHotkeyMain.PerformLayout();
            this.gbTray.ResumeLayout(false);
            this.gbTray.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.trayMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}