
namespace Serialport
{
    partial class FormPort
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.kapat = new System.Windows.Forms.Button();
            this.logic1 = new System.Windows.Forms.Button();
            this.Logic0 = new System.Windows.Forms.Button();
            this.Baglan = new System.Windows.Forms.Button();
            this.pwmScrol = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pwmScrol)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(178, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 29);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // kapat
            // 
            this.kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kapat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapat.Location = new System.Drawing.Point(477, 64);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(140, 63);
            this.kapat.TabIndex = 3;
            this.kapat.Text = "Bağlantıyı kes";
            this.kapat.UseVisualStyleBackColor = true;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // logic1
            // 
            this.logic1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.logic1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logic1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.logic1.Location = new System.Drawing.Point(178, 159);
            this.logic1.Name = "logic1";
            this.logic1.Size = new System.Drawing.Size(140, 63);
            this.logic1.TabIndex = 4;
            this.logic1.Text = "Logic 1";
            this.logic1.UseVisualStyleBackColor = false;
            this.logic1.Click += new System.EventHandler(this.logic1_Click);
            // 
            // Logic0
            // 
            this.Logic0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logic0.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Logic0.Location = new System.Drawing.Point(178, 239);
            this.Logic0.Name = "Logic0";
            this.Logic0.Size = new System.Drawing.Size(140, 63);
            this.Logic0.TabIndex = 4;
            this.Logic0.Text = "Logic 0";
            this.Logic0.UseVisualStyleBackColor = true;
            this.Logic0.Click += new System.EventHandler(this.Logic0_Click);
            // 
            // Baglan
            // 
            this.Baglan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Baglan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Baglan.Location = new System.Drawing.Point(331, 64);
            this.Baglan.Name = "Baglan";
            this.Baglan.Size = new System.Drawing.Size(140, 63);
            this.Baglan.TabIndex = 3;
            this.Baglan.Text = "Bağlan";
            this.Baglan.UseVisualStyleBackColor = true;
            this.Baglan.Click += new System.EventHandler(this.Baglan_Click);
            // 
            // pwmScrol
            // 
            this.pwmScrol.Location = new System.Drawing.Point(348, 256);
            this.pwmScrol.Maximum = 255;
            this.pwmScrol.Name = "pwmScrol";
            this.pwmScrol.Size = new System.Drawing.Size(269, 45);
            this.pwmScrol.TabIndex = 5;
            this.pwmScrol.Scroll += new System.EventHandler(this.pwmScrol_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(432, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 33);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(432, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "PWM";
            // 
            // FormPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pwmScrol);
            this.Controls.Add(this.Logic0);
            this.Controls.Add(this.logic1);
            this.Controls.Add(this.Baglan);
            this.Controls.Add(this.kapat);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPort";
            this.Opacity = 0D;
            this.Text = "FormPort";
            this.Load += new System.EventHandler(this.FormPort_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pwmScrol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button kapat;
        private System.Windows.Forms.Button logic1;
        private System.Windows.Forms.Button Logic0;
        private System.Windows.Forms.Button Baglan;
        private System.Windows.Forms.TrackBar pwmScrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}