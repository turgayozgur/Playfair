namespace Playfair
{
    partial class frmPlayfair
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
            this.lblAnahtar = new System.Windows.Forms.Label();
            this.txtAnahtar = new System.Windows.Forms.TextBox();
            this.lblMatris = new System.Windows.Forms.Label();
            this.txtMatris = new System.Windows.Forms.TextBox();
            this.lblGirdiMetni = new System.Windows.Forms.Label();
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.gbMetinler = new System.Windows.Forms.GroupBox();
            this.cbTemizle = new System.Windows.Forms.CheckBox();
            this.lblGirdiMetniSay = new System.Windows.Forms.Label();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnDesifrele = new System.Windows.Forms.Button();
            this.btnSifrele = new System.Windows.Forms.Button();
            this.lblSonucMetini = new System.Windows.Forms.Label();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.gbAnahtar = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnahtarUret = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbMetinler.SuspendLayout();
            this.gbAnahtar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAnahtar
            // 
            this.lblAnahtar.AutoSize = true;
            this.lblAnahtar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnahtar.Location = new System.Drawing.Point(455, 18);
            this.lblAnahtar.Name = "lblAnahtar";
            this.lblAnahtar.Size = new System.Drawing.Size(81, 17);
            this.lblAnahtar.TabIndex = 0;
            this.lblAnahtar.Text = "Anahtar Gir";
            // 
            // txtAnahtar
            // 
            this.txtAnahtar.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtAnahtar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAnahtar.Location = new System.Drawing.Point(458, 51);
            this.txtAnahtar.Multiline = true;
            this.txtAnahtar.Name = "txtAnahtar";
            this.txtAnahtar.Size = new System.Drawing.Size(256, 68);
            this.txtAnahtar.TabIndex = 0;
            this.txtAnahtar.TextChanged += new System.EventHandler(this.txtAnahtar_TextChanged);
            // 
            // lblMatris
            // 
            this.lblMatris.AutoSize = true;
            this.lblMatris.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatris.Location = new System.Drawing.Point(6, 18);
            this.lblMatris.Name = "lblMatris";
            this.lblMatris.Size = new System.Drawing.Size(104, 17);
            this.lblMatris.TabIndex = 2;
            this.lblMatris.Text = "Anahtar Matrisi";
            // 
            // txtMatris
            // 
            this.txtMatris.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtMatris.Enabled = false;
            this.txtMatris.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatris.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMatris.Location = new System.Drawing.Point(6, 51);
            this.txtMatris.Multiline = true;
            this.txtMatris.Name = "txtMatris";
            this.txtMatris.Size = new System.Drawing.Size(435, 270);
            this.txtMatris.TabIndex = 3;
            // 
            // lblGirdiMetni
            // 
            this.lblGirdiMetni.AutoSize = true;
            this.lblGirdiMetni.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirdiMetni.Location = new System.Drawing.Point(6, 19);
            this.lblGirdiMetni.Name = "lblGirdiMetni";
            this.lblGirdiMetni.Size = new System.Drawing.Size(76, 17);
            this.lblGirdiMetni.TabIndex = 4;
            this.lblGirdiMetni.Text = "Girdi Metni";
            // 
            // txtMetin
            // 
            this.txtMetin.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtMetin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMetin.Location = new System.Drawing.Point(9, 43);
            this.txtMetin.MaxLength = 199;
            this.txtMetin.Multiline = true;
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(286, 117);
            this.txtMetin.TabIndex = 1;
            this.txtMetin.TextChanged += new System.EventHandler(this.txtMetin_TextChanged);
            // 
            // gbMetinler
            // 
            this.gbMetinler.Controls.Add(this.cbTemizle);
            this.gbMetinler.Controls.Add(this.lblGirdiMetniSay);
            this.gbMetinler.Controls.Add(this.btnDegistir);
            this.gbMetinler.Controls.Add(this.btnDesifrele);
            this.gbMetinler.Controls.Add(this.btnSifrele);
            this.gbMetinler.Controls.Add(this.lblSonucMetini);
            this.gbMetinler.Controls.Add(this.txtSonuc);
            this.gbMetinler.Controls.Add(this.lblGirdiMetni);
            this.gbMetinler.Controls.Add(this.txtMetin);
            this.gbMetinler.Location = new System.Drawing.Point(12, 352);
            this.gbMetinler.Name = "gbMetinler";
            this.gbMetinler.Size = new System.Drawing.Size(725, 218);
            this.gbMetinler.TabIndex = 40;
            this.gbMetinler.TabStop = false;
            // 
            // cbTemizle
            // 
            this.cbTemizle.AutoSize = true;
            this.cbTemizle.Checked = true;
            this.cbTemizle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTemizle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbTemizle.Location = new System.Drawing.Point(9, 184);
            this.cbTemizle.Name = "cbTemizle";
            this.cbTemizle.Size = new System.Drawing.Size(492, 21);
            this.cbTemizle.TabIndex = 11;
            this.cbTemizle.Text = "Deşifrelenen metinde, Türkçe\'de olmayan karakterleri (\'q\',\'w\',\'x\') temizle.";
            this.cbTemizle.UseVisualStyleBackColor = true;
            // 
            // lblGirdiMetniSay
            // 
            this.lblGirdiMetniSay.AutoSize = true;
            this.lblGirdiMetniSay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirdiMetniSay.Location = new System.Drawing.Point(262, 163);
            this.lblGirdiMetniSay.Name = "lblGirdiMetniSay";
            this.lblGirdiMetniSay.Size = new System.Drawing.Size(33, 13);
            this.lblGirdiMetniSay.TabIndex = 10;
            this.lblGirdiMetniSay.Text = "(199)";
            // 
            // btnDegistir
            // 
            this.btnDegistir.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDegistir.Location = new System.Drawing.Point(340, 134);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(42, 26);
            this.btnDegistir.TabIndex = 4;
            this.btnDegistir.Text = "<";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnDesifrele
            // 
            this.btnDesifrele.Enabled = false;
            this.btnDesifrele.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDesifrele.Location = new System.Drawing.Point(321, 83);
            this.btnDesifrele.Name = "btnDesifrele";
            this.btnDesifrele.Size = new System.Drawing.Size(82, 34);
            this.btnDesifrele.TabIndex = 3;
            this.btnDesifrele.Text = "Deşifrele";
            this.btnDesifrele.UseVisualStyleBackColor = true;
            this.btnDesifrele.Click += new System.EventHandler(this.btnDesifrele_Click);
            // 
            // btnSifrele
            // 
            this.btnSifrele.Enabled = false;
            this.btnSifrele.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifrele.Location = new System.Drawing.Point(321, 43);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(82, 34);
            this.btnSifrele.TabIndex = 2;
            this.btnSifrele.Text = "Şifrele";
            this.btnSifrele.UseVisualStyleBackColor = true;
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // lblSonucMetini
            // 
            this.lblSonucMetini.AutoSize = true;
            this.lblSonucMetini.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonucMetini.Location = new System.Drawing.Point(430, 19);
            this.lblSonucMetini.Name = "lblSonucMetini";
            this.lblSonucMetini.Size = new System.Drawing.Size(74, 17);
            this.lblSonucMetini.TabIndex = 6;
            this.lblSonucMetini.Text = "Çıktı Metni";
            // 
            // txtSonuc
            // 
            this.txtSonuc.Enabled = false;
            this.txtSonuc.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSonuc.Location = new System.Drawing.Point(433, 43);
            this.txtSonuc.MaxLength = 399;
            this.txtSonuc.Multiline = true;
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(286, 117);
            this.txtSonuc.TabIndex = 5;
            // 
            // gbAnahtar
            // 
            this.gbAnahtar.Controls.Add(this.label4);
            this.gbAnahtar.Controls.Add(this.label3);
            this.gbAnahtar.Controls.Add(this.label2);
            this.gbAnahtar.Controls.Add(this.lblMatris);
            this.gbAnahtar.Controls.Add(this.txtAnahtar);
            this.gbAnahtar.Controls.Add(this.btnAnahtarUret);
            this.gbAnahtar.Controls.Add(this.lblAnahtar);
            this.gbAnahtar.Controls.Add(this.txtMatris);
            this.gbAnahtar.Controls.Add(this.label1);
            this.gbAnahtar.Location = new System.Drawing.Point(12, 12);
            this.gbAnahtar.Name = "gbAnahtar";
            this.gbAnahtar.Size = new System.Drawing.Size(725, 334);
            this.gbAnahtar.TabIndex = 30;
            this.gbAnahtar.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(455, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "(Rasgele oluşturmak için rasgele anahtarı tıklayın.)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(455, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "(Anahtar matrisi girilen metne göre oluşur.)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(455, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Karakter Kümesi:";
            // 
            // btnAnahtarUret
            // 
            this.btnAnahtarUret.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnahtarUret.Location = new System.Drawing.Point(458, 286);
            this.btnAnahtarUret.Name = "btnAnahtarUret";
            this.btnAnahtarUret.Size = new System.Drawing.Size(136, 35);
            this.btnAnahtarUret.TabIndex = 5;
            this.btnAnahtarUret.Text = "Rasgele Anahtar";
            this.btnAnahtarUret.UseVisualStyleBackColor = true;
            this.btnAnahtarUret.Click += new System.EventHandler(this.btnAnahtarUret_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(455, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "\"a - z \", \'q\' , \'w\' , \'x\' , \'.\' , \',\' , \':\' , \' \'";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(586, 581);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 14);
            this.label5.TabIndex = 41;
            this.label5.Text = "Turgay ÖZGÜR - 2090203334";
            // 
            // frmPlayfair
            // 
            this.AcceptButton = this.btnSifrele;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 604);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbAnahtar);
            this.Controls.Add(this.gbMetinler);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPlayfair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Playfair";
            this.Load += new System.EventHandler(this.frmPlayfair_Load);
            this.gbMetinler.ResumeLayout(false);
            this.gbMetinler.PerformLayout();
            this.gbAnahtar.ResumeLayout(false);
            this.gbAnahtar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnahtar;
        private System.Windows.Forms.TextBox txtAnahtar;
        private System.Windows.Forms.Label lblMatris;
        private System.Windows.Forms.Label lblGirdiMetni;
        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.GroupBox gbMetinler;
        private System.Windows.Forms.Label lblSonucMetini;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.GroupBox gbAnahtar;
        private System.Windows.Forms.Button btnSifrele;
        private System.Windows.Forms.Button btnDesifrele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatris;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Label lblGirdiMetniSay;
        private System.Windows.Forms.Button btnAnahtarUret;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbTemizle;
        private System.Windows.Forms.Label label5;
    }
}

