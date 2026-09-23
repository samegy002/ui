namespace BICloudToolkit
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlCreditBanner = new BICloudToolkit.Controls.RoundedPanel();
            this.lblCreditText = new System.Windows.Forms.Label();
            this.btnCloseCredit = new System.Windows.Forms.Button();
            this.lblHeaderBrand = new System.Windows.Forms.Label();
            this.lblHeaderPlatform = new System.Windows.Forms.Label();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.pnlCenterDashboard = new System.Windows.Forms.Panel();
            this.pnlCenterEmptyState = new BICloudToolkit.Controls.RoundedPanel();
            this.graphicEmptyDevice = new BICloudToolkit.Controls.DeviceEmptyGraphic();
            this.lblNoDeviceTitle = new System.Windows.Forms.Label();
            this.lblNoDeviceSubtitle = new System.Windows.Forms.Label();
            this.pnlDfuStatusPill = new BICloudToolkit.Controls.RoundedPanel();
            this.lblDfuStatus = new System.Windows.Forms.Label();
            this.pnlOptimizationBanner = new BICloudToolkit.Controls.RoundedPanel();
            this.lblOptimizationTitle = new System.Windows.Forms.Label();
            this.lblOptimizationBody = new System.Windows.Forms.Label();
            this.cardToolbox = new BICloudToolkit.Controls.FeatureCard();
            this.tblFeatureGrid = new System.Windows.Forms.TableLayoutPanel();
            this.cardA12 = new BICloudToolkit.Controls.FeatureCard();
            this.cardRamdisk = new BICloudToolkit.Controls.FeatureCard();
            this.cardJailbreak = new BICloudToolkit.Controls.FeatureCard();
            this.cardMdm = new BICloudToolkit.Controls.FeatureCard();
            this.pnlRightStatus = new System.Windows.Forms.Panel();
            this.pnlStatusHeader = new System.Windows.Forms.Panel();
            this.lblStatusHeaderTitle = new System.Windows.Forms.Label();
            this.btnRefreshStatus = new System.Windows.Forms.Button();
            this.statusA12 = new BICloudToolkit.Controls.StatusItem();
            this.statusRamdisk = new BICloudToolkit.Controls.StatusItem();
            this.statusJailbreak = new BICloudToolkit.Controls.StatusItem();
            this.statusMdm = new BICloudToolkit.Controls.StatusItem();
            this.pnlConnectionError = new BICloudToolkit.Controls.RoundedPanel();
            this.lblErrorTitle = new System.Windows.Forms.Label();
            this.lblErrorSubtitle = new System.Windows.Forms.Label();
            this.lblErrorCode = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlBrandHeader = new System.Windows.Forms.Panel();
            this.lblBrandTitle = new System.Windows.Forms.Label();
            this.lblBrandSubtitle = new System.Windows.Forms.Label();
            this.btnNavHome = new BICloudToolkit.Controls.SidebarButton();
            this.btnNavDeviceInfo = new BICloudToolkit.Controls.SidebarButton();
            this.btnNavBypassTools = new BICloudToolkit.Controls.SidebarButton();
            this.btnNavToolbox = new BICloudToolkit.Controls.SidebarButton();
            this.btnNavSettings = new BICloudToolkit.Controls.SidebarButton();
            this.btnNavAbout = new BICloudToolkit.Controls.SidebarButton();
            this.lblSidebarVersion = new System.Windows.Forms.Label();
            this.pnlBottomBar = new System.Windows.Forms.Panel();
            this.pnlDeviceIdentifier = new BICloudToolkit.Controls.RoundedPanel();
            this.lblDeviceModel = new System.Windows.Forms.Label();
            this.pnlDisconnectedPill = new BICloudToolkit.Controls.RoundedPanel();
            this.lblDisconnected = new System.Windows.Forms.Label();
            this.flpActionButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReadDevice = new BICloudToolkit.Controls.ActionButton();
            this.btnExitRecovery = new BICloudToolkit.Controls.ActionButton();
            this.btnActivateDevice = new BICloudToolkit.Controls.ActionButton();
            this.btnBlockOta = new BICloudToolkit.Controls.ActionButton();
            this.pnlHeader.SuspendLayout();
            this.pnlCreditBanner.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.pnlCenterDashboard.SuspendLayout();
            this.pnlCenterEmptyState.SuspendLayout();
            this.pnlDfuStatusPill.SuspendLayout();
            this.pnlOptimizationBanner.SuspendLayout();
            this.tblFeatureGrid.SuspendLayout();
            this.pnlRightStatus.SuspendLayout();
            this.pnlStatusHeader.SuspendLayout();
            this.pnlConnectionError.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlBrandHeader.SuspendLayout();
            this.pnlBottomBar.SuspendLayout();
            this.pnlDeviceIdentifier.SuspendLayout();
            this.pnlDisconnectedPill.SuspendLayout();
            this.flpActionButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.pnlHeader.Controls.Add(this.pnlCreditBanner);
            this.pnlHeader.Controls.Add(this.lblHeaderBrand);
            this.pnlHeader.Controls.Add(this.lblHeaderPlatform);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 44;
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlCreditBanner
            // 
            this.pnlCreditBanner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCreditBanner.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.pnlCreditBanner.CornerRadius = 14;
            this.pnlCreditBanner.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.pnlCreditBanner.Controls.Add(this.lblCreditText);
            this.pnlCreditBanner.Controls.Add(this.btnCloseCredit);
            this.pnlCreditBanner.Location = new System.Drawing.Point(470, 7);
            this.pnlCreditBanner.Size = new System.Drawing.Size(260, 28);
            this.pnlCreditBanner.Padding = new System.Windows.Forms.Padding(10, 2, 8, 2);
            // 
            // lblCreditText
            // 
            this.lblCreditText.AutoSize = true;
            this.lblCreditText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblCreditText.Location = new System.Drawing.Point(12, 6);
            this.lblCreditText.Text = "(!)  You are running out of credits.";
            // 
            // btnCloseCredit
            // 
            this.btnCloseCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseCredit.FlatAppearance.BorderSize = 0;
            this.btnCloseCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseCredit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnCloseCredit.Location = new System.Drawing.Point(232, 4);
            this.btnCloseCredit.Size = new System.Drawing.Size(20, 20);
            this.btnCloseCredit.Text = "×";
            this.btnCloseCredit.Click += new System.EventHandler(this.BtnCloseCredit_Click);
            // 
            // lblHeaderBrand
            // 
            this.lblHeaderBrand.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHeaderBrand.ForeColor = System.Drawing.Color.White;
            this.lblHeaderBrand.Location = new System.Drawing.Point(18, 6);
            this.lblHeaderBrand.Size = new System.Drawing.Size(120, 18);
            this.lblHeaderBrand.Text = "☁ B-ICLOUD";
            // 
            // lblHeaderPlatform
            // 
            this.lblHeaderPlatform.Font = new System.Drawing.Font("Segoe UI", 6.5F, System.Drawing.FontStyle.Bold);
            this.lblHeaderPlatform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblHeaderPlatform.Location = new System.Drawing.Point(40, 24);
            this.lblHeaderPlatform.Size = new System.Drawing.Size(80, 14);
            this.lblHeaderPlatform.Text = "PLATFORM";
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Controls.Add(this.pnlCenterDashboard);
            this.pnlMainContent.Controls.Add(this.pnlRightStatus);
            this.pnlMainContent.Controls.Add(this.pnlSidebar);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(0, 44);
            this.pnlMainContent.Size = new System.Drawing.Size(1280, 686);
            this.pnlMainContent.TabIndex = 1;
            // 
            // pnlCenterDashboard
            // 
            this.pnlCenterDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.pnlCenterDashboard.Controls.Add(this.pnlCenterEmptyState);
            this.pnlCenterDashboard.Controls.Add(this.pnlOptimizationBanner);
            this.pnlCenterDashboard.Controls.Add(this.cardToolbox);
            this.pnlCenterDashboard.Controls.Add(this.tblFeatureGrid);
            this.pnlCenterDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenterDashboard.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            // 
            // tblFeatureGrid
            // 
            this.tblFeatureGrid.ColumnCount = 2;
            this.tblFeatureGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblFeatureGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblFeatureGrid.RowCount = 2;
            this.tblFeatureGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tblFeatureGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tblFeatureGrid.Controls.Add(this.cardA12, 0, 0);
            this.tblFeatureGrid.Controls.Add(this.cardRamdisk, 1, 0);
            this.tblFeatureGrid.Controls.Add(this.cardJailbreak, 0, 1);
            this.tblFeatureGrid.Controls.Add(this.cardMdm, 1, 1);
            this.tblFeatureGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblFeatureGrid.Height = 148;
            // 
            // cardA12
            // 
            this.cardA12.CardType = BICloudToolkit.Controls.FeatureCardType.A12Bypass;
            this.cardA12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardA12.Margin = new System.Windows.Forms.Padding(4);
            // 
            // cardRamdisk
            // 
            this.cardRamdisk.CardType = BICloudToolkit.Controls.FeatureCardType.RamdiskBypass;
            this.cardRamdisk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardRamdisk.Margin = new System.Windows.Forms.Padding(4);
            // 
            // cardJailbreak
            // 
            this.cardJailbreak.CardType = BICloudToolkit.Controls.FeatureCardType.JailbreakBypass;
            this.cardJailbreak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardJailbreak.Margin = new System.Windows.Forms.Padding(4);
            // 
            // cardMdm
            // 
            this.cardMdm.CardType = BICloudToolkit.Controls.FeatureCardType.MdmBypass;
            this.cardMdm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardMdm.Margin = new System.Windows.Forms.Padding(4);
            // 
            // cardToolbox
            // 
            this.cardToolbox.CardType = BICloudToolkit.Controls.FeatureCardType.Toolbox;
            this.cardToolbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardToolbox.Height = 64;
            this.cardToolbox.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            // 
            // pnlCenterEmptyState
            // 
            this.pnlCenterEmptyState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.pnlCenterEmptyState.BorderWidth = 1.2F;
            this.pnlCenterEmptyState.CornerRadius = 14;
            this.pnlCenterEmptyState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.pnlCenterEmptyState.Controls.Add(this.graphicEmptyDevice);
            this.pnlCenterEmptyState.Controls.Add(this.lblNoDeviceTitle);
            this.pnlCenterEmptyState.Controls.Add(this.lblNoDeviceSubtitle);
            this.pnlCenterEmptyState.Controls.Add(this.pnlDfuStatusPill);
            this.pnlCenterEmptyState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenterEmptyState.Margin = new System.Windows.Forms.Padding(4, 12, 4, 10);
            // 
            // graphicEmptyDevice
            // 
            this.graphicEmptyDevice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.graphicEmptyDevice.Location = new System.Drawing.Point(295, 30);
            this.graphicEmptyDevice.Size = new System.Drawing.Size(140, 140);
            // 
            // lblNoDeviceTitle
            // 
            this.lblNoDeviceTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoDeviceTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblNoDeviceTitle.ForeColor = System.Drawing.Color.White;
            this.lblNoDeviceTitle.Location = new System.Drawing.Point(120, 180);
            this.lblNoDeviceTitle.Size = new System.Drawing.Size(490, 32);
            this.lblNoDeviceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoDeviceTitle.Text = "No Device Connected";
            // 
            // lblNoDeviceSubtitle
            // 
            this.lblNoDeviceSubtitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoDeviceSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNoDeviceSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblNoDeviceSubtitle.Location = new System.Drawing.Point(100, 218);
            this.lblNoDeviceSubtitle.Size = new System.Drawing.Size(530, 36);
            this.lblNoDeviceSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoDeviceSubtitle.Text = "Connect your Apple device via USB-C or Lightning cable to begin the bypass process.";
            // 
            // pnlDfuStatusPill
            // 
            this.pnlDfuStatusPill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDfuStatusPill.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.pnlDfuStatusPill.CornerRadius = 13;
            this.pnlDfuStatusPill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.pnlDfuStatusPill.Controls.Add(this.lblDfuStatus);
            this.pnlDfuStatusPill.Location = new System.Drawing.Point(265, 264);
            this.pnlDfuStatusPill.Size = new System.Drawing.Size(200, 28);
            this.pnlDfuStatusPill.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            // 
            // lblDfuStatus
            // 
            this.lblDfuStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDfuStatus.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblDfuStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.lblDfuStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDfuStatus.Text = "●  WAITING FOR DFU MODE...";
            // 
            // pnlOptimizationBanner
            // 
            this.pnlOptimizationBanner.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlOptimizationBanner.BorderWidth = 1F;
            this.pnlOptimizationBanner.CornerRadius = 10;
            this.pnlOptimizationBanner.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlOptimizationBanner.Controls.Add(this.lblOptimizationTitle);
            this.pnlOptimizationBanner.Controls.Add(this.lblOptimizationBody);
            this.pnlOptimizationBanner.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOptimizationBanner.Height = 52;
            this.pnlOptimizationBanner.Margin = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.pnlOptimizationBanner.Padding = new System.Windows.Forms.Padding(14, 8, 14, 8);
            // 
            // lblOptimizationTitle
            // 
            this.lblOptimizationTitle.AutoSize = true;
            this.lblOptimizationTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblOptimizationTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.lblOptimizationTitle.Location = new System.Drawing.Point(14, 8);
            this.lblOptimizationTitle.Text = "ⓘ  SOFTWARE OPTIMIZATION";
            // 
            // lblOptimizationBody
            // 
            this.lblOptimizationBody.AutoSize = true;
            this.lblOptimizationBody.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblOptimizationBody.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblOptimizationBody.Location = new System.Drawing.Point(14, 26);
            this.lblOptimizationBody.Text = "Database version 2.4.8 is now active. All A12+ bypass scripts verified for iOS 17.5 compatibility.";
            // 
            // pnlRightStatus
            // 
            this.pnlRightStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(30)))));
            this.pnlRightStatus.Controls.Add(this.pnlConnectionError);
            this.pnlRightStatus.Controls.Add(this.statusMdm);
            this.pnlRightStatus.Controls.Add(this.statusJailbreak);
            this.pnlRightStatus.Controls.Add(this.statusRamdisk);
            this.pnlRightStatus.Controls.Add(this.statusA12);
            this.pnlRightStatus.Controls.Add(this.pnlStatusHeader);
            this.pnlRightStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRightStatus.Padding = new System.Windows.Forms.Padding(14, 12, 14, 12);
            this.pnlRightStatus.Width = 310;
            // 
            // pnlStatusHeader
            // 
            this.pnlStatusHeader.Controls.Add(this.lblStatusHeaderTitle);
            this.pnlStatusHeader.Controls.Add(this.btnRefreshStatus);
            this.pnlStatusHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatusHeader.Height = 40;
            // 
            // lblStatusHeaderTitle
            // 
            this.lblStatusHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblStatusHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblStatusHeaderTitle.Location = new System.Drawing.Point(4, 8);
            this.lblStatusHeaderTitle.Size = new System.Drawing.Size(220, 24);
            this.lblStatusHeaderTitle.Text = "Toolkit Status Monitor";
            // 
            // btnRefreshStatus
            // 
            this.btnRefreshStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshStatus.FlatAppearance.BorderSize = 0;
            this.btnRefreshStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshStatus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnRefreshStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnRefreshStatus.Location = new System.Drawing.Point(248, 6);
            this.btnRefreshStatus.Size = new System.Drawing.Size(28, 28);
            this.btnRefreshStatus.Text = "↻";
            this.btnRefreshStatus.Click += new System.EventHandler(this.BtnRefreshStatus_Click);
            // 
            // statusA12
            // 
            this.statusA12.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusA12.Icon = BICloudToolkit.Controls.StatusItemIcon.Chip;
            this.statusA12.IsActive = true;
            this.statusA12.Title = "A12+ Bypass";
            this.statusA12.Subtitle = "iOS 26.0.1 / 26.1";
            this.statusA12.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            // 
            // statusRamdisk
            // 
            this.statusRamdisk.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusRamdisk.Icon = BICloudToolkit.Controls.StatusItemIcon.Disk;
            this.statusRamdisk.IsActive = false;
            this.statusRamdisk.Title = "Ramdisk Bypass";
            this.statusRamdisk.Subtitle = "iPhone 6 to X";
            this.statusRamdisk.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            // 
            // statusJailbreak
            // 
            this.statusJailbreak.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusJailbreak.Icon = BICloudToolkit.Controls.StatusItemIcon.Lock;
            this.statusJailbreak.IsActive = false;
            this.statusJailbreak.Title = "Jailbreak Bypass";
            this.statusJailbreak.Subtitle = "iPhone 5s to X";
            this.statusJailbreak.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            // 
            // statusMdm
            // 
            this.statusMdm.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusMdm.Icon = BICloudToolkit.Controls.StatusItemIcon.Shield;
            this.statusMdm.IsActive = false;
            this.statusMdm.Title = "MDM Bypass";
            this.statusMdm.Subtitle = "All iOS / iPad";
            this.statusMdm.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            // 
            // pnlConnectionError
            // 
            this.pnlConnectionError.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(29)))), ((int)(((byte)(149)))));
            this.pnlConnectionError.BorderWidth = 1F;
            this.pnlConnectionError.CornerRadius = 10;
            this.pnlConnectionError.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(41)))));
            this.pnlConnectionError.Controls.Add(this.lblErrorTitle);
            this.pnlConnectionError.Controls.Add(this.lblErrorSubtitle);
            this.pnlConnectionError.Controls.Add(this.lblErrorCode);
            this.pnlConnectionError.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlConnectionError.Height = 110;
            this.pnlConnectionError.Padding = new System.Windows.Forms.Padding(12);
            // 
            // lblErrorTitle
            // 
            this.lblErrorTitle.AutoSize = true;
            this.lblErrorTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblErrorTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.lblErrorTitle.Location = new System.Drawing.Point(12, 10);
            this.lblErrorTitle.Text = "(!)  CONNECTION UNAVAILABLE.";
            // 
            // lblErrorSubtitle
            // 
            this.lblErrorSubtitle.AutoSize = true;
            this.lblErrorSubtitle.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblErrorSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblErrorSubtitle.Location = new System.Drawing.Point(12, 34);
            this.lblErrorSubtitle.Text = "No device is currently connected.";
            // 
            // lblErrorCode
            // 
            this.lblErrorCode.AutoSize = true;
            this.lblErrorCode.Font = new System.Drawing.Font("Consolas", 7.5F);
            this.lblErrorCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.lblErrorCode.Location = new System.Drawing.Point(12, 58);
            this.lblErrorCode.Text = "ERR_LOCKDOWN_FAIL: (-17) Password Protected";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.pnlSidebar.Controls.Add(this.lblSidebarVersion);
            this.pnlSidebar.Controls.Add(this.btnNavAbout);
            this.pnlSidebar.Controls.Add(this.btnNavSettings);
            this.pnlSidebar.Controls.Add(this.btnNavToolbox);
            this.pnlSidebar.Controls.Add(this.btnNavBypassTools);
            this.pnlSidebar.Controls.Add(this.btnNavDeviceInfo);
            this.pnlSidebar.Controls.Add(this.btnNavHome);
            this.pnlSidebar.Controls.Add(this.pnlBrandHeader);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Padding = new System.Windows.Forms.Padding(14, 12, 14, 12);
            this.pnlSidebar.Width = 220;
            // 
            // pnlBrandHeader
            // 
            this.pnlBrandHeader.Controls.Add(this.lblBrandTitle);
            this.pnlBrandHeader.Controls.Add(this.lblBrandSubtitle);
            this.pnlBrandHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBrandHeader.Height = 65;
            this.pnlBrandHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlBrandHeader_Paint);
            // 
            // lblBrandTitle
            // 
            this.lblBrandTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblBrandTitle.ForeColor = System.Drawing.Color.White;
            this.lblBrandTitle.Location = new System.Drawing.Point(54, 12);
            this.lblBrandTitle.Size = new System.Drawing.Size(130, 20);
            this.lblBrandTitle.Text = "B-ICLOUD";
            // 
            // lblBrandSubtitle
            // 
            this.lblBrandSubtitle.Font = new System.Drawing.Font("Segoe UI", 6.5F, System.Drawing.FontStyle.Bold);
            this.lblBrandSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblBrandSubtitle.Location = new System.Drawing.Point(54, 32);
            this.lblBrandSubtitle.Size = new System.Drawing.Size(130, 16);
            this.lblBrandSubtitle.Text = "APPLE DEVICE TOOLKIT";
            // 
            // btnNavHome
            // 
            this.btnNavHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavHome.IconType = BICloudToolkit.Controls.SidebarIconType.Home;
            this.btnNavHome.IsActive = true;
            this.btnNavHome.Text = "Home";
            this.btnNavHome.Click += new System.EventHandler(this.SidebarButton_Click);
            // 
            // btnNavDeviceInfo
            // 
            this.btnNavDeviceInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavDeviceInfo.IconType = BICloudToolkit.Controls.SidebarIconType.DeviceInfo;
            this.btnNavDeviceInfo.Text = "Device Info";
            this.btnNavDeviceInfo.Click += new System.EventHandler(this.SidebarButton_Click);
            // 
            // btnNavBypassTools
            // 
            this.btnNavBypassTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavBypassTools.IconType = BICloudToolkit.Controls.SidebarIconType.BypassTools;
            this.btnNavBypassTools.Text = "Bypass Tools";
            this.btnNavBypassTools.Click += new System.EventHandler(this.SidebarButton_Click);
            // 
            // btnNavToolbox
            // 
            this.btnNavToolbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavToolbox.IconType = BICloudToolkit.Controls.SidebarIconType.Toolbox;
            this.btnNavToolbox.Text = "Toolbox";
            this.btnNavToolbox.Click += new System.EventHandler(this.SidebarButton_Click);
            // 
            // btnNavSettings
            // 
            this.btnNavSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavSettings.IconType = BICloudToolkit.Controls.SidebarIconType.Settings;
            this.btnNavSettings.Text = "Settings";
            this.btnNavSettings.Click += new System.EventHandler(this.SidebarButton_Click);
            // 
            // btnNavAbout
            // 
            this.btnNavAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavAbout.IconType = BICloudToolkit.Controls.SidebarIconType.About;
            this.btnNavAbout.Text = "About";
            this.btnNavAbout.Click += new System.EventHandler(this.SidebarButton_Click);
            // 
            // lblSidebarVersion
            // 
            this.lblSidebarVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSidebarVersion.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.lblSidebarVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblSidebarVersion.Location = new System.Drawing.Point(14, 650);
            this.lblSidebarVersion.Size = new System.Drawing.Size(192, 24);
            this.lblSidebarVersion.Text = "V2.0.0 STABLE";
            this.lblSidebarVersion.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pnlBottomBar
            // 
            this.pnlBottomBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(30)))));
            this.pnlBottomBar.Controls.Add(this.flpActionButtons);
            this.pnlBottomBar.Controls.Add(this.pnlDisconnectedPill);
            this.pnlBottomBar.Controls.Add(this.pnlDeviceIdentifier);
            this.pnlBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomBar.Height = 62;
            this.pnlBottomBar.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            // 
            // pnlDeviceIdentifier
            // 
            this.pnlDeviceIdentifier.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.pnlDeviceIdentifier.CornerRadius = 10;
            this.pnlDeviceIdentifier.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.pnlDeviceIdentifier.Controls.Add(this.lblDeviceModel);
            this.pnlDeviceIdentifier.Location = new System.Drawing.Point(16, 12);
            this.pnlDeviceIdentifier.Size = new System.Drawing.Size(130, 38);
            this.pnlDeviceIdentifier.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlDeviceIdentifier_Paint);
            // 
            // lblDeviceModel
            // 
            this.lblDeviceModel.AutoSize = true;
            this.lblDeviceModel.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblDeviceModel.ForeColor = System.Drawing.Color.White;
            this.lblDeviceModel.Location = new System.Drawing.Point(34, 12);
            this.lblDeviceModel.Text = "iPhone 13 Pro";
            // 
            // pnlDisconnectedPill
            // 
            this.pnlDisconnectedPill.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(29)))), ((int)(((byte)(149)))));
            this.pnlDisconnectedPill.CornerRadius = 10;
            this.pnlDisconnectedPill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(22)))), ((int)(((byte)(58)))));
            this.pnlDisconnectedPill.Controls.Add(this.lblDisconnected);
            this.pnlDisconnectedPill.Location = new System.Drawing.Point(154, 12);
            this.pnlDisconnectedPill.Size = new System.Drawing.Size(135, 38);
            this.pnlDisconnectedPill.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlDisconnectedPill_Paint);
            // 
            // lblDisconnected
            // 
            this.lblDisconnected.AutoSize = true;
            this.lblDisconnected.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblDisconnected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.lblDisconnected.Location = new System.Drawing.Point(34, 12);
            this.lblDisconnected.Text = "DISCONNECTED";
            // 
            // flpActionButtons
            // 
            this.flpActionButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flpActionButtons.Controls.Add(this.btnReadDevice);
            this.flpActionButtons.Controls.Add(this.btnExitRecovery);
            this.flpActionButtons.Controls.Add(this.btnActivateDevice);
            this.flpActionButtons.Controls.Add(this.btnBlockOta);
            this.flpActionButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpActionButtons.Location = new System.Drawing.Point(620, 10);
            this.flpActionButtons.Size = new System.Drawing.Size(644, 42);
            // 
            // btnReadDevice
            // 
            this.btnReadDevice.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnReadDevice.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.btnReadDevice.BorderColor = System.Drawing.Color.Transparent;
            this.btnReadDevice.Icon = BICloudToolkit.Controls.ActionButtonIcon.ReadDevice;
            this.btnReadDevice.Size = new System.Drawing.Size(126, 38);
            this.btnReadDevice.Text = "Read Device";
            this.btnReadDevice.TextColor = System.Drawing.Color.White;
            // 
            // btnExitRecovery
            // 
            this.btnExitRecovery.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnExitRecovery.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnExitRecovery.BorderColor = System.Drawing.Color.Transparent;
            this.btnExitRecovery.Icon = BICloudToolkit.Controls.ActionButtonIcon.ExitRecovery;
            this.btnExitRecovery.Size = new System.Drawing.Size(130, 38);
            this.btnExitRecovery.Text = "Exit Recovery";
            this.btnExitRecovery.TextColor = System.Drawing.Color.White;
            // 
            // btnActivateDevice
            // 
            this.btnActivateDevice.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnActivateDevice.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnActivateDevice.BorderColor = System.Drawing.Color.Transparent;
            this.btnActivateDevice.Icon = BICloudToolkit.Controls.ActionButtonIcon.Activate;
            this.btnActivateDevice.Size = new System.Drawing.Size(142, 38);
            this.btnActivateDevice.Text = "Activate Device";
            this.btnActivateDevice.TextColor = System.Drawing.Color.White;
            // 
            // btnBlockOta
            // 
            this.btnBlockOta.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.btnBlockOta.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnBlockOta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.btnBlockOta.Icon = BICloudToolkit.Controls.ActionButtonIcon.BlockOta;
            this.btnBlockOta.Size = new System.Drawing.Size(154, 38);
            this.btnBlockOta.Text = "Block OTA / Reset";
            this.btnBlockOta.TextColor = System.Drawing.Color.White;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1280, 792);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlBottomBar);
            this.Controls.Add(this.pnlHeader);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(1100, 720);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "B-ICLOUD Platform - Apple Device Toolkit";
            this.pnlHeader.ResumeLayout(false);
            this.pnlCreditBanner.ResumeLayout(false);
            this.pnlCreditBanner.PerformLayout();
            this.pnlMainContent.ResumeLayout(false);
            this.pnlCenterDashboard.ResumeLayout(false);
            this.pnlCenterEmptyState.ResumeLayout(false);
            this.pnlDfuStatusPill.ResumeLayout(false);
            this.pnlOptimizationBanner.ResumeLayout(false);
            this.pnlOptimizationBanner.PerformLayout();
            this.tblFeatureGrid.ResumeLayout(false);
            this.pnlRightStatus.ResumeLayout(false);
            this.pnlStatusHeader.ResumeLayout(false);
            this.pnlConnectionError.ResumeLayout(false);
            this.pnlConnectionError.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlBrandHeader.ResumeLayout(false);
            this.pnlBottomBar.ResumeLayout(false);
            this.pnlDeviceIdentifier.ResumeLayout(false);
            this.pnlDeviceIdentifier.PerformLayout();
            this.pnlDisconnectedPill.ResumeLayout(false);
            this.pnlDisconnectedPill.PerformLayout();
            this.flpActionButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderBrand;
        private System.Windows.Forms.Label lblHeaderPlatform;
        private BICloudToolkit.Controls.RoundedPanel pnlCreditBanner;
        private System.Windows.Forms.Label lblCreditText;
        private System.Windows.Forms.Button btnCloseCredit;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlBrandHeader;
        private System.Windows.Forms.Label lblBrandTitle;
        private System.Windows.Forms.Label lblBrandSubtitle;
        private BICloudToolkit.Controls.SidebarButton btnNavHome;
        private BICloudToolkit.Controls.SidebarButton btnNavDeviceInfo;
        private BICloudToolkit.Controls.SidebarButton btnNavBypassTools;
        private BICloudToolkit.Controls.SidebarButton btnNavToolbox;
        private BICloudToolkit.Controls.SidebarButton btnNavSettings;
        private BICloudToolkit.Controls.SidebarButton btnNavAbout;
        private System.Windows.Forms.Label lblSidebarVersion;
        private System.Windows.Forms.Panel pnlCenterDashboard;
        private System.Windows.Forms.TableLayoutPanel tblFeatureGrid;
        private BICloudToolkit.Controls.FeatureCard cardA12;
        private BICloudToolkit.Controls.FeatureCard cardRamdisk;
        private BICloudToolkit.Controls.FeatureCard cardJailbreak;
        private BICloudToolkit.Controls.FeatureCard cardMdm;
        private BICloudToolkit.Controls.FeatureCard cardToolbox;
        private BICloudToolkit.Controls.RoundedPanel pnlCenterEmptyState;
        private BICloudToolkit.Controls.DeviceEmptyGraphic graphicEmptyDevice;
        private System.Windows.Forms.Label lblNoDeviceTitle;
        private System.Windows.Forms.Label lblNoDeviceSubtitle;
        private BICloudToolkit.Controls.RoundedPanel pnlDfuStatusPill;
        private System.Windows.Forms.Label lblDfuStatus;
        private BICloudToolkit.Controls.RoundedPanel pnlOptimizationBanner;
        private System.Windows.Forms.Label lblOptimizationTitle;
        private System.Windows.Forms.Label lblOptimizationBody;
        private System.Windows.Forms.Panel pnlRightStatus;
        private System.Windows.Forms.Panel pnlStatusHeader;
        private System.Windows.Forms.Label lblStatusHeaderTitle;
        private System.Windows.Forms.Button btnRefreshStatus;
        private BICloudToolkit.Controls.StatusItem statusA12;
        private BICloudToolkit.Controls.StatusItem statusRamdisk;
        private BICloudToolkit.Controls.StatusItem statusJailbreak;
        private BICloudToolkit.Controls.StatusItem statusMdm;
        private BICloudToolkit.Controls.RoundedPanel pnlConnectionError;
        private System.Windows.Forms.Label lblErrorTitle;
        private System.Windows.Forms.Label lblErrorSubtitle;
        private System.Windows.Forms.Label lblErrorCode;
        private System.Windows.Forms.Panel pnlBottomBar;
        private BICloudToolkit.Controls.RoundedPanel pnlDeviceIdentifier;
        private System.Windows.Forms.Label lblDeviceModel;
        private BICloudToolkit.Controls.RoundedPanel pnlDisconnectedPill;
        private System.Windows.Forms.Label lblDisconnected;
        private System.Windows.Forms.FlowLayoutPanel flpActionButtons;
        private BICloudToolkit.Controls.ActionButton btnReadDevice;
        private BICloudToolkit.Controls.ActionButton btnExitRecovery;
        private BICloudToolkit.Controls.ActionButton btnActivateDevice;
        private BICloudToolkit.Controls.ActionButton btnBlockOta;
    }
}
