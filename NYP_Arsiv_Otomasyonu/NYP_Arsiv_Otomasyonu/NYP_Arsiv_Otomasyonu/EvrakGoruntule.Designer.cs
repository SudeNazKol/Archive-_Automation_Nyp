namespace NYP_Arsiv_Otomasyonu
{
    partial class EvrakGoruntule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvrakGoruntule));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.evraklistelemedata = new System.Windows.Forms.DataGridView();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.saatTxt = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.aratxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personelEkleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teslimBilgileriButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsivButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajandaButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evraklistelemedata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // personelEkleTxt
            // 
            this.personelEkleTxt.AutoSize = true;
            this.personelEkleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelEkleTxt.ForeColor = System.Drawing.Color.White;
            this.personelEkleTxt.Location = new System.Drawing.Point(14, 335);
            this.personelEkleTxt.Name = "personelEkleTxt";
            this.personelEkleTxt.Size = new System.Drawing.Size(75, 36);
            this.personelEkleTxt.TabIndex = 48;
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
            this.personelEkleButton.TabIndex = 47;
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
            this.profilTxt.TabIndex = 46;
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
            this.teslimBilgileriTxt.TabIndex = 45;
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
            this.arsivTxt.TabIndex = 44;
            this.arsivTxt.Text = "Arşiv";
            this.arsivTxt.Click += new System.EventHandler(this.arsivTxt_Click);
            // 
            // ajandaTxt
            // 
            this.ajandaTxt.AutoSize = true;
            this.ajandaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ajandaTxt.ForeColor = System.Drawing.Color.White;
            this.ajandaTxt.Location = new System.Drawing.Point(14, 65);
            this.ajandaTxt.Name = "ajandaTxt";
            this.ajandaTxt.Size = new System.Drawing.Size(58, 18);
            this.ajandaTxt.TabIndex = 43;
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
            this.exitButton.TabIndex = 42;
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
            this.profilButton.TabIndex = 41;
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
            this.teslimBilgileriButton.TabIndex = 40;
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
            this.arsivButton.TabIndex = 39;
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
            this.ajandaButton.TabIndex = 38;
            this.ajandaButton.TabStop = false;
            this.ajandaButton.Click += new System.EventHandler(this.ajandaButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 544);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // evraklistelemedata
            // 
            this.evraklistelemedata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.evraklistelemedata.Location = new System.Drawing.Point(106, 54);
            this.evraklistelemedata.Name = "evraklistelemedata";
            this.evraklistelemedata.RowHeadersWidth = 51;
            this.evraklistelemedata.RowTemplate.Height = 24;
            this.evraklistelemedata.Size = new System.Drawing.Size(873, 474);
            this.evraklistelemedata.TabIndex = 49;
            this.evraklistelemedata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.evraklistelemedata_CellContentClick);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(836, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 51;
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
            this.saatTxt.TabIndex = 50;
            this.saatTxt.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(106, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 56;
            this.pictureBox4.TabStop = false;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(544, 6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(95, 31);
            this.searchButton.TabIndex = 55;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // aratxt
            // 
            this.aratxt.Location = new System.Drawing.Point(144, 6);
            this.aratxt.Multiline = true;
            this.aratxt.Name = "aratxt";
            this.aratxt.Size = new System.Drawing.Size(394, 31);
            this.aratxt.TabIndex = 54;
            this.aratxt.TextChanged += new System.EventHandler(this.aratxt_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(645, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 57;
            this.label1.Text = "Kayıt Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(727, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 58;
            // 
            // EvrakGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 540);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.aratxt);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.saatTxt);
            this.Controls.Add(this.evraklistelemedata);
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
            this.Name = "EvrakGoruntule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EvrakGoruntule";
            this.Load += new System.EventHandler(this.EvrakGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personelEkleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teslimBilgileriButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsivButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajandaButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evraklistelemedata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView evraklistelemedata;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label saatTxt;
        private System.Windows.Forms.Timer timer1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox aratxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}