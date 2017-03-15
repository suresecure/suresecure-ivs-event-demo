namespace SRZNPlatTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnDetail = new DevComponents.DotNetBar.ButtonX();
            this.lbSendStatus = new DevComponents.DotNetBar.LabelX();
            this.txtAlarmType = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btnSend = new DevComponents.DotNetBar.ButtonX();
            this.btnSelect = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.txtHostIdent = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.ipIptHost = new DevComponents.Editors.IpAddressInput();
            this.txtInterval = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.txtChannel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSendCnt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.txtPersonCnt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDescription = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.btnRegist1 = new DevComponents.DotNetBar.ButtonX();
            this.txtServerPort = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ipiptServer = new DevComponents.Editors.IpAddressInput();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.superTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.regularExpressionValidator5 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.regularExpressionValidator2 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.regularExpressionValidator4 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.regularExpressionValidator3 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.regularExpressionValidator6 = new DevComponents.DotNetBar.Validator.RegularExpressionValidator();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipIptHost)).BeginInit();
            this.tabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipiptServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.FixedTabSize = new System.Drawing.Size(200, 22);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(729, 431);
            this.tabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Tabs.Add(this.tabItem2);
            this.tabControl1.Text = "tabControl1";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.panelEx1);
            this.tabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 25);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(729, 406);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(147)))), ((int)(((byte)(160)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabItem1;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btnDetail);
            this.panelEx1.Controls.Add(this.txtServerPort);
            this.panelEx1.Controls.Add(this.lbSendStatus);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.ipiptServer);
            this.panelEx1.Controls.Add(this.txtAlarmType);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.labelX11);
            this.panelEx1.Controls.Add(this.labelX3);
            this.panelEx1.Controls.Add(this.btnSend);
            this.panelEx1.Controls.Add(this.btnSelect);
            this.panelEx1.Controls.Add(this.labelX4);
            this.panelEx1.Controls.Add(this.picImage);
            this.panelEx1.Controls.Add(this.txtHostIdent);
            this.panelEx1.Controls.Add(this.label1);
            this.panelEx1.Controls.Add(this.labelX5);
            this.panelEx1.Controls.Add(this.ipIptHost);
            this.panelEx1.Controls.Add(this.txtInterval);
            this.panelEx1.Controls.Add(this.labelX6);
            this.panelEx1.Controls.Add(this.labelX9);
            this.panelEx1.Controls.Add(this.txtChannel);
            this.panelEx1.Controls.Add(this.txtSendCnt);
            this.panelEx1.Controls.Add(this.labelX8);
            this.panelEx1.Controls.Add(this.labelX10);
            this.panelEx1.Controls.Add(this.txtPersonCnt);
            this.panelEx1.Controls.Add(this.txtDescription);
            this.panelEx1.Controls.Add(this.labelX7);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(1, 1);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(727, 404);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // btnDetail
            // 
            this.btnDetail.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetail.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDetail.Location = new System.Drawing.Point(638, 370);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(75, 23);
            this.btnDetail.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDetail.TabIndex = 21;
            this.btnDetail.Text = "详情";
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // lbSendStatus
            // 
            this.lbSendStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lbSendStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbSendStatus.Location = new System.Drawing.Point(462, 370);
            this.lbSendStatus.Name = "lbSendStatus";
            this.lbSendStatus.Size = new System.Drawing.Size(90, 23);
            this.lbSendStatus.TabIndex = 19;
            // 
            // txtAlarmType
            // 
            // 
            // 
            // 
            this.txtAlarmType.Border.Class = "TextBoxBorder";
            this.txtAlarmType.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAlarmType.Location = new System.Drawing.Point(86, 86);
            this.txtAlarmType.Name = "txtAlarmType";
            this.txtAlarmType.PreventEnterBeep = true;
            this.txtAlarmType.Size = new System.Drawing.Size(172, 21);
            this.superTooltip1.SetSuperTooltip(this.txtAlarmType, new DevComponents.DotNetBar.SuperTooltipInfo("事件检测类型", "<a href=\"TextBoxMoreInfo\">点击查看更多类型说明</a>", "102：异常人脸检测（含墨镜、口罩、帽子、头盔）\r\n103：打电话检测", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, false, false, new System.Drawing.Size(230, 60)));
            this.txtAlarmType.TabIndex = 1;
            this.txtAlarmType.Text = "102";
            // 
            // labelX11
            // 
            this.labelX11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(355, 370);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(90, 23);
            this.labelX11.TabIndex = 18;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(14, 85);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(66, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "事件类型：";
            // 
            // btnSend
            // 
            this.btnSend.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSend.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.Location = new System.Drawing.Point(557, 370);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSend.TabIndex = 20;
            this.btnSend.Text = "发送";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSelect.Location = new System.Drawing.Point(646, 16);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(71, 21);
            this.btnSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSelect.TabIndex = 17;
            this.btnSelect.Text = "选择图片";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(14, 121);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(66, 23);
            this.labelX4.TabIndex = 2;
            this.labelX4.Text = "设备标识：";
            // 
            // picImage
            // 
            this.picImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(346, 40);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(371, 319);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 17;
            this.picImage.TabStop = false;
            // 
            // txtHostIdent
            // 
            // 
            // 
            // 
            this.txtHostIdent.Border.Class = "TextBoxBorder";
            this.txtHostIdent.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHostIdent.Location = new System.Drawing.Point(86, 122);
            this.txtHostIdent.Name = "txtHostIdent";
            this.txtHostIdent.PreventEnterBeep = true;
            this.txtHostIdent.Size = new System.Drawing.Size(172, 21);
            this.superTooltip1.SetSuperTooltip(this.txtHostIdent, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "当设备不能获得固定IP地址时，用来唯一区分设备", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, false, false, new System.Drawing.Size(0, 0)));
            this.txtHostIdent.TabIndex = 3;
            this.txtHostIdent.Text = "SRZN01";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "事件图片：";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(14, 157);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(66, 23);
            this.labelX5.TabIndex = 4;
            this.labelX5.Text = "模拟设备：";
            // 
            // ipIptHost
            // 
            this.ipIptHost.AutoOverwrite = true;
            // 
            // 
            // 
            this.ipIptHost.BackgroundStyle.Class = "DateTimeInputBackground";
            this.ipIptHost.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ipIptHost.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.ipIptHost.ButtonFreeText.Visible = true;
            this.ipIptHost.Location = new System.Drawing.Point(86, 158);
            this.ipIptHost.Name = "ipIptHost";
            this.ipIptHost.Size = new System.Drawing.Size(172, 21);
            this.ipIptHost.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.ipIptHost, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "用于模拟发生报警的设备IP地址", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, false, false, new System.Drawing.Size(0, 0)));
            this.ipIptHost.TabIndex = 5;
            this.ipIptHost.Value = "192.168.2.2";
            // 
            // txtInterval
            // 
            // 
            // 
            // 
            this.txtInterval.Border.Class = "TextBoxBorder";
            this.txtInterval.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInterval.Location = new System.Drawing.Point(86, 338);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.PreventEnterBeep = true;
            this.txtInterval.Size = new System.Drawing.Size(172, 21);
            this.txtInterval.TabIndex = 15;
            this.txtInterval.Text = "500";
            this.superValidator1.SetValidator1(this.txtInterval, this.regularExpressionValidator5);
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(14, 193);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(66, 23);
            this.labelX6.TabIndex = 6;
            this.labelX6.Text = "通道编号：";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(14, 337);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(66, 23);
            this.labelX9.TabIndex = 14;
            this.labelX9.Text = "发送间隔：";
            // 
            // txtChannel
            // 
            // 
            // 
            // 
            this.txtChannel.Border.Class = "TextBoxBorder";
            this.txtChannel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtChannel.Location = new System.Drawing.Point(86, 194);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.PreventEnterBeep = true;
            this.txtChannel.Size = new System.Drawing.Size(172, 21);
            this.superTooltip1.SetSuperTooltip(this.txtChannel, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "模拟反生报警的设备对应的通道", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, false, false, new System.Drawing.Size(0, 0)));
            this.txtChannel.TabIndex = 7;
            this.txtChannel.Text = "1";
            this.superValidator1.SetValidator1(this.txtChannel, this.regularExpressionValidator2);
            // 
            // txtSendCnt
            // 
            // 
            // 
            // 
            this.txtSendCnt.Border.Class = "TextBoxBorder";
            this.txtSendCnt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSendCnt.Location = new System.Drawing.Point(86, 302);
            this.txtSendCnt.Name = "txtSendCnt";
            this.txtSendCnt.PreventEnterBeep = true;
            this.txtSendCnt.Size = new System.Drawing.Size(172, 21);
            this.txtSendCnt.TabIndex = 13;
            this.txtSendCnt.Text = "1";
            this.superValidator1.SetValidator1(this.txtSendCnt, this.regularExpressionValidator4);
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(14, 229);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(66, 23);
            this.labelX8.TabIndex = 8;
            this.labelX8.Text = "区域人数：";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(14, 301);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(66, 23);
            this.labelX10.TabIndex = 12;
            this.labelX10.Text = "发送数量：";
            // 
            // txtPersonCnt
            // 
            // 
            // 
            // 
            this.txtPersonCnt.Border.Class = "TextBoxBorder";
            this.txtPersonCnt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPersonCnt.Location = new System.Drawing.Point(86, 230);
            this.txtPersonCnt.Name = "txtPersonCnt";
            this.txtPersonCnt.PreventEnterBeep = true;
            this.txtPersonCnt.Size = new System.Drawing.Size(172, 21);
            this.superTooltip1.SetSuperTooltip(this.txtPersonCnt, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "指上述设备的对应通道画面中的人数", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, false, false, new System.Drawing.Size(0, 0)));
            this.txtPersonCnt.TabIndex = 9;
            this.txtPersonCnt.Text = "1";
            this.superValidator1.SetValidator1(this.txtPersonCnt, this.regularExpressionValidator3);
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.Border.Class = "TextBoxBorder";
            this.txtDescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDescription.Location = new System.Drawing.Point(86, 266);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PreventEnterBeep = true;
            this.txtDescription.Size = new System.Drawing.Size(172, 21);
            this.superTooltip1.SetSuperTooltip(this.txtDescription, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.System));
            this.txtDescription.TabIndex = 11;
            this.txtDescription.Text = "暂无描述";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(14, 265);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(66, 23);
            this.labelX7.TabIndex = 10;
            this.labelX7.Text = "事件描述：";
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "发送预警事件（模拟前端设备）";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.btnRegist1);
            this.tabControlPanel2.Controls.Add(this.textBoxX1);
            this.tabControlPanel2.Controls.Add(this.labelX12);
            this.tabControlPanel2.Controls.Add(this.listView1);
            this.tabControlPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 25);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(729, 406);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(147)))), ((int)(((byte)(160)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 5;
            this.tabControlPanel2.TabItem = this.tabItem2;
            // 
            // tabItem2
            // 
            this.tabItem2.AttachedControl = this.tabControlPanel2;
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = "接收预警事件（模拟接收客户端）";
            // 
            // btnRegist1
            // 
            this.btnRegist1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRegist1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRegist1.Location = new System.Drawing.Point(249, 7);
            this.btnRegist1.Name = "btnRegist1";
            this.btnRegist1.Size = new System.Drawing.Size(75, 23);
            this.btnRegist1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.btnRegist1, new DevComponents.DotNetBar.SuperTooltipInfo("说明：", "", "“登录” 必须在部署有完整系统的情况下使用，依赖数据库，消息队列，权限等。订阅事件和登录系统二选一即可。", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, true, false, new System.Drawing.Size(0, 0)));
            this.btnRegist1.TabIndex = 5;
            this.btnRegist1.Text = "开始接收";
            this.btnRegist1.Click += new System.EventHandler(this.btnRegist1_Click);
            // 
            // txtServerPort
            // 
            // 
            // 
            // 
            this.txtServerPort.Border.Class = "TextBoxBorder";
            this.txtServerPort.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtServerPort.Location = new System.Drawing.Point(84, 53);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.PreventEnterBeep = true;
            this.txtServerPort.Size = new System.Drawing.Size(172, 21);
            this.txtServerPort.TabIndex = 3;
            this.txtServerPort.Text = "8000";
            this.superValidator1.SetValidator1(this.txtServerPort, this.regularExpressionValidator6);
            // 
            // ipiptServer
            // 
            this.ipiptServer.AutoOverwrite = true;
            // 
            // 
            // 
            this.ipiptServer.BackgroundStyle.Class = "DateTimeInputBackground";
            this.ipiptServer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ipiptServer.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.ipiptServer.ButtonFreeText.Visible = true;
            this.ipiptServer.Location = new System.Drawing.Point(85, 20);
            this.ipiptServer.Name = "ipiptServer";
            this.ipiptServer.Size = new System.Drawing.Size(173, 21);
            this.ipiptServer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip1.SetSuperTooltip(this.ipiptServer, new DevComponents.DotNetBar.SuperTooltipInfo("", "", "接收报警信息并进行智能分析的服务器IP地址", null, null, DevComponents.DotNetBar.eTooltipColor.Yellow, false, false, new System.Drawing.Size(0, 0)));
            this.ipiptServer.TabIndex = 1;
            this.ipiptServer.Value = "192.168.1.166";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(2, 52);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(85, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "服务器端口：";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(4, 19);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(79, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "服务器地址：";
            // 
            // superTooltip1
            // 
            this.superTooltip1.DefaultTooltipSettings = new DevComponents.DotNetBar.SuperTooltipInfo("", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray);
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            this.superValidator1.ValidationType = DevComponents.DotNetBar.Validator.eValidationType.ValidatingEventPerControl;
            // 
            // regularExpressionValidator5
            // 
            this.regularExpressionValidator5.EmptyValueIsValid = true;
            this.regularExpressionValidator5.ErrorMessage = "Your error message here.";
            this.regularExpressionValidator5.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator5.ValidationExpression = "^\\+?[1-9][0-9]*$";
            // 
            // regularExpressionValidator2
            // 
            this.regularExpressionValidator2.EmptyValueIsValid = true;
            this.regularExpressionValidator2.ErrorMessage = "Your error message here.";
            this.regularExpressionValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator2.ValidationExpression = "^\\+?[0-9][0-9]*$";
            // 
            // regularExpressionValidator4
            // 
            this.regularExpressionValidator4.EmptyValueIsValid = true;
            this.regularExpressionValidator4.ErrorMessage = "Your error message here.";
            this.regularExpressionValidator4.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator4.ValidationExpression = "^\\+?[1-9][0-9]*$";
            // 
            // regularExpressionValidator3
            // 
            this.regularExpressionValidator3.EmptyValueIsValid = true;
            this.regularExpressionValidator3.ErrorMessage = "Your error message here.";
            this.regularExpressionValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator3.ValidationExpression = "^\\+?[1-9][0-9]*$";
            // 
            // regularExpressionValidator6
            // 
            this.regularExpressionValidator6.EmptyValueIsValid = true;
            this.regularExpressionValidator6.ErrorMessage = "Your error message here.";
            this.regularExpressionValidator6.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.regularExpressionValidator6.ValidationExpression = "^\\+?[1-9][0-9]*$";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Location = new System.Drawing.Point(6, 35);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(720, 363);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "时间";
            this.columnHeader1.Width = 164;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "报警设备";
            this.columnHeader2.Width = 129;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "通道";
            this.columnHeader3.Width = 119;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "报警类型";
            this.columnHeader4.Width = 129;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "事件ID";
            this.columnHeader5.Width = 161;
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Location = new System.Drawing.Point(158, 8);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(85, 21);
            this.textBoxX1.TabIndex = 5;
            this.textBoxX1.Text = "8000";
            this.superValidator1.SetValidator1(this.textBoxX1, this.regularExpressionValidator6);
            // 
            // labelX12
            // 
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(12, 7);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(140, 23);
            this.labelX12.TabIndex = 4;
            this.labelX12.Text = "本机接收报警端口：";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(729, 431);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "Form1";
            this.Text = "模拟程序";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Move += new System.EventHandler(this.Form1_Move);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipIptHost)).EndInit();
            this.tabControlPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipiptServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtServerPort;
        private DevComponents.Editors.IpAddressInput ipiptServer;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnSend;
        private DevComponents.DotNetBar.ButtonX btnSelect;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInterval;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSendCnt;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDescription;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPersonCnt;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtChannel;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.Editors.IpAddressInput ipIptHost;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHostIdent;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAlarmType;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX lbSendStatus;
        private DevComponents.DotNetBar.ButtonX btnRegist1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.SuperTooltip superTooltip1;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator2;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator4;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator3;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator5;
        private DevComponents.DotNetBar.Validator.RegularExpressionValidator regularExpressionValidator6;
        private DevComponents.DotNetBar.ButtonX btnDetail;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.LabelX labelX12;
    }
}