namespace UHFReader
{
    partial class Device_2
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
            this.cCommPort = new System.Windows.Forms.ComboBox();
            this.btnSetAccessPWD = new System.Windows.Forms.Button();
            this.bEpcInit = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tEpcAccess = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bRs232Discon = new System.Windows.Forms.Button();
            this.bRs232Con = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chkFilter = new System.Windows.Forms.CheckBox();
            this.bClear = new System.Windows.Forms.Button();
            this.lvTagList = new System.Windows.Forms.ListView();
            this.clhNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTagData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTimes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lInfo = new System.Windows.Forms.ListBox();
            this.tEpcKill = new System.Windows.Forms.TextBox();
            this.tEpcData = new System.Windows.Forms.TextBox();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.cEpcWordcnt = new System.Windows.Forms.ComboBox();
            this.cEpcWordptr = new System.Windows.Forms.ComboBox();
            this.cBaudrate = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cEpcMembank = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tEpcSpeed = new System.Windows.Forms.TrackBar();
            this.cEpcTimes = new System.Windows.Forms.ComboBox();
            this.bEpcKill = new System.Windows.Forms.Button();
            this.btnSecLock = new System.Windows.Forms.Button();
            this.btnSecWrite = new System.Windows.Forms.Button();
            this.bEpcWrite = new System.Windows.Forms.Button();
            this.btnSecRead = new System.Windows.Forms.Button();
            this.bEpcRead = new System.Windows.Forms.Button();
            this.bEpcId = new System.Windows.Forms.Button();
            this.btHome = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
            this.timerScanISO = new System.Windows.Forms.Timer(this.components);
            this.timerScanEPC = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.timerPing = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tEpcSpeed)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cCommPort
            // 
            this.cCommPort.FormattingEnabled = true;
            this.cCommPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17",
            "COM18",
            "COM19",
            "COM20"});
            this.cCommPort.Location = new System.Drawing.Point(164, 29);
            this.cCommPort.Margin = new System.Windows.Forms.Padding(4);
            this.cCommPort.Name = "cCommPort";
            this.cCommPort.Size = new System.Drawing.Size(115, 25);
            this.cCommPort.TabIndex = 2;
            // 
            // btnSetAccessPWD
            // 
            this.btnSetAccessPWD.BackColor = System.Drawing.Color.SlateGray;
            this.btnSetAccessPWD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetAccessPWD.ForeColor = System.Drawing.Color.Gold;
            this.btnSetAccessPWD.Location = new System.Drawing.Point(309, 295);
            this.btnSetAccessPWD.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetAccessPWD.Name = "btnSetAccessPWD";
            this.btnSetAccessPWD.Size = new System.Drawing.Size(160, 39);
            this.btnSetAccessPWD.TabIndex = 29;
            this.btnSetAccessPWD.Text = "Set Password";
            this.btnSetAccessPWD.UseVisualStyleBackColor = false;
            this.btnSetAccessPWD.Click += new System.EventHandler(this.btnSetAccessPWD_Click);
            // 
            // bEpcInit
            // 
            this.bEpcInit.BackColor = System.Drawing.Color.SlateGray;
            this.bEpcInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bEpcInit.ForeColor = System.Drawing.Color.Gold;
            this.bEpcInit.Location = new System.Drawing.Point(333, 208);
            this.bEpcInit.Margin = new System.Windows.Forms.Padding(4);
            this.bEpcInit.Name = "bEpcInit";
            this.bEpcInit.Size = new System.Drawing.Size(120, 35);
            this.bEpcInit.TabIndex = 29;
            this.bEpcInit.Text = "Init";
            this.bEpcInit.UseVisualStyleBackColor = false;
            this.bEpcInit.Click += new System.EventHandler(this.bEpcInit_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(13, 445);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(139, 20);
            this.label19.TabIndex = 28;
            this.label19.Text = "Kill Password";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(11, 397);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(149, 20);
            this.label20.TabIndex = 27;
            this.label20.Text = "Password Level";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(11, 349);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(159, 20);
            this.label18.TabIndex = 27;
            this.label18.Text = "Access Password";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(13, 295);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 20);
            this.label17.TabIndex = 26;
            this.label17.Text = "Data(Hex)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(11, 167);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 20);
            this.label16.TabIndex = 25;
            this.label16.Text = "MemBank";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(13, 260);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 20);
            this.label15.TabIndex = 24;
            this.label15.Text = "WordCnt";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(11, 213);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 20);
            this.label14.TabIndex = 22;
            this.label14.Text = "WordPtr";
            // 
            // tEpcAccess
            // 
            this.tEpcAccess.Location = new System.Drawing.Point(185, 348);
            this.tEpcAccess.Margin = new System.Windows.Forms.Padding(4);
            this.tEpcAccess.MaxLength = 8;
            this.tEpcAccess.Name = "tEpcAccess";
            this.tEpcAccess.Size = new System.Drawing.Size(115, 30);
            this.tEpcAccess.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "BAUDRATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "COMM PORT";
            // 
            // bRs232Discon
            // 
            this.bRs232Discon.BackColor = System.Drawing.Color.SlateGray;
            this.bRs232Discon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bRs232Discon.ForeColor = System.Drawing.Color.Gold;
            this.bRs232Discon.Location = new System.Drawing.Point(177, 107);
            this.bRs232Discon.Margin = new System.Windows.Forms.Padding(4);
            this.bRs232Discon.Name = "bRs232Discon";
            this.bRs232Discon.Size = new System.Drawing.Size(103, 39);
            this.bRs232Discon.TabIndex = 5;
            this.bRs232Discon.Text = "Discon";
            this.bRs232Discon.UseVisualStyleBackColor = false;
            this.bRs232Discon.Click += new System.EventHandler(this.bRs232Discon_Click);
            // 
            // bRs232Con
            // 
            this.bRs232Con.BackColor = System.Drawing.Color.SlateGray;
            this.bRs232Con.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bRs232Con.ForeColor = System.Drawing.Color.Gold;
            this.bRs232Con.Location = new System.Drawing.Point(47, 107);
            this.bRs232Con.Margin = new System.Windows.Forms.Padding(4);
            this.bRs232Con.Name = "bRs232Con";
            this.bRs232Con.Size = new System.Drawing.Size(103, 39);
            this.bRs232Con.TabIndex = 4;
            this.bRs232Con.Text = "Connect";
            this.bRs232Con.UseVisualStyleBackColor = false;
            this.bRs232Con.Click += new System.EventHandler(this.bRs232Con_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chkFilter);
            this.groupBox7.Controls.Add(this.bClear);
            this.groupBox7.Controls.Add(this.lvTagList);
            this.groupBox7.Controls.Add(this.lInfo);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox7.Location = new System.Drawing.Point(859, -23);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(507, 683);
            this.groupBox7.TabIndex = 34;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Opration Info.";
            // 
            // chkFilter
            // 
            this.chkFilter.AutoSize = true;
            this.chkFilter.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkFilter.ForeColor = System.Drawing.Color.Yellow;
            this.chkFilter.Location = new System.Drawing.Point(19, 626);
            this.chkFilter.Margin = new System.Windows.Forms.Padding(4);
            this.chkFilter.Name = "chkFilter";
            this.chkFilter.Size = new System.Drawing.Size(152, 24);
            this.chkFilter.TabIndex = 9;
            this.chkFilter.Text = "Filter Same";
            this.chkFilter.UseVisualStyleBackColor = true;
            // 
            // bClear
            // 
            this.bClear.BackColor = System.Drawing.Color.SlateGray;
            this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bClear.ForeColor = System.Drawing.Color.Gold;
            this.bClear.Location = new System.Drawing.Point(287, 608);
            this.bClear.Margin = new System.Windows.Forms.Padding(4);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(209, 49);
            this.bClear.TabIndex = 11;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = false;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // lvTagList
            // 
            this.lvTagList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhNo,
            this.clhTagData,
            this.clhTimes});
            this.lvTagList.HideSelection = false;
            this.lvTagList.Location = new System.Drawing.Point(8, 420);
            this.lvTagList.Margin = new System.Windows.Forms.Padding(4);
            this.lvTagList.Name = "lvTagList";
            this.lvTagList.Size = new System.Drawing.Size(488, 172);
            this.lvTagList.TabIndex = 14;
            this.lvTagList.UseCompatibleStateImageBehavior = false;
            this.lvTagList.View = System.Windows.Forms.View.Details;
            // 
            // clhNo
            // 
            this.clhNo.Text = "NO.";
            this.clhNo.Width = 40;
            // 
            // clhTagData
            // 
            this.clhTagData.Text = "Tag Data";
            this.clhTagData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhTagData.Width = 240;
            // 
            // clhTimes
            // 
            this.clhTimes.Text = "Times";
            this.clhTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhTimes.Width = 50;
            // 
            // lInfo
            // 
            this.lInfo.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lInfo.FormattingEnabled = true;
            this.lInfo.HorizontalScrollbar = true;
            this.lInfo.ItemHeight = 15;
            this.lInfo.Location = new System.Drawing.Point(8, 31);
            this.lInfo.Margin = new System.Windows.Forms.Padding(4);
            this.lInfo.Name = "lInfo";
            this.lInfo.ScrollAlwaysVisible = true;
            this.lInfo.Size = new System.Drawing.Size(488, 379);
            this.lInfo.TabIndex = 0;
            // 
            // tEpcKill
            // 
            this.tEpcKill.Location = new System.Drawing.Point(185, 444);
            this.tEpcKill.Margin = new System.Windows.Forms.Padding(4);
            this.tEpcKill.Name = "tEpcKill";
            this.tEpcKill.Size = new System.Drawing.Size(115, 30);
            this.tEpcKill.TabIndex = 22;
            // 
            // tEpcData
            // 
            this.tEpcData.Location = new System.Drawing.Point(129, 295);
            this.tEpcData.Margin = new System.Windows.Forms.Padding(4);
            this.tEpcData.Name = "tEpcData";
            this.tEpcData.Size = new System.Drawing.Size(165, 30);
            this.tEpcData.TabIndex = 21;
            this.tEpcData.TextChanged += new System.EventHandler(this.tEpcData_TextChanged);
            // 
            // cmbLevel
            // 
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Items.AddRange(new object[] {
            "00",
            "01",
            "10",
            "11"});
            this.cmbLevel.Location = new System.Drawing.Point(185, 396);
            this.cmbLevel.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(115, 28);
            this.cmbLevel.TabIndex = 20;
            // 
            // cEpcWordcnt
            // 
            this.cEpcWordcnt.FormattingEnabled = true;
            this.cEpcWordcnt.Location = new System.Drawing.Point(129, 255);
            this.cEpcWordcnt.Margin = new System.Windows.Forms.Padding(4);
            this.cEpcWordcnt.Name = "cEpcWordcnt";
            this.cEpcWordcnt.Size = new System.Drawing.Size(115, 28);
            this.cEpcWordcnt.TabIndex = 20;
            // 
            // cEpcWordptr
            // 
            this.cEpcWordptr.FormattingEnabled = true;
            this.cEpcWordptr.Location = new System.Drawing.Point(129, 209);
            this.cEpcWordptr.Margin = new System.Windows.Forms.Padding(4);
            this.cEpcWordptr.Name = "cEpcWordptr";
            this.cEpcWordptr.Size = new System.Drawing.Size(115, 28);
            this.cEpcWordptr.TabIndex = 19;
            // 
            // cBaudrate
            // 
            this.cBaudrate.FormattingEnabled = true;
            this.cBaudrate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cBaudrate.Location = new System.Drawing.Point(164, 68);
            this.cBaudrate.Margin = new System.Windows.Forms.Padding(4);
            this.cBaudrate.Name = "cBaudrate";
            this.cBaudrate.Size = new System.Drawing.Size(115, 25);
            this.cBaudrate.TabIndex = 3;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnSetAccessPWD);
            this.groupBox6.Controls.Add(this.bEpcInit);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.tEpcAccess);
            this.groupBox6.Controls.Add(this.tEpcKill);
            this.groupBox6.Controls.Add(this.tEpcData);
            this.groupBox6.Controls.Add(this.cmbLevel);
            this.groupBox6.Controls.Add(this.cEpcWordcnt);
            this.groupBox6.Controls.Add(this.cEpcWordptr);
            this.groupBox6.Controls.Add(this.cEpcMembank);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.tEpcSpeed);
            this.groupBox6.Controls.Add(this.cEpcTimes);
            this.groupBox6.Controls.Add(this.bEpcKill);
            this.groupBox6.Controls.Add(this.btnSecLock);
            this.groupBox6.Controls.Add(this.btnSecWrite);
            this.groupBox6.Controls.Add(this.bEpcWrite);
            this.groupBox6.Controls.Add(this.btnSecRead);
            this.groupBox6.Controls.Add(this.bEpcRead);
            this.groupBox6.Controls.Add(this.bEpcId);
            this.groupBox6.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox6.Location = new System.Drawing.Point(361, 6);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(477, 497);
            this.groupBox6.TabIndex = 33;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ISO18000-6C(EPC G2)";
            // 
            // cEpcMembank
            // 
            this.cEpcMembank.FormattingEnabled = true;
            this.cEpcMembank.Items.AddRange(new object[] {
            "RESERVE",
            "EPC",
            "TID",
            "USER"});
            this.cEpcMembank.Location = new System.Drawing.Point(129, 167);
            this.cEpcMembank.Margin = new System.Windows.Forms.Padding(4);
            this.cEpcMembank.Name = "cEpcMembank";
            this.cEpcMembank.Size = new System.Drawing.Size(115, 28);
            this.cEpcMembank.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(24, 117);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Times";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(21, 56);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Speed";
            // 
            // tEpcSpeed
            // 
            this.tEpcSpeed.Location = new System.Drawing.Point(95, 53);
            this.tEpcSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.tEpcSpeed.Name = "tEpcSpeed";
            this.tEpcSpeed.Size = new System.Drawing.Size(207, 56);
            this.tEpcSpeed.TabIndex = 15;
            // 
            // cEpcTimes
            // 
            this.cEpcTimes.FormattingEnabled = true;
            this.cEpcTimes.Items.AddRange(new object[] {
            "Continours",
            "1",
            "10",
            "100",
            "1000",
            "5000"});
            this.cEpcTimes.Location = new System.Drawing.Point(129, 115);
            this.cEpcTimes.Margin = new System.Windows.Forms.Padding(4);
            this.cEpcTimes.Name = "cEpcTimes";
            this.cEpcTimes.Size = new System.Drawing.Size(115, 28);
            this.cEpcTimes.TabIndex = 14;
            // 
            // bEpcKill
            // 
            this.bEpcKill.BackColor = System.Drawing.Color.SlateGray;
            this.bEpcKill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bEpcKill.ForeColor = System.Drawing.Color.Gold;
            this.bEpcKill.Location = new System.Drawing.Point(333, 251);
            this.bEpcKill.Margin = new System.Windows.Forms.Padding(4);
            this.bEpcKill.Name = "bEpcKill";
            this.bEpcKill.Size = new System.Drawing.Size(120, 35);
            this.bEpcKill.TabIndex = 9;
            this.bEpcKill.Text = "Kill";
            this.bEpcKill.UseVisualStyleBackColor = false;
            this.bEpcKill.Click += new System.EventHandler(this.bEpcKill_Click);
            // 
            // btnSecLock
            // 
            this.btnSecLock.BackColor = System.Drawing.Color.SlateGray;
            this.btnSecLock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSecLock.ForeColor = System.Drawing.Color.Gold;
            this.btnSecLock.Location = new System.Drawing.Point(333, 444);
            this.btnSecLock.Margin = new System.Windows.Forms.Padding(4);
            this.btnSecLock.Name = "btnSecLock";
            this.btnSecLock.Size = new System.Drawing.Size(120, 35);
            this.btnSecLock.TabIndex = 8;
            this.btnSecLock.Text = "Sec Lock";
            this.btnSecLock.UseVisualStyleBackColor = false;
            this.btnSecLock.Click += new System.EventHandler(this.btnSecLock_Click);
            // 
            // btnSecWrite
            // 
            this.btnSecWrite.BackColor = System.Drawing.Color.SlateGray;
            this.btnSecWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSecWrite.ForeColor = System.Drawing.Color.Gold;
            this.btnSecWrite.Location = new System.Drawing.Point(333, 393);
            this.btnSecWrite.Margin = new System.Windows.Forms.Padding(4);
            this.btnSecWrite.Name = "btnSecWrite";
            this.btnSecWrite.Size = new System.Drawing.Size(120, 35);
            this.btnSecWrite.TabIndex = 7;
            this.btnSecWrite.Text = "Sec Write";
            this.btnSecWrite.UseVisualStyleBackColor = false;
            this.btnSecWrite.Click += new System.EventHandler(this.btnSecWrite_Click);
            // 
            // bEpcWrite
            // 
            this.bEpcWrite.BackColor = System.Drawing.Color.SlateGray;
            this.bEpcWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bEpcWrite.ForeColor = System.Drawing.Color.Gold;
            this.bEpcWrite.Location = new System.Drawing.Point(333, 165);
            this.bEpcWrite.Margin = new System.Windows.Forms.Padding(4);
            this.bEpcWrite.Name = "bEpcWrite";
            this.bEpcWrite.Size = new System.Drawing.Size(120, 35);
            this.bEpcWrite.TabIndex = 7;
            this.bEpcWrite.Text = "Write";
            this.bEpcWrite.UseVisualStyleBackColor = false;
            this.bEpcWrite.Click += new System.EventHandler(this.bEpcWrite_Click);
            // 
            // btnSecRead
            // 
            this.btnSecRead.BackColor = System.Drawing.Color.SlateGray;
            this.btnSecRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSecRead.ForeColor = System.Drawing.Color.Gold;
            this.btnSecRead.Location = new System.Drawing.Point(333, 345);
            this.btnSecRead.Margin = new System.Windows.Forms.Padding(4);
            this.btnSecRead.Name = "btnSecRead";
            this.btnSecRead.Size = new System.Drawing.Size(120, 35);
            this.btnSecRead.TabIndex = 6;
            this.btnSecRead.Text = "Sec Read";
            this.btnSecRead.UseVisualStyleBackColor = false;
            this.btnSecRead.Click += new System.EventHandler(this.btnSecRead_Click);
            // 
            // bEpcRead
            // 
            this.bEpcRead.BackColor = System.Drawing.Color.SlateGray;
            this.bEpcRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bEpcRead.ForeColor = System.Drawing.Color.Gold;
            this.bEpcRead.Location = new System.Drawing.Point(333, 117);
            this.bEpcRead.Margin = new System.Windows.Forms.Padding(4);
            this.bEpcRead.Name = "bEpcRead";
            this.bEpcRead.Size = new System.Drawing.Size(120, 35);
            this.bEpcRead.TabIndex = 6;
            this.bEpcRead.Text = "Read";
            this.bEpcRead.UseVisualStyleBackColor = false;
            this.bEpcRead.Click += new System.EventHandler(this.bEpcRead_Click);
            // 
            // bEpcId
            // 
            this.bEpcId.BackColor = System.Drawing.Color.SlateGray;
            this.bEpcId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bEpcId.ForeColor = System.Drawing.Color.Gold;
            this.bEpcId.Location = new System.Drawing.Point(333, 33);
            this.bEpcId.Margin = new System.Windows.Forms.Padding(4);
            this.bEpcId.Name = "bEpcId";
            this.bEpcId.Size = new System.Drawing.Size(120, 68);
            this.bEpcId.TabIndex = 5;
            this.bEpcId.Text = "Identify";
            this.bEpcId.UseVisualStyleBackColor = false;
            this.bEpcId.Click += new System.EventHandler(this.bEpcId_Click);
            // 
            // btHome
            // 
            this.btHome.BackColor = System.Drawing.Color.SlateGray;
            this.btHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btHome.ForeColor = System.Drawing.Color.Gold;
            this.btHome.Location = new System.Drawing.Point(692, 505);
            this.btHome.Margin = new System.Windows.Forms.Padding(4);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(147, 57);
            this.btHome.TabIndex = 37;
            this.btHome.Text = "Home";
            this.btHome.UseVisualStyleBackColor = false;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // bReset
            // 
            this.bReset.BackColor = System.Drawing.Color.SlateGray;
            this.bReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bReset.ForeColor = System.Drawing.Color.Gold;
            this.bReset.Location = new System.Drawing.Point(358, 505);
            this.bReset.Margin = new System.Windows.Forms.Padding(4);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(164, 57);
            this.bReset.TabIndex = 36;
            this.bReset.Text = "Reset Reader";
            this.bReset.UseVisualStyleBackColor = false;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // timerScanISO
            // 
            this.timerScanISO.Tick += new System.EventHandler(this.timerScanISO_Tick);
            // 
            // timerScanEPC
            // 
            this.timerScanEPC.Tick += new System.EventHandler(this.timerScanEPC_Tick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SlateGray;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.ForeColor = System.Drawing.Color.Gold;
            this.btnExit.Location = new System.Drawing.Point(537, 505);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 57);
            this.btnExit.TabIndex = 35;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timerPing
            // 
            this.timerPing.Interval = 3000;
            this.timerPing.Tick += new System.EventHandler(this.timerPing_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bRs232Discon);
            this.groupBox1.Controls.Add(this.bRs232Con);
            this.groupBox1.Controls.Add(this.cBaudrate);
            this.groupBox1.Controls.Add(this.cCommPort);
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Location = new System.Drawing.Point(16, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(316, 153);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RS232";
            // 
            // Device_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1379, 637);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btHome);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Name = "Device_2";
            this.Text = "Device_2";
            this.Load += new System.EventHandler(this.Device_2_Load);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tEpcSpeed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cCommPort;
        private System.Windows.Forms.Button btnSetAccessPWD;
        private System.Windows.Forms.Button bEpcInit;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tEpcAccess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bRs232Discon;
        private System.Windows.Forms.Button bRs232Con;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox chkFilter;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.ListView lvTagList;
        private System.Windows.Forms.ColumnHeader clhNo;
        private System.Windows.Forms.ColumnHeader clhTagData;
        private System.Windows.Forms.ColumnHeader clhTimes;
        private System.Windows.Forms.ListBox lInfo;
        private System.Windows.Forms.TextBox tEpcKill;
        private System.Windows.Forms.TextBox tEpcData;
        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.ComboBox cEpcWordcnt;
        private System.Windows.Forms.ComboBox cEpcWordptr;
        private System.Windows.Forms.ComboBox cBaudrate;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cEpcMembank;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar tEpcSpeed;
        private System.Windows.Forms.ComboBox cEpcTimes;
        private System.Windows.Forms.Button bEpcKill;
        private System.Windows.Forms.Button btnSecLock;
        private System.Windows.Forms.Button btnSecWrite;
        private System.Windows.Forms.Button bEpcWrite;
        private System.Windows.Forms.Button btnSecRead;
        private System.Windows.Forms.Button bEpcRead;
        private System.Windows.Forms.Button bEpcId;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Timer timerScanISO;
        private System.Windows.Forms.Timer timerScanEPC;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timerPing;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}