namespace NYP_Arsiv_Otomasyonu
{
    partial class eklearsiv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eklearsiv));
            this.evrakAdi = new System.Windows.Forms.Label();
            this.evrakBırakmaTarihi = new System.Windows.Forms.Label();
            this.evrakKodu = new System.Windows.Forms.Label();
            this.evrakaditxt = new System.Windows.Forms.TextBox();
            this.evrakkodutxt = new System.Windows.Forms.TextBox();
            this.evrakEkleButton = new System.Windows.Forms.Button();
            this.unvancombobox = new System.Windows.Forms.ComboBox();
            this.unvan = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.personelEkleTxt = new System.Windows.Forms.Label();
            this.personelEkleButton = new System.Windows.Forms.PictureBox();
            this.profilTxt = new System.Windows.Forms.Label();
            this.teslimBilgileriTxt = new System.Windows.Forms.Label();
            this.arsivTxt = new System.Windows.Forms.Label();
            this.ajandaTxt = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.profilButton = new System.Windows.Forms.PictureBox();
            this.teslimBilgileriButton = new System.Windows.Forms.PictureBox();
            this.arsivButton = new System.Windows.Forms.PictureBox();
            this.ajandaButton = new System.Windows.Forms.PictureBox();
            this.evrakbırakmadate = new System.Windows.Forms.DateTimePicker();
            this.eklearsivdata = new System.Windows.Forms.DataGridView();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.saatTxt = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelEkleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teslimBilgileriButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsivButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajandaButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eklearsivdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // evrakAdi
            // 
            this.evrakAdi.AutoSize = true;
            this.evrakAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.evrakAdi.ForeColor = System.Drawing.Color.White;
            this.evrakAdi.Location = new System.Drawing.Point(113, 27);
            this.evrakAdi.Name = "evrakAdi";
            this.evrakAdi.Size = new System.Drawing.Size(89, 18);
            this.evrakAdi.TabIndex = 0;
            this.evrakAdi.Text = "Evrak Adı :";
            // 
            // evrakBırakmaTarihi
            // 
            this.evrakBırakmaTarihi.AutoSize = true;
            this.evrakBırakmaTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.evrakBırakmaTarihi.ForeColor = System.Drawing.Color.White;
            this.evrakBırakmaTarihi.Location = new System.Drawing.Point(113, 65);
            this.evrakBırakmaTarihi.Name = "evrakBırakmaTarihi";
            this.evrakBırakmaTarihi.Size = new System.Drawing.Size(118, 36);
            this.evrakBırakmaTarihi.TabIndex = 1;
            this.evrakBırakmaTarihi.Text = "Evrak Bırakma\r\n      Tarihi :";
            // 
            // evrakKodu
            // 
            this.evrakKodu.AutoSize = true;
            this.evrakKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.evrakKodu.ForeColor = System.Drawing.Color.White;
            this.evrakKodu.Location = new System.Drawing.Point(113, 116);
            this.evrakKodu.Name = "evrakKodu";
            this.evrakKodu.Size = new System.Drawing.Size(105, 18);
            this.evrakKodu.TabIndex = 2;
            this.evrakKodu.Text = "Evrak Kodu :";
            // 
            // evrakaditxt
            // 
            this.evrakaditxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.evrakaditxt.Location = new System.Drawing.Point(251, 21);
            this.evrakaditxt.Name = "evrakaditxt";
            this.evrakaditxt.Size = new System.Drawing.Size(267, 24);
            this.evrakaditxt.TabIndex = 3;
            this.evrakaditxt.TextChanged += new System.EventHandler(this.evrakAdiTxt_TextChanged);
            // 
            // evrakkodutxt
            // 
            this.evrakkodutxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.evrakkodutxt.ForeColor = System.Drawing.Color.White;
            this.evrakkodutxt.Location = new System.Drawing.Point(251, 116);
            this.evrakkodutxt.Name = "evrakkodutxt";
            this.evrakkodutxt.Size = new System.Drawing.Size(267, 24);
            this.evrakkodutxt.TabIndex = 4;
            // 
            // evrakEkleButton
            // 
            this.evrakEkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.evrakEkleButton.Location = new System.Drawing.Point(571, 81);
            this.evrakEkleButton.Name = "evrakEkleButton";
            this.evrakEkleButton.Size = new System.Drawing.Size(142, 39);
            this.evrakEkleButton.TabIndex = 6;
            this.evrakEkleButton.Text = "Evrak Ekle";
            this.evrakEkleButton.UseVisualStyleBackColor = true;
            this.evrakEkleButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // unvancombobox
            // 
            this.unvancombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.unvancombobox.ForeColor = System.Drawing.Color.White;
            this.unvancombobox.FormattingEnabled = true;
            this.unvancombobox.Items.AddRange(new object[] {
            "Admin ",
            "Öğrenci işleri",
            "Bölüm Sekreteri"});
            this.unvancombobox.Location = new System.Drawing.Point(251, 157);
            this.unvancombobox.Name = "unvancombobox";
            this.unvancombobox.Size = new System.Drawing.Size(267, 26);
            this.unvancombobox.TabIndex = 7;
            // 
            // unvan
            // 
            this.unvan.AutoSize = true;
            this.unvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.unvan.ForeColor = System.Drawing.Color.White;
            this.unvan.Location = new System.Drawing.Point(113, 157);
            this.unvan.Name = "unvan";
            this.unvan.Size = new System.Drawing.Size(65, 18);
            this.unvan.TabIndex = 8;
            this.unvan.Text = "Unvan :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-2, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 544);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // personelEkleTxt
            // 
            this.personelEkleTxt.AutoSize = true;
            this.personelEkleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelEkleTxt.ForeColor = System.Drawing.Color.White;
            this.personelEkleTxt.Location = new System.Drawing.Point(14, 335);
            this.personelEkleTxt.Name = "personelEkleTxt";
            this.personelEkleTxt.Size = new System.Drawing.Size(75, 36);
            this.personelEkleTxt.TabIndex = 36;
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
            this.personelEkleButton.TabIndex = 35;
            this.personelEkleButton.TabStop = false;
            this.personelEkleButton.Visible = false;
            this.personelEkleButton.Click += new System.EventHandler(this.personelEkleButton_Click);
            // 
            // profilTxt
            // 
            this.profilTxt.AutoSize = true;
            this.profilTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.profilTxt.ForeColor = System.Drawing.Color.White;
            this.profilTxt.Location = new System.Drawing.Point(19, 463);
            this.profilTxt.Name = "profilTxt";
            this.profilTxt.Size = new System.Drawing.Size(48, 18);
            this.profilTxt.TabIndex = 34;
            this.profilTxt.Text = "Profil";
            this.profilTxt.Click += new System.EventHandler(this.profilTxt_Click);
            // 
            // teslimBilgileriTxt
            // 
            this.teslimBilgileriTxt.AutoSize = true;
            this.teslimBilgileriTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teslimBilgileriTxt.ForeColor = System.Drawing.Color.White;
            this.teslimBilgileriTxt.Location = new System.Drawing.Point(8, 229);
            this.teslimBilgileriTxt.Name = "teslimBilgileriTxt";
            this.teslimBilgileriTxt.Size = new System.Drawing.Size(68, 36);
            this.teslimBilgileriTxt.TabIndex = 33;
            this.teslimBilgileriTxt.Text = " Teslim \r\nBilgileri";
            this.teslimBilgileriTxt.Click += new System.EventHandler(this.teslimBilgileriTxt_Click);
            // 
            // arsivTxt
            // 
            this.arsivTxt.AutoSize = true;
            this.arsivTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arsivTxt.ForeColor = System.Drawing.Color.White;
            this.arsivTxt.Location = new System.Drawing.Point(23, 143);
            this.arsivTxt.Name = "arsivTxt";
            this.arsivTxt.Size = new System.Drawing.Size(45, 18);
            this.arsivTxt.TabIndex = 32;
            this.arsivTxt.Text = "Arşiv";
            // 
            // ajandaTxt
            // 
            this.ajandaTxt.AutoSize = true;
            this.ajandaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ajandaTxt.ForeColor = System.Drawing.Color.White;
            this.ajandaTxt.Location = new System.Drawing.Point(14, 65);
            this.ajandaTxt.Name = "ajandaTxt";
            this.ajandaTxt.Size = new System.Drawing.Size(58, 18);
            this.ajandaTxt.TabIndex = 31;
            this.ajandaTxt.Text = "Ajanda";
            this.ajandaTxt.Click += new System.EventHandler(this.ajandaTxt_Click);
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(28, 493);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(35, 35);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitButton.TabIndex = 30;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // profilButton
            // 
            this.profilButton.Image = ((System.Drawing.Image)(resources.GetObject("profilButton.Image")));
            this.profilButton.Location = new System.Drawing.Point(22, 410);
            this.profilButton.Name = "profilButton";
            this.profilButton.Size = new System.Drawing.Size(50, 50);
            this.profilButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilButton.TabIndex = 29;
            this.profilButton.TabStop = false;
            this.profilButton.Click += new System.EventHandler(this.profilButton_Click);
            // 
            // teslimBilgileriButton
            // 
            this.teslimBilgileriButton.Image = ((System.Drawing.Image)(resources.GetObject("teslimBilgileriButton.Image")));
            this.teslimBilgileriButton.Location = new System.Drawing.Point(22, 176);
            this.teslimBilgileriButton.Name = "teslimBilgileriButton";
            this.teslimBilgileriButton.Size = new System.Drawing.Size(50, 50);
            this.teslimBilgileriButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.teslimBilgileriButton.TabIndex = 28;
            this.teslimBilgileriButton.TabStop = false;
            this.teslimBilgileriButton.Click += new System.EventHandler(this.teslimBilgileriButton_Click);
            // 
            // arsivButton
            // 
            this.arsivButton.Image = ((System.Drawing.Image)(resources.GetObject("arsivButton.Image")));
            this.arsivButton.Location = new System.Drawing.Point(22, 94);
            this.arsivButton.Name = "arsivButton";
            this.arsivButton.Size = new System.Drawing.Size(50, 50);
            this.arsivButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arsivButton.TabIndex = 27;
            this.arsivButton.TabStop = false;
            this.arsivButton.Click += new System.EventHandler(this.arsivButton_Click);
            // 
            // ajandaButton
            // 
            this.ajandaButton.Image = ((System.Drawing.Image)(resources.GetObject("ajandaButton.Image")));
            this.ajandaButton.Location = new System.Drawing.Point(22, 12);
            this.ajandaButton.Name = "ajandaButton";
            this.ajandaButton.Size = new System.Drawing.Size(50, 50);
            this.ajandaButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ajandaButton.TabIndex = 26;
            this.ajandaButton.TabStop = false;
            this.ajandaButton.Click += new System.EventHandler(this.ajandaButton_Click);
            // 
            // evrakbırakmadate
            // 
            this.evrakbırakmadate.CalendarForeColor = System.Drawing.Color.White;
            this.evrakbırakmadate.CalendarTitleBackColor = System.Drawing.Color.White;
            this.evrakbırakmadate.CalendarTitleForeColor = System.Drawing.Color.White;
            this.evrakbırakmadate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.evrakbırakmadate.Location = new System.Drawing.Point(251, 65);
            this.evrakbırakmadate.Name = "evrakbırakmadate";
            this.evrakbırakmadate.Size = new System.Drawing.Size(267, 24);
            this.evrakbırakmadate.TabIndex = 37;
            // 
            // eklearsivdata
            // 
            this.eklearsivdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eklearsivdata.Location = new System.Drawing.Point(106, 207);
            this.eklearsivdata.Name = "eklearsivdata";
            this.eklearsivdata.RowHeadersWidth = 51;
            this.eklearsivdata.RowTemplate.Height = 24;
            this.eklearsivdata.Size = new System.Drawing.Size(873, 321);
            this.eklearsivdata.TabIndex = 38;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(836, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 47;
            this.pictureBox6.TabStop = false;
            // 
            // saatTxt
            // 
            this.saatTxt.AutoSize = true;
            this.saatTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saatTxt.ForeColor = System.Drawing.Color.White;
            this.saatTxt.Location = new System.Drawing.Point(874, 19);
            this.saatTxt.Name = "saatTxt";
            this.saatTxt.Size = new System.Drawing.Size(59, 20);
            this.saatTxt.TabIndex = 46;
            this.saatTxt.Text = "label1";
            // 
            // eklearsiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 540);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.saatTxt);
            this.Controls.Add(this.eklearsivdata);
            this.Controls.Add(this.evrakbırakmadate);
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
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.unvan);
            this.Controls.Add(this.unvancombobox);
            this.Controls.Add(this.evrakEkleButton);
            this.Controls.Add(this.evrakkodutxt);
            this.Controls.Add(this.evrakaditxt);
            this.Controls.Add(this.evrakKodu);
            this.Controls.Add(this.evrakBırakmaTarihi);
            this.Controls.Add(this.evrakAdi);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "eklearsiv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eklearsiv";
            this.Load += new System.EventHandler(this.eklearsiv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelEkleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teslimBilgileriButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsivButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajandaButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eklearsivdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label evrakAdi;
        private System.Windows.Forms.Label evrakBırakmaTarihi;
        private System.Windows.Forms.Label evrakKodu;
        private System.Windows.Forms.TextBox evrakaditxt;
        private System.Windows.Forms.TextBox evrakkodutxt;
        private System.Windows.Forms.Button evrakEkleButton;
        private System.Windows.Forms.ComboBox unvancombobox;
        private System.Windows.Forms.Label unvan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label personelEkleTxt;
        private System.Windows.Forms.PictureBox personelEkleButton;
        private System.Windows.Forms.Label profilTxt;
        private System.Windows.Forms.Label teslimBilgileriTxt;
        private System.Windows.Forms.Label arsivTxt;
        private System.Windows.Forms.Label ajandaTxt;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.PictureBox profilButton;
        private System.Windows.Forms.PictureBox teslimBilgileriButton;
        private System.Windows.Forms.PictureBox arsivButton;
        private System.Windows.Forms.PictureBox ajandaButton;
        private System.Windows.Forms.DateTimePicker evrakbırakmadate;
        private System.Windows.Forms.DataGridView eklearsivdata;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label saatTxt;
        private System.Windows.Forms.Timer timer1;
    }
}