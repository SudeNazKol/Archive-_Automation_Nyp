﻿namespace NYP_Arsiv_Otomasyonu
{
    partial class GirisSayfası
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisSayfası));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adSoyadTxt = new System.Windows.Forms.TextBox();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.adminRadioButton = new System.Windows.Forms.RadioButton();
            this.personelRadioButton = new System.Windows.Forms.RadioButton();
            this.girisButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.bilgiButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgiButton)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(406, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // adSoyadTxt
            // 
            this.adSoyadTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adSoyadTxt.ForeColor = System.Drawing.Color.White;
            this.adSoyadTxt.Location = new System.Drawing.Point(411, 256);
            this.adSoyadTxt.Multiline = true;
            this.adSoyadTxt.Name = "adSoyadTxt";
            this.adSoyadTxt.Size = new System.Drawing.Size(219, 37);
            this.adSoyadTxt.TabIndex = 5;
            this.adSoyadTxt.Tag = "";
            this.adSoyadTxt.Text = "Kullanıcı Adı";
            this.adSoyadTxt.TextChanged += new System.EventHandler(this.adSoyadTxt_TextChanged);
            this.adSoyadTxt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.adSoyadTxt_MouseDown);
            // 
            // sifreTxt
            // 
            this.sifreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTxt.ForeColor = System.Drawing.Color.White;
            this.sifreTxt.Location = new System.Drawing.Point(411, 301);
            this.sifreTxt.Multiline = true;
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.Size = new System.Drawing.Size(219, 35);
            this.sifreTxt.TabIndex = 6;
            this.sifreTxt.Text = "Şifre";
            this.sifreTxt.TextChanged += new System.EventHandler(this.sifreTxt_TextChanged);
            this.sifreTxt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sifreTxt_MouseDown);
            // 
            // adminRadioButton
            // 
            this.adminRadioButton.AutoSize = true;
            this.adminRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminRadioButton.ForeColor = System.Drawing.Color.White;
            this.adminRadioButton.Location = new System.Drawing.Point(411, 355);
            this.adminRadioButton.Name = "adminRadioButton";
            this.adminRadioButton.Size = new System.Drawing.Size(86, 26);
            this.adminRadioButton.TabIndex = 7;
            this.adminRadioButton.TabStop = true;
            this.adminRadioButton.Text = "Admin";
            this.adminRadioButton.UseVisualStyleBackColor = true;
            this.adminRadioButton.CheckedChanged += new System.EventHandler(this.adminRadioButton_CheckedChanged);
            // 
            // personelRadioButton
            // 
            this.personelRadioButton.AutoSize = true;
            this.personelRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelRadioButton.ForeColor = System.Drawing.Color.White;
            this.personelRadioButton.Location = new System.Drawing.Point(520, 355);
            this.personelRadioButton.Name = "personelRadioButton";
            this.personelRadioButton.Size = new System.Drawing.Size(110, 26);
            this.personelRadioButton.TabIndex = 8;
            this.personelRadioButton.TabStop = true;
            this.personelRadioButton.Text = "Personel";
            this.personelRadioButton.UseVisualStyleBackColor = true;
            this.personelRadioButton.CheckedChanged += new System.EventHandler(this.ogrenciIsleriRadioButton_CheckedChanged);
            // 
            // girisButton
            // 
            this.girisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisButton.ForeColor = System.Drawing.Color.Black;
            this.girisButton.Location = new System.Drawing.Point(411, 398);
            this.girisButton.Name = "girisButton";
            this.girisButton.Size = new System.Drawing.Size(219, 52);
            this.girisButton.TabIndex = 10;
            this.girisButton.Text = "GİRİŞ";
            this.girisButton.UseVisualStyleBackColor = true;
            this.girisButton.Click += new System.EventHandler(this.girisButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(370, 301);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(370, 258);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // bilgiButton
            // 
            this.bilgiButton.Image = ((System.Drawing.Image)(resources.GetObject("bilgiButton.Image")));
            this.bilgiButton.Location = new System.Drawing.Point(952, 498);
            this.bilgiButton.Name = "bilgiButton";
            this.bilgiButton.Size = new System.Drawing.Size(30, 30);
            this.bilgiButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bilgiButton.TabIndex = 13;
            this.bilgiButton.TabStop = false;
            this.bilgiButton.Click += new System.EventHandler(this.bilgiButton_Click);
            // 
            // GirisSayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 540);
            this.Controls.Add(this.bilgiButton);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.girisButton);
            this.Controls.Add(this.personelRadioButton);
            this.Controls.Add(this.adminRadioButton);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.adSoyadTxt);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GirisSayfası";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arşiv Otomasyonu";
            this.Load += new System.EventHandler(this.GirisSayfası_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgiButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox adSoyadTxt;
        private System.Windows.Forms.TextBox sifreTxt;
        private System.Windows.Forms.RadioButton adminRadioButton;
        private System.Windows.Forms.RadioButton personelRadioButton;
        private System.Windows.Forms.Button girisButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox bilgiButton;
    }
}