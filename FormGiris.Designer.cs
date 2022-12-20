namespace RecycleCoinCuzdan
{
    partial class FormGiris
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOnar = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnAc = new System.Windows.Forms.Button();
            this.panelText = new System.Windows.Forms.Panel();
            this.tbAnimsatici = new System.Windows.Forms.TextBox();
            this.btnTamam = new System.Windows.Forms.Button();
            this.sayac = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSunucuDurum = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIptal = new System.Windows.Forms.Button();
            this.timerSunucuDurum = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelText.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOnar);
            this.panel1.Controls.Add(this.btnYeni);
            this.panel1.Controls.Add(this.btnAc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 200);
            this.panel1.TabIndex = 0;
            // 
            // btnOnar
            // 
            this.btnOnar.Location = new System.Drawing.Point(168, 143);
            this.btnOnar.Name = "btnOnar";
            this.btnOnar.Size = new System.Drawing.Size(165, 36);
            this.btnOnar.TabIndex = 17;
            this.btnOnar.Text = "Onar";
            this.btnOnar.UseVisualStyleBackColor = true;
            this.btnOnar.Click += new System.EventHandler(this.btnOnar_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(168, 71);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(165, 36);
            this.btnYeni.TabIndex = 15;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnAc
            // 
            this.btnAc.Location = new System.Drawing.Point(168, 12);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(165, 38);
            this.btnAc.TabIndex = 14;
            this.btnAc.Text = "Aç";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // panelText
            // 
            this.panelText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelText.Controls.Add(this.tbAnimsatici);
            this.panelText.Controls.Add(this.btnTamam);
            this.panelText.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelText.Location = new System.Drawing.Point(0, 200);
            this.panelText.MaximumSize = new System.Drawing.Size(532, 266);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(532, 250);
            this.panelText.TabIndex = 2;
            // 
            // tbAnimsatici
            // 
            this.tbAnimsatici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAnimsatici.Location = new System.Drawing.Point(0, 0);
            this.tbAnimsatici.Multiline = true;
            this.tbAnimsatici.Name = "tbAnimsatici";
            this.tbAnimsatici.Size = new System.Drawing.Size(530, 192);
            this.tbAnimsatici.TabIndex = 21;
            this.tbAnimsatici.TextChanged += new System.EventHandler(this.tbAnimsatici_TextChanged);
            this.tbAnimsatici.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAnimsatici_KeyDown);
            this.tbAnimsatici.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbAnimsatici_KeyUp);
            // 
            // btnTamam
            // 
            this.btnTamam.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTamam.Location = new System.Drawing.Point(0, 192);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(530, 56);
            this.btnTamam.TabIndex = 20;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // sayac
            // 
            this.sayac.Interval = 1000;
            this.sayac.Tick += new System.EventHandler(this.sayac_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblSunucuDurum});
            this.statusStrip1.Location = new System.Drawing.Point(0, 512);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(532, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(113, 20);
            this.toolStripStatusLabel1.Text = "Sunucu Durumu";
            // 
            // lblSunucuDurum
            // 
            this.lblSunucuDurum.Name = "lblSunucuDurum";
            this.lblSunucuDurum.Size = new System.Drawing.Size(15, 20);
            this.lblSunucuDurum.Text = "-";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnIptal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 455);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 57);
            this.panel2.TabIndex = 5;
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(168, 3);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(165, 44);
            this.btnIptal.TabIndex = 16;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click_1);
            // 
            // timerSunucuDurum
            // 
            this.timerSunucuDurum.Tick += new System.EventHandler(this.timerSunucuDurum_Tick);
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(532, 538);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelText);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 585);
            this.Name = "FormGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CuzdanSecici";
            this.panel1.ResumeLayout(false);
            this.panelText.ResumeLayout(false);
            this.panelText.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private Button btnOnar;
        private Button btnYeni;
        private Button btnAc;
        private Panel panelText;
        private Button btnTamam;
        private System.Windows.Forms.Timer sayac;
        private TextBox tbAnimsatici;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblSunucuDurum;
        private Panel panel2;
        private Button btnIptal;
        private System.Windows.Forms.Timer timerSunucuDurum;
    }
}