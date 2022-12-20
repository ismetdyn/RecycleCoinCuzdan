namespace RecycleCoinCuzdan
{
    partial class AnaPencere
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSunucuDurum = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCuzdan = new System.Windows.Forms.TabPage();
            this.btnAdresKopyala = new System.Windows.Forms.Button();
            this.lblAdres = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOnaylanmamisBakiye = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageIslem = new System.Windows.Forms.TabPage();
            this.nudMiktar = new System.Windows.Forms.NumericUpDown();
            this.tbAliciAdres = new System.Windows.Forms.TextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageBekleyenIslemler = new System.Windows.Forms.TabPage();
            this.tabPageGecmisIslemler = new System.Windows.Forms.TabPage();
            this.sayac = new System.Windows.Forms.Timer(this.components);
            this.treeViewBekleyenIslemler = new System.Windows.Forms.TreeView();
            this.treeViewGecmisIslemler = new System.Windows.Forms.TreeView();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageCuzdan.SuspendLayout();
            this.tabPageIslem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).BeginInit();
            this.tabPageBekleyenIslemler.SuspendLayout();
            this.tabPageGecmisIslemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.statusStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 485);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 37);
            this.panel2.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblSunucuDurum});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 37);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(116, 31);
            this.toolStripStatusLabel1.Text = "Sunucu Durumu:";
            // 
            // lblSunucuDurum
            // 
            this.lblSunucuDurum.Name = "lblSunucuDurum";
            this.lblSunucuDurum.Size = new System.Drawing.Size(15, 31);
            this.lblSunucuDurum.Text = "-";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCuzdan);
            this.tabControl1.Controls.Add(this.tabPageIslem);
            this.tabControl1.Controls.Add(this.tabPageBekleyenIslemler);
            this.tabControl1.Controls.Add(this.tabPageGecmisIslemler);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 485);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageCuzdan
            // 
            this.tabPageCuzdan.Controls.Add(this.btnAdresKopyala);
            this.tabPageCuzdan.Controls.Add(this.lblAdres);
            this.tabPageCuzdan.Controls.Add(this.label3);
            this.tabPageCuzdan.Controls.Add(this.lblOnaylanmamisBakiye);
            this.tabPageCuzdan.Controls.Add(this.label2);
            this.tabPageCuzdan.Controls.Add(this.lblBakiye);
            this.tabPageCuzdan.Controls.Add(this.label1);
            this.tabPageCuzdan.Location = new System.Drawing.Point(4, 29);
            this.tabPageCuzdan.Name = "tabPageCuzdan";
            this.tabPageCuzdan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCuzdan.Size = new System.Drawing.Size(792, 452);
            this.tabPageCuzdan.TabIndex = 0;
            this.tabPageCuzdan.Text = "Cüzdan";
            this.tabPageCuzdan.UseVisualStyleBackColor = true;
            // 
            // btnAdresKopyala
            // 
            this.btnAdresKopyala.AutoSize = true;
            this.btnAdresKopyala.Location = new System.Drawing.Point(25, 236);
            this.btnAdresKopyala.Name = "btnAdresKopyala";
            this.btnAdresKopyala.Size = new System.Drawing.Size(119, 30);
            this.btnAdresKopyala.TabIndex = 8;
            this.btnAdresKopyala.Text = "Adresi Kopyala";
            this.btnAdresKopyala.UseVisualStyleBackColor = true;
            this.btnAdresKopyala.Click += new System.EventHandler(this.btnAdresKopyala_Click);
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(25, 195);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(89, 20);
            this.lblAdres.TabIndex = 7;
            this.lblAdres.Text = "....Yükleniyor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cuzdan Adresi";
            // 
            // lblOnaylanmamisBakiye
            // 
            this.lblOnaylanmamisBakiye.AutoSize = true;
            this.lblOnaylanmamisBakiye.Location = new System.Drawing.Point(188, 76);
            this.lblOnaylanmamisBakiye.Name = "lblOnaylanmamisBakiye";
            this.lblOnaylanmamisBakiye.Size = new System.Drawing.Size(40, 20);
            this.lblOnaylanmamisBakiye.TabIndex = 5;
            this.lblOnaylanmamisBakiye.Text = "X RC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Onaylanmamış Bakiye:";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Location = new System.Drawing.Point(188, 42);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(40, 20);
            this.lblBakiye.TabIndex = 3;
            this.lblBakiye.Text = "X RC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bakiye:";
            // 
            // tabPageIslem
            // 
            this.tabPageIslem.Controls.Add(this.nudMiktar);
            this.tabPageIslem.Controls.Add(this.tbAliciAdres);
            this.tabPageIslem.Controls.Add(this.btnGonder);
            this.tabPageIslem.Controls.Add(this.label5);
            this.tabPageIslem.Controls.Add(this.label4);
            this.tabPageIslem.Location = new System.Drawing.Point(4, 29);
            this.tabPageIslem.Name = "tabPageIslem";
            this.tabPageIslem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIslem.Size = new System.Drawing.Size(792, 452);
            this.tabPageIslem.TabIndex = 1;
            this.tabPageIslem.Text = "İşlem";
            this.tabPageIslem.UseVisualStyleBackColor = true;
            // 
            // nudMiktar
            // 
            this.nudMiktar.DecimalPlaces = 8;
            this.nudMiktar.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMiktar.Location = new System.Drawing.Point(141, 73);
            this.nudMiktar.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudMiktar.Name = "nudMiktar";
            this.nudMiktar.Size = new System.Drawing.Size(421, 27);
            this.nudMiktar.TabIndex = 2;
            // 
            // tbAliciAdres
            // 
            this.tbAliciAdres.Location = new System.Drawing.Point(141, 31);
            this.tbAliciAdres.Name = "tbAliciAdres";
            this.tbAliciAdres.Size = new System.Drawing.Size(421, 27);
            this.tbAliciAdres.TabIndex = 4;
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(458, 131);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(104, 45);
            this.btnGonder.TabIndex = 3;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.BtnGonder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Miktar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Alıcı Adres:";
            // 
            // tabPageBekleyenIslemler
            // 
            this.tabPageBekleyenIslemler.Controls.Add(this.treeViewBekleyenIslemler);
            this.tabPageBekleyenIslemler.Location = new System.Drawing.Point(4, 29);
            this.tabPageBekleyenIslemler.Name = "tabPageBekleyenIslemler";
            this.tabPageBekleyenIslemler.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBekleyenIslemler.Size = new System.Drawing.Size(792, 452);
            this.tabPageBekleyenIslemler.TabIndex = 2;
            this.tabPageBekleyenIslemler.Text = "Bekleyen İşlemler";
            this.tabPageBekleyenIslemler.UseVisualStyleBackColor = true;
            // 
            // tabPageGecmisIslemler
            // 
            this.tabPageGecmisIslemler.Controls.Add(this.treeViewGecmisIslemler);
            this.tabPageGecmisIslemler.Location = new System.Drawing.Point(4, 29);
            this.tabPageGecmisIslemler.Name = "tabPageGecmisIslemler";
            this.tabPageGecmisIslemler.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGecmisIslemler.Size = new System.Drawing.Size(792, 452);
            this.tabPageGecmisIslemler.TabIndex = 3;
            this.tabPageGecmisIslemler.Text = "Geçmiş İşlemler";
            this.tabPageGecmisIslemler.UseVisualStyleBackColor = true;
            // 
            // sayac
            // 
            this.sayac.Interval = 2000;
            this.sayac.Tick += new System.EventHandler(this.sayac_Tick);
            // 
            // treeViewBekleyenIslemler
            // 
            this.treeViewBekleyenIslemler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewBekleyenIslemler.Location = new System.Drawing.Point(3, 3);
            this.treeViewBekleyenIslemler.Name = "treeViewBekleyenIslemler";
            this.treeViewBekleyenIslemler.Size = new System.Drawing.Size(786, 446);
            this.treeViewBekleyenIslemler.TabIndex = 0;
            // 
            // treeViewGecmisIslemler
            // 
            this.treeViewGecmisIslemler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewGecmisIslemler.Location = new System.Drawing.Point(3, 3);
            this.treeViewGecmisIslemler.Name = "treeViewGecmisIslemler";
            this.treeViewGecmisIslemler.Size = new System.Drawing.Size(786, 446);
            this.treeViewGecmisIslemler.TabIndex = 0;
            // 
            // AnaPencere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Name = "AnaPencere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageCuzdan.ResumeLayout(false);
            this.tabPageCuzdan.PerformLayout();
            this.tabPageIslem.ResumeLayout(false);
            this.tabPageIslem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).EndInit();
            this.tabPageBekleyenIslemler.ResumeLayout(false);
            this.tabPageGecmisIslemler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private TabControl tabControl1;
        private TabPage tabPageCuzdan;
        private TabPage tabPageIslem;
        private TabPage tabPageBekleyenIslemler;
        private Label label1;
        private Label lblBakiye;
        private Label label2;
        private Label lblOnaylanmamisBakiye;
        private Label lblAdres;
        private Label label3;
        private Button btnAdresKopyala;
        private Label label5;
        private Label label4;
        private Button btnGonder;
        private TextBox tbAliciAdres;
        private TabPage tabPageGecmisIslemler;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblSunucuDurum;
        private NumericUpDown nudMiktar;
        private System.Windows.Forms.Timer sayac;
        private TreeView treeViewBekleyenIslemler;
        private TreeView treeViewGecmisIslemler;
    }
}