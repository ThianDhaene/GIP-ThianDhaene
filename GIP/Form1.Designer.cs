namespace GIP
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
            this.lstConsole = new System.Windows.Forms.ListBox();
            this.pnlConnect = new System.Windows.Forms.Panel();
            this.lstPoort = new System.Windows.Forms.ListBox();
            this.serial = new System.IO.Ports.SerialPort(this.components);
            this.pnlBesturing = new System.Windows.Forms.Panel();
            this.pnlParkingEnStatus = new System.Windows.Forms.Panel();
            this.p14 = new System.Windows.Forms.Label();
            this.p20 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.Label();
            this.p26 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Label();
            this.p25 = new System.Windows.Forms.Label();
            this.p3 = new System.Windows.Forms.Label();
            this.p24 = new System.Windows.Forms.Label();
            this.p4 = new System.Windows.Forms.Label();
            this.p23 = new System.Windows.Forms.Label();
            this.p5 = new System.Windows.Forms.Label();
            this.p22 = new System.Windows.Forms.Label();
            this.p6 = new System.Windows.Forms.Label();
            this.p21 = new System.Windows.Forms.Label();
            this.p7 = new System.Windows.Forms.Label();
            this.p8 = new System.Windows.Forms.Label();
            this.p19 = new System.Windows.Forms.Label();
            this.p9 = new System.Windows.Forms.Label();
            this.p18 = new System.Windows.Forms.Label();
            this.p10 = new System.Windows.Forms.Label();
            this.p17 = new System.Windows.Forms.Label();
            this.p11 = new System.Windows.Forms.Label();
            this.p16 = new System.Windows.Forms.Label();
            this.p12 = new System.Windows.Forms.Label();
            this.p15 = new System.Windows.Forms.Label();
            this.p13 = new System.Windows.Forms.Label();
            this.pbParking = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.slagbomenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slagboom1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normaleWerkingSlagboom1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altijdGeslotenSlagboom1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altijdOpenSlagboom1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slagboom2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normaleWerkingSlagboom2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altijdGeslotenSlagboom2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altijdOpenSlagboom2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsWeergevenNummer = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsConnectie = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLayout3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsProgressbar = new System.Windows.Forms.ToolStripProgressBar();
            this.tsBeschikbaar = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLayout2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSlagboom1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLayout1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSlagboom2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsLogBoekLocatie = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlConnect.SuspendLayout();
            this.pnlBesturing.SuspendLayout();
            this.pnlParkingEnStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbParking)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstConsole
            // 
            this.lstConsole.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstConsole.FormattingEnabled = true;
            this.lstConsole.ItemHeight = 16;
            this.lstConsole.Location = new System.Drawing.Point(120, 0);
            this.lstConsole.Name = "lstConsole";
            this.lstConsole.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstConsole.Size = new System.Drawing.Size(490, 160);
            this.lstConsole.TabIndex = 0;
            // 
            // pnlConnect
            // 
            this.pnlConnect.Controls.Add(this.lstConsole);
            this.pnlConnect.Controls.Add(this.lstPoort);
            this.pnlConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConnect.Location = new System.Drawing.Point(3, 2);
            this.pnlConnect.MinimumSize = new System.Drawing.Size(0, 40);
            this.pnlConnect.Name = "pnlConnect";
            this.pnlConnect.Size = new System.Drawing.Size(1888, 160);
            this.pnlConnect.TabIndex = 1;
            // 
            // lstPoort
            // 
            this.lstPoort.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstPoort.FormattingEnabled = true;
            this.lstPoort.ItemHeight = 16;
            this.lstPoort.Location = new System.Drawing.Point(0, 0);
            this.lstPoort.Name = "lstPoort";
            this.lstPoort.Size = new System.Drawing.Size(120, 160);
            this.lstPoort.TabIndex = 0;
            this.lstPoort.SelectedIndexChanged += new System.EventHandler(this.lstPoort_SelectedIndexChanged);
            // 
            // serial
            // 
            this.serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serial_DataReceived);
            // 
            // pnlBesturing
            // 
            this.pnlBesturing.Controls.Add(this.pnlParkingEnStatus);
            this.pnlBesturing.Controls.Add(this.menuStrip2);
            this.pnlBesturing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBesturing.Location = new System.Drawing.Point(3, 2);
            this.pnlBesturing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBesturing.Name = "pnlBesturing";
            this.pnlBesturing.Size = new System.Drawing.Size(1888, 938);
            this.pnlBesturing.TabIndex = 2;
            // 
            // pnlParkingEnStatus
            // 
            this.pnlParkingEnStatus.Controls.Add(this.p14);
            this.pnlParkingEnStatus.Controls.Add(this.p20);
            this.pnlParkingEnStatus.Controls.Add(this.p1);
            this.pnlParkingEnStatus.Controls.Add(this.p26);
            this.pnlParkingEnStatus.Controls.Add(this.p2);
            this.pnlParkingEnStatus.Controls.Add(this.p25);
            this.pnlParkingEnStatus.Controls.Add(this.p3);
            this.pnlParkingEnStatus.Controls.Add(this.p24);
            this.pnlParkingEnStatus.Controls.Add(this.p4);
            this.pnlParkingEnStatus.Controls.Add(this.p23);
            this.pnlParkingEnStatus.Controls.Add(this.p5);
            this.pnlParkingEnStatus.Controls.Add(this.p22);
            this.pnlParkingEnStatus.Controls.Add(this.p6);
            this.pnlParkingEnStatus.Controls.Add(this.p21);
            this.pnlParkingEnStatus.Controls.Add(this.p7);
            this.pnlParkingEnStatus.Controls.Add(this.p8);
            this.pnlParkingEnStatus.Controls.Add(this.p19);
            this.pnlParkingEnStatus.Controls.Add(this.p9);
            this.pnlParkingEnStatus.Controls.Add(this.p18);
            this.pnlParkingEnStatus.Controls.Add(this.p10);
            this.pnlParkingEnStatus.Controls.Add(this.p17);
            this.pnlParkingEnStatus.Controls.Add(this.p11);
            this.pnlParkingEnStatus.Controls.Add(this.p16);
            this.pnlParkingEnStatus.Controls.Add(this.p12);
            this.pnlParkingEnStatus.Controls.Add(this.p15);
            this.pnlParkingEnStatus.Controls.Add(this.p13);
            this.pnlParkingEnStatus.Controls.Add(this.pbParking);
            this.pnlParkingEnStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlParkingEnStatus.Location = new System.Drawing.Point(0, 30);
            this.pnlParkingEnStatus.Name = "pnlParkingEnStatus";
            this.pnlParkingEnStatus.Size = new System.Drawing.Size(1888, 908);
            this.pnlParkingEnStatus.TabIndex = 28;
            // 
            // p14
            // 
            this.p14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p14.AutoSize = true;
            this.p14.BackColor = System.Drawing.Color.Green;
            this.p14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p14.Location = new System.Drawing.Point(1155, 263);
            this.p14.Name = "p14";
            this.p14.Size = new System.Drawing.Size(21, 18);
            this.p14.TabIndex = 27;
            this.p14.Text = "‏‏‎ ‎‏‏‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎";
            // 
            // p20
            // 
            this.p20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p20.AutoSize = true;
            this.p20.BackColor = System.Drawing.Color.Green;
            this.p20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p20.Location = new System.Drawing.Point(1155, 779);
            this.p20.Name = "p20";
            this.p20.Size = new System.Drawing.Size(21, 18);
            this.p20.TabIndex = 20;
            this.p20.Text = "‏‏‎ ‎‏‏‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎";
            // 
            // p1
            // 
            this.p1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p1.AutoSize = true;
            this.p1.BackColor = System.Drawing.Color.Green;
            this.p1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p1.Location = new System.Drawing.Point(586, 207);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(21, 18);
            this.p1.TabIndex = 2;
            this.p1.Text = "‏‏‎ ‎‏‏‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎";
            // 
            // p26
            // 
            this.p26.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p26.AutoSize = true;
            this.p26.BackColor = System.Drawing.Color.Green;
            this.p26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p26.Location = new System.Drawing.Point(1297, 693);
            this.p26.Name = "p26";
            this.p26.Size = new System.Drawing.Size(21, 18);
            this.p26.TabIndex = 26;
            this.p26.Text = "‏‏‎ ‎‏‏‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎";
            // 
            // p2
            // 
            this.p2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p2.AutoSize = true;
            this.p2.BackColor = System.Drawing.Color.Green;
            this.p2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p2.Location = new System.Drawing.Point(586, 289);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(21, 18);
            this.p2.TabIndex = 3;
            this.p2.Text = "‏‏‎ ‎‏‏‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎";
            // 
            // p25
            // 
            this.p25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p25.AutoSize = true;
            this.p25.BackColor = System.Drawing.Color.Green;
            this.p25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p25.Location = new System.Drawing.Point(1297, 603);
            this.p25.Name = "p25";
            this.p25.Size = new System.Drawing.Size(21, 18);
            this.p25.TabIndex = 25;
            this.p25.Text = "‏‏‎ ‎‏‏‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎";
            // 
            // p3
            // 
            this.p3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p3.AutoSize = true;
            this.p3.BackColor = System.Drawing.Color.Green;
            this.p3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p3.Location = new System.Drawing.Point(586, 377);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(21, 18);
            this.p3.TabIndex = 4;
            this.p3.Text = "‏‏‎ ‎‏‏‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎";
            // 
            // p24
            // 
            this.p24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p24.AutoSize = true;
            this.p24.BackColor = System.Drawing.Color.Green;
            this.p24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p24.Location = new System.Drawing.Point(1297, 518);
            this.p24.Name = "p24";
            this.p24.Size = new System.Drawing.Size(21, 18);
            this.p24.TabIndex = 24;
            this.p24.Text = "‏‏‎ ‎‏‏‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎";
            // 
            // p4
            // 
            this.p4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p4.AutoSize = true;
            this.p4.BackColor = System.Drawing.Color.Green;
            this.p4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p4.Location = new System.Drawing.Point(586, 462);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(21, 18);
            this.p4.TabIndex = 5;
            this.p4.Text = "‏‏‎ ‎‏‏‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎";
            // 
            // p23
            // 
            this.p23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p23.AutoSize = true;
            this.p23.BackColor = System.Drawing.Color.Green;
            this.p23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p23.Location = new System.Drawing.Point(1297, 430);
            this.p23.Name = "p23";
            this.p23.Size = new System.Drawing.Size(21, 18);
            this.p23.TabIndex = 23;
            this.p23.Text = "‏‏‎ ‎‏‏‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎";
            // 
            // p5
            // 
            this.p5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p5.AutoSize = true;
            this.p5.BackColor = System.Drawing.Color.Green;
            this.p5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p5.Location = new System.Drawing.Point(586, 552);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(21, 18);
            this.p5.TabIndex = 6;
            this.p5.Text = "‏‏‎ ‎‏‏‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎";
            // 
            // p22
            // 
            this.p22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p22.AutoSize = true;
            this.p22.BackColor = System.Drawing.Color.Green;
            this.p22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p22.Location = new System.Drawing.Point(1297, 348);
            this.p22.Name = "p22";
            this.p22.Size = new System.Drawing.Size(21, 18);
            this.p22.TabIndex = 22;
            this.p22.Text = "‏‏‎ ‎‏‏‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎";
            // 
            // p6
            // 
            this.p6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p6.AutoSize = true;
            this.p6.BackColor = System.Drawing.Color.Green;
            this.p6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p6.Location = new System.Drawing.Point(586, 636);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(21, 18);
            this.p6.TabIndex = 7;
            this.p6.Text = "‏‏‎ ‎‏‏‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎";
            // 
            // p21
            // 
            this.p21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p21.AutoSize = true;
            this.p21.BackColor = System.Drawing.Color.Green;
            this.p21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p21.Location = new System.Drawing.Point(1297, 263);
            this.p21.Name = "p21";
            this.p21.Size = new System.Drawing.Size(21, 18);
            this.p21.TabIndex = 21;
            this.p21.Text = "‏‏‎ ‎‏‏‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎";
            // 
            // p7
            // 
            this.p7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p7.AutoSize = true;
            this.p7.BackColor = System.Drawing.Color.Green;
            this.p7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p7.Location = new System.Drawing.Point(729, 122);
            this.p7.Name = "p7";
            this.p7.Size = new System.Drawing.Size(21, 18);
            this.p7.TabIndex = 8;
            this.p7.Text = "‏‏‎ ‎‏‏‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎";
            // 
            // p8
            // 
            this.p8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p8.AutoSize = true;
            this.p8.BackColor = System.Drawing.Color.Green;
            this.p8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p8.Location = new System.Drawing.Point(729, 207);
            this.p8.Name = "p8";
            this.p8.Size = new System.Drawing.Size(21, 18);
            this.p8.TabIndex = 9;
            this.p8.Text = "‏‏‎ ‎‏‏‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎";
            // 
            // p19
            // 
            this.p19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p19.AutoSize = true;
            this.p19.BackColor = System.Drawing.Color.Green;
            this.p19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p19.Location = new System.Drawing.Point(1155, 693);
            this.p19.Name = "p19";
            this.p19.Size = new System.Drawing.Size(21, 18);
            this.p19.TabIndex = 19;
            this.p19.Text = "‏‏‎ ‎‏‏‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎";
            // 
            // p9
            // 
            this.p9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p9.AutoSize = true;
            this.p9.BackColor = System.Drawing.Color.Green;
            this.p9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p9.Location = new System.Drawing.Point(729, 289);
            this.p9.Name = "p9";
            this.p9.Size = new System.Drawing.Size(21, 18);
            this.p9.TabIndex = 10;
            this.p9.Text = "‏‏‎ ‎‏‏‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎";
            // 
            // p18
            // 
            this.p18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p18.AutoSize = true;
            this.p18.BackColor = System.Drawing.Color.Green;
            this.p18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p18.Location = new System.Drawing.Point(1155, 603);
            this.p18.Name = "p18";
            this.p18.Size = new System.Drawing.Size(21, 18);
            this.p18.TabIndex = 18;
            this.p18.Text = "‏‏‎ ‎‏‏‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎";
            // 
            // p10
            // 
            this.p10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p10.AutoSize = true;
            this.p10.BackColor = System.Drawing.Color.Green;
            this.p10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p10.Location = new System.Drawing.Point(729, 377);
            this.p10.Name = "p10";
            this.p10.Size = new System.Drawing.Size(21, 18);
            this.p10.TabIndex = 11;
            this.p10.Text = "‏‏‎ ‎‏‏‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎";
            // 
            // p17
            // 
            this.p17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p17.AutoSize = true;
            this.p17.BackColor = System.Drawing.Color.Green;
            this.p17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p17.Location = new System.Drawing.Point(1155, 518);
            this.p17.Name = "p17";
            this.p17.Size = new System.Drawing.Size(21, 18);
            this.p17.TabIndex = 17;
            this.p17.Text = "‏‏‎ ‎‏‏‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎";
            // 
            // p11
            // 
            this.p11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p11.AutoSize = true;
            this.p11.BackColor = System.Drawing.Color.Green;
            this.p11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p11.Location = new System.Drawing.Point(729, 462);
            this.p11.Name = "p11";
            this.p11.Size = new System.Drawing.Size(21, 18);
            this.p11.TabIndex = 12;
            this.p11.Text = "‏‏‎ ‎‏‏‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎";
            // 
            // p16
            // 
            this.p16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p16.AutoSize = true;
            this.p16.BackColor = System.Drawing.Color.Green;
            this.p16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p16.Location = new System.Drawing.Point(1155, 430);
            this.p16.Name = "p16";
            this.p16.Size = new System.Drawing.Size(21, 18);
            this.p16.TabIndex = 16;
            this.p16.Text = "‏‏‎ ‎‏‏‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎";
            // 
            // p12
            // 
            this.p12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p12.AutoSize = true;
            this.p12.BackColor = System.Drawing.Color.Green;
            this.p12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p12.Location = new System.Drawing.Point(729, 552);
            this.p12.Name = "p12";
            this.p12.Size = new System.Drawing.Size(21, 18);
            this.p12.TabIndex = 13;
            this.p12.Text = "‏‏‎ ‎‏‏‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎";
            // 
            // p15
            // 
            this.p15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p15.AutoSize = true;
            this.p15.BackColor = System.Drawing.Color.Green;
            this.p15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p15.Location = new System.Drawing.Point(1155, 348);
            this.p15.Name = "p15";
            this.p15.Size = new System.Drawing.Size(21, 18);
            this.p15.TabIndex = 15;
            this.p15.Text = "‏‏‎ ‎‏‏‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎";
            // 
            // p13
            // 
            this.p13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p13.AutoSize = true;
            this.p13.BackColor = System.Drawing.Color.Green;
            this.p13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p13.Location = new System.Drawing.Point(729, 636);
            this.p13.Name = "p13";
            this.p13.Size = new System.Drawing.Size(21, 18);
            this.p13.TabIndex = 14;
            this.p13.Text = "‏‏‎ ‎‏‏‏‏‎ ‎‏‏‎ ‎‏‏‎ ‎‏‏‎";
            // 
            // pbParking
            // 
            this.pbParking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbParking.Image = global::GIP.Properties.Resources.garagesticker;
            this.pbParking.Location = new System.Drawing.Point(0, 0);
            this.pbParking.Name = "pbParking";
            this.pbParking.Size = new System.Drawing.Size(1888, 908);
            this.pbParking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbParking.TabIndex = 1;
            this.pbParking.TabStop = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slagbomenToolStripMenuItem,
            this.tsWeergevenNummer,
            this.tsLogBoekLocatie});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1888, 30);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // slagbomenToolStripMenuItem
            // 
            this.slagbomenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slagboom1ToolStripMenuItem,
            this.slagboom2ToolStripMenuItem});
            this.slagbomenToolStripMenuItem.Name = "slagbomenToolStripMenuItem";
            this.slagbomenToolStripMenuItem.Size = new System.Drawing.Size(99, 26);
            this.slagbomenToolStripMenuItem.Text = "Slagbomen";
            // 
            // slagboom1ToolStripMenuItem
            // 
            this.slagboom1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normaleWerkingSlagboom1ToolStripMenuItem,
            this.altijdGeslotenSlagboom1ToolStripMenuItem,
            this.altijdOpenSlagboom1ToolStripMenuItem});
            this.slagboom1ToolStripMenuItem.Name = "slagboom1ToolStripMenuItem";
            this.slagboom1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.slagboom1ToolStripMenuItem.Text = "Slagboom 1";
            // 
            // normaleWerkingSlagboom1ToolStripMenuItem
            // 
            this.normaleWerkingSlagboom1ToolStripMenuItem.Checked = true;
            this.normaleWerkingSlagboom1ToolStripMenuItem.CheckOnClick = true;
            this.normaleWerkingSlagboom1ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.normaleWerkingSlagboom1ToolStripMenuItem.Name = "normaleWerkingSlagboom1ToolStripMenuItem";
            this.normaleWerkingSlagboom1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.normaleWerkingSlagboom1ToolStripMenuItem.Text = "Normale Werking";
            this.normaleWerkingSlagboom1ToolStripMenuItem.Click += new System.EventHandler(this.slagboomToolStripMenuItem_Click);
            // 
            // altijdGeslotenSlagboom1ToolStripMenuItem
            // 
            this.altijdGeslotenSlagboom1ToolStripMenuItem.CheckOnClick = true;
            this.altijdGeslotenSlagboom1ToolStripMenuItem.Name = "altijdGeslotenSlagboom1ToolStripMenuItem";
            this.altijdGeslotenSlagboom1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.altijdGeslotenSlagboom1ToolStripMenuItem.Text = "Altijd Gesloten";
            this.altijdGeslotenSlagboom1ToolStripMenuItem.Click += new System.EventHandler(this.slagboomToolStripMenuItem_Click);
            // 
            // altijdOpenSlagboom1ToolStripMenuItem
            // 
            this.altijdOpenSlagboom1ToolStripMenuItem.CheckOnClick = true;
            this.altijdOpenSlagboom1ToolStripMenuItem.Name = "altijdOpenSlagboom1ToolStripMenuItem";
            this.altijdOpenSlagboom1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.altijdOpenSlagboom1ToolStripMenuItem.Text = "Altijd Open";
            this.altijdOpenSlagboom1ToolStripMenuItem.Click += new System.EventHandler(this.slagboomToolStripMenuItem_Click);
            // 
            // slagboom2ToolStripMenuItem
            // 
            this.slagboom2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normaleWerkingSlagboom2ToolStripMenuItem,
            this.altijdGeslotenSlagboom2ToolStripMenuItem,
            this.altijdOpenSlagboom2ToolStripMenuItem});
            this.slagboom2ToolStripMenuItem.Name = "slagboom2ToolStripMenuItem";
            this.slagboom2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.slagboom2ToolStripMenuItem.Text = "Slagboom 2";
            // 
            // normaleWerkingSlagboom2ToolStripMenuItem
            // 
            this.normaleWerkingSlagboom2ToolStripMenuItem.Checked = true;
            this.normaleWerkingSlagboom2ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.normaleWerkingSlagboom2ToolStripMenuItem.Name = "normaleWerkingSlagboom2ToolStripMenuItem";
            this.normaleWerkingSlagboom2ToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.normaleWerkingSlagboom2ToolStripMenuItem.Text = "Normale werking";
            this.normaleWerkingSlagboom2ToolStripMenuItem.Click += new System.EventHandler(this.slagboomToolStripMenuItem_Click);
            // 
            // altijdGeslotenSlagboom2ToolStripMenuItem
            // 
            this.altijdGeslotenSlagboom2ToolStripMenuItem.Name = "altijdGeslotenSlagboom2ToolStripMenuItem";
            this.altijdGeslotenSlagboom2ToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.altijdGeslotenSlagboom2ToolStripMenuItem.Text = "Altijd Gesloten";
            this.altijdGeslotenSlagboom2ToolStripMenuItem.Click += new System.EventHandler(this.slagboomToolStripMenuItem_Click);
            // 
            // altijdOpenSlagboom2ToolStripMenuItem
            // 
            this.altijdOpenSlagboom2ToolStripMenuItem.Name = "altijdOpenSlagboom2ToolStripMenuItem";
            this.altijdOpenSlagboom2ToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.altijdOpenSlagboom2ToolStripMenuItem.Text = "Altijd Open";
            this.altijdOpenSlagboom2ToolStripMenuItem.Click += new System.EventHandler(this.slagboomToolStripMenuItem_Click);
            // 
            // tsWeergevenNummer
            // 
            this.tsWeergevenNummer.Name = "tsWeergevenNummer";
            this.tsWeergevenNummer.Size = new System.Drawing.Size(134, 26);
            this.tsWeergevenNummer.Text = "Toggle nummers";
            this.tsWeergevenNummer.Click += new System.EventHandler(this.tsWeergevenNummer_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsConnectie,
            this.tsLayout3,
            this.tsProgressbar,
            this.tsBeschikbaar,
            this.tsLayout2,
            this.tsSlagboom1,
            this.tsLayout1,
            this.tsSlagboom2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1001);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1902, 32);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsConnectie
            // 
            this.tsConnectie.ForeColor = System.Drawing.Color.Red;
            this.tsConnectie.Name = "tsConnectie";
            this.tsConnectie.Size = new System.Drawing.Size(113, 26);
            this.tsConnectie.Text = "Niet Verbonden";
            // 
            // tsLayout3
            // 
            this.tsLayout3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsLayout3.Name = "tsLayout3";
            this.tsLayout3.Size = new System.Drawing.Size(19, 26);
            this.tsLayout3.Text = "||";
            // 
            // tsProgressbar
            // 
            this.tsProgressbar.Maximum = 26;
            this.tsProgressbar.Name = "tsProgressbar";
            this.tsProgressbar.Size = new System.Drawing.Size(100, 24);
            // 
            // tsBeschikbaar
            // 
            this.tsBeschikbaar.Name = "tsBeschikbaar";
            this.tsBeschikbaar.Size = new System.Drawing.Size(39, 26);
            this.tsBeschikbaar.Text = "0/26";
            // 
            // tsLayout2
            // 
            this.tsLayout2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsLayout2.Name = "tsLayout2";
            this.tsLayout2.Size = new System.Drawing.Size(19, 26);
            this.tsLayout2.Text = "||";
            // 
            // tsSlagboom1
            // 
            this.tsSlagboom1.Name = "tsSlagboom1";
            this.tsSlagboom1.Size = new System.Drawing.Size(155, 26);
            this.tsSlagboom1.Text = "Slagboom 1: Normaal";
            // 
            // tsLayout1
            // 
            this.tsLayout1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsLayout1.Name = "tsLayout1";
            this.tsLayout1.Size = new System.Drawing.Size(19, 26);
            this.tsLayout1.Text = "||";
            // 
            // tsSlagboom2
            // 
            this.tsSlagboom2.Name = "tsSlagboom2";
            this.tsSlagboom2.Size = new System.Drawing.Size(155, 26);
            this.tsSlagboom2.Text = "Slagboom 2: Normaal";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 30);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1902, 971);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlBesturing);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1894, 942);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Controle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlConnect);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1894, 948);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Verbinden";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1902, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsLogBoekLocatie
            // 
            this.tsLogBoekLocatie.Name = "tsLogBoekLocatie";
            this.tsLogBoekLocatie.Size = new System.Drawing.Size(139, 26);
            this.tsLogBoekLocatie.Text = "Opslaan Logboek";
            this.tsLogBoekLocatie.Click += new System.EventHandler(this.tsLogBoekLocatie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip2;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Form1";
            this.Text = "Parkeergarage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.pnlConnect.ResumeLayout(false);
            this.pnlBesturing.ResumeLayout(false);
            this.pnlBesturing.PerformLayout();
            this.pnlParkingEnStatus.ResumeLayout(false);
            this.pnlParkingEnStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbParking)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlConnect;
        private System.Windows.Forms.ListBox lstConsole;
        private System.Windows.Forms.ListBox lstPoort;
        private System.IO.Ports.SerialPort serial;
        private System.Windows.Forms.Panel pnlBesturing;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem slagbomenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slagboom1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altijdGeslotenSlagboom1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normaleWerkingSlagboom1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altijdOpenSlagboom1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slagboom2ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar tsProgressbar;
        private System.Windows.Forms.ToolStripStatusLabel tsSlagboom1;
        private System.Windows.Forms.ToolStripMenuItem normaleWerkingSlagboom2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altijdGeslotenSlagboom2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altijdOpenSlagboom2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tsSlagboom2;
        private System.Windows.Forms.ToolStripStatusLabel tsConnectie;
        private System.Windows.Forms.ToolStripStatusLabel tsLayout1;
        private System.Windows.Forms.ToolStripStatusLabel tsLayout2;
        private System.Windows.Forms.ToolStripStatusLabel tsLayout3;
        private System.Windows.Forms.ToolStripStatusLabel tsBeschikbaar;
        private System.Windows.Forms.PictureBox pbParking;
        private System.Windows.Forms.Label p1;
        private System.Windows.Forms.Label p14;
        private System.Windows.Forms.Label p26;
        private System.Windows.Forms.Label p25;
        private System.Windows.Forms.Label p24;
        private System.Windows.Forms.Label p23;
        private System.Windows.Forms.Label p22;
        private System.Windows.Forms.Label p21;
        private System.Windows.Forms.Label p20;
        private System.Windows.Forms.Label p19;
        private System.Windows.Forms.Label p18;
        private System.Windows.Forms.Label p17;
        private System.Windows.Forms.Label p16;
        private System.Windows.Forms.Label p15;
        private System.Windows.Forms.Label p13;
        private System.Windows.Forms.Label p12;
        private System.Windows.Forms.Label p11;
        private System.Windows.Forms.Label p10;
        private System.Windows.Forms.Label p9;
        private System.Windows.Forms.Label p8;
        private System.Windows.Forms.Label p7;
        private System.Windows.Forms.Label p6;
        private System.Windows.Forms.Label p5;
        private System.Windows.Forms.Label p4;
        private System.Windows.Forms.Label p3;
        private System.Windows.Forms.Label p2;
        private System.Windows.Forms.Panel pnlParkingEnStatus;
        private System.Windows.Forms.ToolStripMenuItem tsWeergevenNummer;
        private System.Windows.Forms.ToolStripMenuItem tsLogBoekLocatie;
    }
}

