namespace NYP_Arsiv_Otomasyonu
{
    partial class personelEkle
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AdSoyadTxt = new System.Windows.Forms.Label();
            this.sifreTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(236, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 22);
            this.textBox2.TabIndex = 1;
            // 
            // AdSoyadTxt
            // 
            this.AdSoyadTxt.AutoSize = true;
            this.AdSoyadTxt.Location = new System.Drawing.Point(162, 72);
            this.AdSoyadTxt.Name = "AdSoyadTxt";
            this.AdSoyadTxt.Size = new System.Drawing.Size(67, 16);
            this.AdSoyadTxt.TabIndex = 2;
            this.AdSoyadTxt.Text = "Ad Soyad";
            this.AdSoyadTxt.Click += new System.EventHandler(this.label1_Click);
            // 
            // sifreTxt
            // 
            this.sifreTxt.AutoSize = true;
            this.sifreTxt.Location = new System.Drawing.Point(162, 121);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.Size = new System.Drawing.Size(34, 16);
            this.sifreTxt.TabIndex = 3;
            this.sifreTxt.Text = "Şifre";
            // 
            // personelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.AdSoyadTxt);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "personelEkle";
            this.Text = "personelEklecs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label AdSoyadTxt;
        private System.Windows.Forms.Label sifreTxt;
    }
}