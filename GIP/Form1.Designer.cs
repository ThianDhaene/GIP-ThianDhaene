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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsConnectie = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsProgressbar = new System.Windows.Forms.ToolStripProgressBar();
            this.tsLayout2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSlagboom1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLayout1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSlagboom2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsBeschikbaar = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLayout3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlConnect.SuspendLayout();
            this.pnlBesturing.SuspendLayout();
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
            this.lstConsole.ItemHeight = 20;
            this.lstConsole.Location = new System.Drawing.Point(134, 0);
            this.lstConsole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstConsole.Name = "lstConsole";
            this.lstConsole.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstConsole.Size = new System.Drawing.Size(551, 200);
            this.lstConsole.TabIndex = 0;
            // 
            // pnlConnect
            // 
            this.pnlConnect.Controls.Add(this.lstConsole);
            this.pnlConnect.Controls.Add(this.lstPoort);
            this.pnlConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConnect.Location = new System.Drawing.Point(3, 2);
            this.pnlConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlConnect.MinimumSize = new System.Drawing.Size(0, 50);
            this.pnlConnect.Name = "pnlConnect";
            this.pnlConnect.Size = new System.Drawing.Size(1095, 200);
            this.pnlConnect.TabIndex = 1;
            // 
            // lstPoort
            // 
            this.lstPoort.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstPoort.FormattingEnabled = true;
            this.lstPoort.ItemHeight = 20;
            this.lstPoort.Location = new System.Drawing.Point(0, 0);
            this.lstPoort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstPoort.Name = "lstPoort";
            this.lstPoort.Size = new System.Drawing.Size(134, 200);
            this.lstPoort.TabIndex = 0;
            this.lstPoort.SelectedIndexChanged += new System.EventHandler(this.lstPoort_SelectedIndexChanged);
            // 
            // serial
            // 
            this.serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serial_DataReceived);
            // 
            // pnlBesturing
            // 
            this.pnlBesturing.Controls.Add(this.menuStrip2);
            this.pnlBesturing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBesturing.Location = new System.Drawing.Point(3, 2);
            this.pnlBesturing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBesturing.Name = "pnlBesturing";
            this.pnlBesturing.Size = new System.Drawing.Size(1095, 532);
            this.pnlBesturing.TabIndex = 2;
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slagbomenToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1095, 33);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // slagbomenToolStripMenuItem
            // 
            this.slagbomenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slagboom1ToolStripMenuItem,
            this.slagboom2ToolStripMenuItem});
            this.slagbomenToolStripMenuItem.Name = "slagbomenToolStripMenuItem";
            this.slagbomenToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.slagbomenToolStripMenuItem.Text = "Slagbomen";
            // 
            // slagboom1ToolStripMenuItem
            // 
            this.slagboom1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normaleWerkingSlagboom1ToolStripMenuItem,
            this.altijdGeslotenSlagboom1ToolStripMenuItem,
            this.altijdOpenSlagboom1ToolStripMenuItem});
            this.slagboom1ToolStripMenuItem.Name = "slagboom1ToolStripMenuItem";
            this.slagboom1ToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.slagboom1ToolStripMenuItem.Text = "Slagboom 1";
            // 
            // normaleWerkingSlagboom1ToolStripMenuItem
            // 
            this.normaleWerkingSlagboom1ToolStripMenuItem.Checked = true;
            this.normaleWerkingSlagboom1ToolStripMenuItem.CheckOnClick = true;
            this.normaleWerkingSlagboom1ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.normaleWerkingSlagboom1ToolStripMenuItem.Name = "normaleWerkingSlagboom1ToolStripMenuItem";
            this.normaleWerkingSlagboom1ToolStripMenuItem.Size = new System.Drawing.Size(252, 34);
            this.normaleWerkingSlagboom1ToolStripMenuItem.Text = "Normale Werking";
            this.normaleWerkingSlagboom1ToolStripMenuItem.Click += new System.EventHandler(this.slagboom1ToolStripMenuItem_Click);
            // 
            // altijdGeslotenSlagboom1ToolStripMenuItem
            // 
            this.altijdGeslotenSlagboom1ToolStripMenuItem.CheckOnClick = true;
            this.altijdGeslotenSlagboom1ToolStripMenuItem.Name = "altijdGeslotenSlagboom1ToolStripMenuItem";
            this.altijdGeslotenSlagboom1ToolStripMenuItem.Size = new System.Drawing.Size(252, 34);
            this.altijdGeslotenSlagboom1ToolStripMenuItem.Text = "Altijd Gesloten";
            this.altijdGeslotenSlagboom1ToolStripMenuItem.Click += new System.EventHandler(this.slagboom1ToolStripMenuItem_Click);
            // 
            // altijdOpenSlagboom1ToolStripMenuItem
            // 
            this.altijdOpenSlagboom1ToolStripMenuItem.CheckOnClick = true;
            this.altijdOpenSlagboom1ToolStripMenuItem.Name = "altijdOpenSlagboom1ToolStripMenuItem";
            this.altijdOpenSlagboom1ToolStripMenuItem.Size = new System.Drawing.Size(252, 34);
            this.altijdOpenSlagboom1ToolStripMenuItem.Text = "Altijd Open";
            this.altijdOpenSlagboom1ToolStripMenuItem.Click += new System.EventHandler(this.slagboom1ToolStripMenuItem_Click);
            // 
            // slagboom2ToolStripMenuItem
            // 
            this.slagboom2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normaleWerkingSlagboom2ToolStripMenuItem,
            this.altijdGeslotenSlagboom2ToolStripMenuItem,
            this.altijdOpenSlagboom2ToolStripMenuItem});
            this.slagboom2ToolStripMenuItem.Name = "slagboom2ToolStripMenuItem";
            this.slagboom2ToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.slagboom2ToolStripMenuItem.Text = "Slagboom 2";
            // 
            // normaleWerkingSlagboom2ToolStripMenuItem
            // 
            this.normaleWerkingSlagboom2ToolStripMenuItem.Checked = true;
            this.normaleWerkingSlagboom2ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.normaleWerkingSlagboom2ToolStripMenuItem.Name = "normaleWerkingSlagboom2ToolStripMenuItem";
            this.normaleWerkingSlagboom2ToolStripMenuItem.Size = new System.Drawing.Size(249, 34);
            this.normaleWerkingSlagboom2ToolStripMenuItem.Text = "Normale werking";
            this.normaleWerkingSlagboom2ToolStripMenuItem.Click += new System.EventHandler(this.slagboom2ToolStripMenuItem_Click);
            // 
            // altijdGeslotenSlagboom2ToolStripMenuItem
            // 
            this.altijdGeslotenSlagboom2ToolStripMenuItem.Name = "altijdGeslotenSlagboom2ToolStripMenuItem";
            this.altijdGeslotenSlagboom2ToolStripMenuItem.Size = new System.Drawing.Size(249, 34);
            this.altijdGeslotenSlagboom2ToolStripMenuItem.Text = "Altijd Gesloten";
            this.altijdGeslotenSlagboom2ToolStripMenuItem.Click += new System.EventHandler(this.slagboom2ToolStripMenuItem_Click);
            // 
            // altijdOpenSlagboom2ToolStripMenuItem
            // 
            this.altijdOpenSlagboom2ToolStripMenuItem.Name = "altijdOpenSlagboom2ToolStripMenuItem";
            this.altijdOpenSlagboom2ToolStripMenuItem.Size = new System.Drawing.Size(249, 34);
            this.altijdOpenSlagboom2ToolStripMenuItem.Text = "Altijd Open";
            this.altijdOpenSlagboom2ToolStripMenuItem.Click += new System.EventHandler(this.slagboom2ToolStripMenuItem_Click);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 593);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1109, 38);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsConnectie
            // 
            this.tsConnectie.ForeColor = System.Drawing.Color.Red;
            this.tsConnectie.Name = "tsConnectie";
            this.tsConnectie.Size = new System.Drawing.Size(136, 31);
            this.tsConnectie.Text = "Niet Verbonden";
            // 
            // tsProgressbar
            // 
            this.tsProgressbar.Maximum = 26;
            this.tsProgressbar.Name = "tsProgressbar";
            this.tsProgressbar.Size = new System.Drawing.Size(112, 30);
            // 
            // tsLayout2
            // 
            this.tsLayout2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsLayout2.Name = "tsLayout2";
            this.tsLayout2.Size = new System.Drawing.Size(24, 31);
            this.tsLayout2.Text = "||";
            // 
            // tsSlagboom1
            // 
            this.tsSlagboom1.Name = "tsSlagboom1";
            this.tsSlagboom1.Size = new System.Drawing.Size(187, 31);
            this.tsSlagboom1.Text = "Slagboom 1: Normaal";
            // 
            // tsLayout1
            // 
            this.tsLayout1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsLayout1.Name = "tsLayout1";
            this.tsLayout1.Size = new System.Drawing.Size(24, 31);
            this.tsLayout1.Text = "||";
            // 
            // tsSlagboom2
            // 
            this.tsSlagboom2.Name = "tsSlagboom2";
            this.tsSlagboom2.Size = new System.Drawing.Size(187, 31);
            this.tsSlagboom2.Text = "Slagboom 2: Normaal";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1109, 569);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlBesturing);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1101, 536);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Controle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlConnect);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1101, 528);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Verbinden";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1109, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsBeschikbaar
            // 
            this.tsBeschikbaar.Name = "tsBeschikbaar";
            this.tsBeschikbaar.Size = new System.Drawing.Size(49, 31);
            this.tsBeschikbaar.Text = "0/26";
            // 
            // tsLayout3
            // 
            this.tsLayout3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsLayout3.Name = "tsLayout3";
            this.tsLayout3.Size = new System.Drawing.Size(24, 31);
            this.tsLayout3.Text = "||";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 631);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip2;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Parkeergarage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.pnlConnect.ResumeLayout(false);
            this.pnlBesturing.ResumeLayout(false);
            this.pnlBesturing.PerformLayout();
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
    }
}

