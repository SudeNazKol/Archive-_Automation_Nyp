﻿namespace NYP_Arsiv_Otomasyonu
{
    partial class anaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaSayfa));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saatTxt = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.notlarTxt = new System.Windows.Forms.Label();
            this.ajandaButton = new System.Windows.Forms.PictureBox();
            this.arsivButton = new System.Windows.Forms.PictureBox();
            this.teslimBilgileriButton = new System.Windows.Forms.PictureBox();
            this.profilButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.ajandaTxt = new System.Windows.Forms.Label();
            this.arsivTxt = new System.Windows.Forms.Label();
            this.teslimBilgileriTxt = new System.Windows.Forms.Label();
            this.profilTxt = new System.Windows.Forms.Label();
            this.personelEkleTxt = new System.Windows.Forms.Label();
            this.personelEkleButton = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.kaydetButton = new System.Windows.Forms.Button();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.PersonelImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajandaButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsivButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teslimBilgileriButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelEkleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 544);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(646, 43);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(106, 43);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(533, 485);
            this.webBrowser1.TabIndex = 4;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(645, 283);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 204);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // saatTxt
            // 
            this.saatTxt.AutoSize = true;
            this.saatTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saatTxt.ForeColor = System.Drawing.Color.White;
            this.saatTxt.Location = new System.Drawing.Point(879, 19);
            this.saatTxt.Name = "saatTxt";
            this.saatTxt.Size = new System.Drawing.Size(59, 20);
            this.saatTxt.TabIndex = 8;
            this.saatTxt.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(836, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 31);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(645, 246);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 31);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // notlarTxt
            // 
            this.notlarTxt.AutoSize = true;
            this.notlarTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.notlarTxt.ForeColor = System.Drawing.Color.White;
            this.notlarTxt.Location = new System.Drawing.Point(683, 252);
            this.notlarTxt.Name = "notlarTxt";
            this.notlarTxt.Size = new System.Drawing.Size(60, 20);
            this.notlarTxt.TabIndex = 13;
            this.notlarTxt.Text = "Notlar";
            // 
            // ajandaButton
            // 
            this.ajandaButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ajandaButton.Image = ((System.Drawing.Image)(resources.GetObject("ajandaButton.Image")));
            this.ajandaButton.Location = new System.Drawing.Point(22, 12);
            this.ajandaButton.Name = "ajandaButton";
            this.ajandaButton.Size = new System.Drawing.Size(50, 50);
            this.ajandaButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ajandaButton.TabIndex = 14;
            this.ajandaButton.TabStop = false;
            this.ajandaButton.Click += new System.EventHandler(this.ajandaButton_Click);
            // 
            // arsivButton
            // 
            this.arsivButton.Image = ((System.Drawing.Image)(resources.GetObject("arsivButton.Image")));
            this.arsivButton.Location = new System.Drawing.Point(22, 94);
            this.arsivButton.Name = "arsivButton";
            this.arsivButton.Size = new System.Drawing.Size(50, 50);
            this.arsivButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arsivButton.TabIndex = 15;
            this.arsivButton.TabStop = false;
            this.arsivButton.Click += new System.EventHandler(this.arsivButton_Click);
            // 
            // teslimBilgileriButton
            // 
            this.teslimBilgileriButton.Image = ((System.Drawing.Image)(resources.GetObject("teslimBilgileriButton.Image")));
            this.teslimBilgileriButton.Location = new System.Drawing.Point(22, 176);
            this.teslimBilgileriButton.Name = "teslimBilgileriButton";
            this.teslimBilgileriButton.Size = new System.Drawing.Size(50, 50);
            this.teslimBilgileriButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.teslimBilgileriButton.TabIndex = 16;
            this.teslimBilgileriButton.TabStop = false;
            this.teslimBilgileriButton.Click += new System.EventHandler(this.teslimBilgileriButton_Click);
            // 
            // profilButton
            // 
            this.profilButton.Image = ((System.Drawing.Image)(resources.GetObject("profilButton.Image")));
            this.profilButton.Location = new System.Drawing.Point(22, 410);
            this.profilButton.Name = "profilButton";
            this.profilButton.Size = new System.Drawing.Size(50, 50);
            this.profilButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilButton.TabIndex = 17;
            this.profilButton.TabStop = false;
            this.profilButton.Click += new System.EventHandler(this.profilButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(28, 493);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(35, 35);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitButton.TabIndex = 18;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ajandaTxt
            // 
            this.ajandaTxt.AutoSize = true;
            this.ajandaTxt.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ajandaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ajandaTxt.ForeColor = System.Drawing.Color.White;
            this.ajandaTxt.Location = new System.Drawing.Point(14, 62);
            this.ajandaTxt.Name = "ajandaTxt";
            this.ajandaTxt.Size = new System.Drawing.Size(58, 18);
            this.ajandaTxt.TabIndex = 19;
            this.ajandaTxt.Text = "Ajanda";
            // 
            // arsivTxt
            // 
            this.arsivTxt.AutoSize = true;
            this.arsivTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arsivTxt.ForeColor = System.Drawing.Color.White;
            this.arsivTxt.Location = new System.Drawing.Point(23, 143);
            this.arsivTxt.Name = "arsivTxt";
            this.arsivTxt.Size = new System.Drawing.Size(45, 18);
            this.arsivTxt.TabIndex = 20;
            this.arsivTxt.Text = "Arşiv";
            this.arsivTxt.Click += new System.EventHandler(this.arsivTxt_Click);
            // 
            // teslimBilgileriTxt
            // 
            this.teslimBilgileriTxt.AutoSize = true;
            this.teslimBilgileriTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teslimBilgileriTxt.ForeColor = System.Drawing.Color.White;
            this.teslimBilgileriTxt.Location = new System.Drawing.Point(8, 229);
            this.teslimBilgileriTxt.Name = "teslimBilgileriTxt";
            this.teslimBilgileriTxt.Size = new System.Drawing.Size(68, 36);
            this.teslimBilgileriTxt.TabIndex = 21;
            this.teslimBilgileriTxt.Text = " Teslim \r\nBilgileri";
            this.teslimBilgileriTxt.Click += new System.EventHandler(this.teslimBilgileriTxt_Click);
            // 
            // profilTxt
            // 
            this.profilTxt.AutoSize = true;
            this.profilTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.profilTxt.ForeColor = System.Drawing.Color.White;
            this.profilTxt.Location = new System.Drawing.Point(19, 463);
            this.profilTxt.Name = "profilTxt";
            this.profilTxt.Size = new System.Drawing.Size(48, 18);
            this.profilTxt.TabIndex = 22;
            this.profilTxt.Text = "Profil";
            this.profilTxt.Click += new System.EventHandler(this.profilTxt_Click);
            // 
            // personelEkleTxt
            // 
            this.personelEkleTxt.AutoSize = true;
            this.personelEkleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelEkleTxt.ForeColor = System.Drawing.Color.White;
            this.personelEkleTxt.Location = new System.Drawing.Point(14, 335);
            this.personelEkleTxt.Name = "personelEkleTxt";
            this.personelEkleTxt.Size = new System.Drawing.Size(75, 36);
            this.personelEkleTxt.TabIndex = 25;
            this.personelEkleTxt.Text = "Personel\r\n   Ekle";
            this.personelEkleTxt.Visible = false;
            this.personelEkleTxt.Click += new System.EventHandler(this.personelEkleTxt_Click);
            // 
            // personelEkleButton
            // 
            this.personelEkleButton.Image = ((System.Drawing.Image)(resources.GetObject("personelEkleButton.Image")));
            this.personelEkleButton.Location = new System.Drawing.Point(22, 282);
            this.personelEkleButton.Name = "personelEkleButton";
            this.personelEkleButton.Size = new System.Drawing.Size(50, 50);
            this.personelEkleButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.personelEkleButton.TabIndex = 24;
            this.personelEkleButton.TabStop = false;
            this.personelEkleButton.Visible = false;
            this.personelEkleButton.Click += new System.EventHandler(this.personelEkleButton_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox7.Location = new System.Drawing.Point(-2, 10);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(102, 78);
            this.pictureBox7.TabIndex = 26;
            this.pictureBox7.TabStop = false;
            // 
            // kaydetButton
            // 
            this.kaydetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetButton.ForeColor = System.Drawing.Color.White;
            this.kaydetButton.Location = new System.Drawing.Point(645, 493);
            this.kaydetButton.Name = "kaydetButton";
            this.kaydetButton.Size = new System.Drawing.Size(314, 34);
            this.kaydetButton.TabIndex = 27;
            this.kaydetButton.Text = "KAYDET";
            this.kaydetButton.UseVisualStyleBackColor = true;
            this.kaydetButton.Click += new System.EventHandler(this.kaydetButton_Click);
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Modern No. 20", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(142, 10);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(73, 25);
            this.lblKullaniciAdi.TabIndex = 28;
            this.lblKullaniciAdi.Text = "label1";
            this.lblKullaniciAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PersonelImage
            // 
            this.PersonelImage.Image = ((System.Drawing.Image)(resources.GetObject("PersonelImage.Image")));
            this.PersonelImage.Location = new System.Drawing.Point(107, 6);
            this.PersonelImage.Name = "PersonelImage";
            this.PersonelImage.Size = new System.Drawing.Size(29, 29);
            this.PersonelImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PersonelImage.TabIndex = 29;
            this.PersonelImage.TabStop = false;
            // 
            // anaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 540);
            this.Controls.Add(this.PersonelImage);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.kaydetButton);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.personelEkleTxt);
            this.Controls.Add(this.personelEkleButton);
            this.Controls.Add(this.profilTxt);
            this.Controls.Add(this.teslimBilgileriTxt);
            this.Controls.Add(this.arsivTxt);
            this.Controls.Add(this.ajandaTxt);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.profilButton);
            this.Controls.Add(this.teslimBilgileriButton);
            this.Controls.Add(this.arsivButton);
            this.Controls.Add(this.ajandaButton);
            this.Controls.Add(this.notlarTxt);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.saatTxt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "anaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.girisSayfası_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajandaButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsivButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teslimBilgileriButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelEkleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label saatTxt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label notlarTxt;
        private System.Windows.Forms.PictureBox ajandaButton;
        private System.Windows.Forms.PictureBox arsivButton;
        private System.Windows.Forms.PictureBox teslimBilgileriButton;
        private System.Windows.Forms.PictureBox profilButton;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.Label ajandaTxt;
        private System.Windows.Forms.Label arsivTxt;
        private System.Windows.Forms.Label teslimBilgileriTxt;
        private System.Windows.Forms.Label profilTxt;
        private System.Windows.Forms.Label personelEkleTxt;
        private System.Windows.Forms.PictureBox personelEkleButton;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button kaydetButton;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.PictureBox PersonelImage;
    }
}

