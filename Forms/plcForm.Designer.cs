namespace Serialport.Forms
{
    partial class plcForm
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
            this.plcip = new System.Windows.Forms.Label();
            this.ipAdr = new System.Windows.Forms.TextBox();
            this.plctip = new System.Windows.Forms.Label();
            this.plctipi = new System.Windows.Forms.ComboBox();
            this.comboRack = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.durum = new System.Windows.Forms.ToolStripStatusLabel();
            this.Baglan = new System.Windows.Forms.Button();
            this.Baglantıkes = new System.Windows.Forms.Button();
            this.comboSlot = new System.Windows.Forms.ComboBox();
            this.texboxRead1 = new System.Windows.Forms.TextBox();
            this.ButtonRead = new System.Windows.Forms.Button();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.writeTxt = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plcip
            // 
            this.plcip.AutoSize = true;
            this.plcip.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.plcip.Location = new System.Drawing.Point(123, 127);
            this.plcip.Name = "plcip";
            this.plcip.Size = new System.Drawing.Size(57, 21);
            this.plcip.TabIndex = 0;
            this.plcip.Text = "PLC ip";
            // 
            // ipAdr
            // 
            this.ipAdr.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ipAdr.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ipAdr.Location = new System.Drawing.Point(205, 130);
            this.ipAdr.Name = "ipAdr";
            this.ipAdr.Size = new System.Drawing.Size(111, 27);
            this.ipAdr.TabIndex = 1;
            // 
            // plctip
            // 
            this.plctip.AutoSize = true;
            this.plctip.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.plctip.Location = new System.Drawing.Point(123, 167);
            this.plctip.Name = "plctip";
            this.plctip.Size = new System.Drawing.Size(64, 21);
            this.plctip.TabIndex = 2;
            this.plctip.Text = "PLC tip";
            // 
            // plctipi
            // 
            this.plctipi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.plctipi.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.plctipi.FormattingEnabled = true;
            this.plctipi.Items.AddRange(new object[] {
            "S71500",
            "S71200",
            "S7300",
            "S7200"});
            this.plctipi.Location = new System.Drawing.Point(205, 167);
            this.plctipi.Name = "plctipi";
            this.plctipi.Size = new System.Drawing.Size(111, 29);
            this.plctipi.TabIndex = 5;
            // 
            // comboRack
            // 
            this.comboRack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboRack.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.comboRack.FormattingEnabled = true;
            this.comboRack.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboRack.Location = new System.Drawing.Point(429, 128);
            this.comboRack.Name = "comboRack";
            this.comboRack.Size = new System.Drawing.Size(111, 29);
            this.comboRack.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(358, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Slot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(358, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rack";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.durum});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // durum
            // 
            this.durum.Name = "durum";
            this.durum.Size = new System.Drawing.Size(44, 17);
            this.durum.Text = "Durum";
            // 
            // Baglan
            // 
            this.Baglan.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Baglan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Baglan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Baglan.Location = new System.Drawing.Point(127, 243);
            this.Baglan.Name = "Baglan";
            this.Baglan.Size = new System.Drawing.Size(140, 63);
            this.Baglan.TabIndex = 11;
            this.Baglan.Text = "BAĞLAN";
            this.Baglan.UseVisualStyleBackColor = false;
            this.Baglan.Click += new System.EventHandler(this.Baglan_Click);
            // 
            // Baglantıkes
            // 
            this.Baglantıkes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Baglantıkes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Baglantıkes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Baglantıkes.Location = new System.Drawing.Point(296, 243);
            this.Baglantıkes.Name = "Baglantıkes";
            this.Baglantıkes.Size = new System.Drawing.Size(140, 63);
            this.Baglantıkes.TabIndex = 12;
            this.Baglantıkes.Text = "BAĞLANTIYI KES";
            this.Baglantıkes.UseVisualStyleBackColor = false;
            this.Baglantıkes.Click += new System.EventHandler(this.Baglantıkes_Click);
            // 
            // comboSlot
            // 
            this.comboSlot.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboSlot.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.comboSlot.FormattingEnabled = true;
            this.comboSlot.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboSlot.Location = new System.Drawing.Point(429, 167);
            this.comboSlot.Name = "comboSlot";
            this.comboSlot.Size = new System.Drawing.Size(111, 29);
            this.comboSlot.TabIndex = 13;
            // 
            // texboxRead1
            // 
            this.texboxRead1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.texboxRead1.Location = new System.Drawing.Point(491, 336);
            this.texboxRead1.Name = "texboxRead1";
            this.texboxRead1.Size = new System.Drawing.Size(100, 41);
            this.texboxRead1.TabIndex = 14;
            // 
            // ButtonRead
            // 
            this.ButtonRead.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ButtonRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRead.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonRead.Location = new System.Drawing.Point(491, 243);
            this.ButtonRead.Name = "ButtonRead";
            this.ButtonRead.Size = new System.Drawing.Size(140, 63);
            this.ButtonRead.TabIndex = 15;
            this.ButtonRead.Text = "Read";
            this.ButtonRead.UseVisualStyleBackColor = false;
            this.ButtonRead.Click += new System.EventHandler(this.ButtonRead_Click);
            // 
            // buttonWrite
            // 
            this.buttonWrite.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWrite.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonWrite.Location = new System.Drawing.Point(610, 336);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(119, 41);
            this.buttonWrite.TabIndex = 16;
            this.buttonWrite.Text = "Logic 1";
            this.buttonWrite.UseVisualStyleBackColor = false;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // writeTxt
            // 
            this.writeTxt.AutoSize = true;
            this.writeTxt.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.writeTxt.Location = new System.Drawing.Point(485, 380);
            this.writeTxt.Name = "writeTxt";
            this.writeTxt.Size = new System.Drawing.Size(0, 33);
            this.writeTxt.TabIndex = 17;
            // 
            // plcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.writeTxt);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.ButtonRead);
            this.Controls.Add(this.texboxRead1);
            this.Controls.Add(this.comboSlot);
            this.Controls.Add(this.Baglantıkes);
            this.Controls.Add(this.Baglan);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboRack);
            this.Controls.Add(this.plctipi);
            this.Controls.Add(this.plctip);
            this.Controls.Add(this.ipAdr);
            this.Controls.Add(this.plcip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "plcForm";
            this.Text = "plcForm";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label plcip;
        private System.Windows.Forms.TextBox ipAdr;
        private System.Windows.Forms.Label plctip;
        private System.Windows.Forms.ComboBox plctipi;
        private System.Windows.Forms.ComboBox comboRack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel durum;
        private System.Windows.Forms.Button Baglan;
        private System.Windows.Forms.Button Baglantıkes;
        private System.Windows.Forms.ComboBox comboSlot;
        private System.Windows.Forms.TextBox texboxRead1;
        private System.Windows.Forms.Button ButtonRead;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.Label writeTxt;
    }
}