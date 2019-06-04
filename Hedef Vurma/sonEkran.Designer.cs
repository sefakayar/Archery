namespace Hedef_Vurma
{
    partial class sonEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sonEkran));
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btiletisim = new System.Windows.Forms.Button();
            this.btYeniden = new System.Windows.Forms.Button();
            this.btCik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-4, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(916, 20);
            this.label4.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-4, -10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(916, 20);
            this.label2.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(899, -2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 366);
            this.label7.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-1, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 366);
            this.label5.TabIndex = 57;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(168, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(600, 225);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogo.TabIndex = 67;
            this.pbLogo.TabStop = false;
            // 
            // btiletisim
            // 
            this.btiletisim.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold);
            this.btiletisim.Location = new System.Drawing.Point(346, 225);
            this.btiletisim.Name = "btiletisim";
            this.btiletisim.Size = new System.Drawing.Size(194, 51);
            this.btiletisim.TabIndex = 70;
            this.btiletisim.Text = "İletişim";
            this.btiletisim.UseVisualStyleBackColor = true;
            this.btiletisim.Click += new System.EventHandler(this.btiletisim_Click);
            // 
            // btYeniden
            // 
            this.btYeniden.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold);
            this.btYeniden.Location = new System.Drawing.Point(346, 159);
            this.btYeniden.Name = "btYeniden";
            this.btYeniden.Size = new System.Drawing.Size(194, 51);
            this.btYeniden.TabIndex = 69;
            this.btYeniden.Text = "Yeniden Oyna !";
            this.btYeniden.UseVisualStyleBackColor = true;
            this.btYeniden.Click += new System.EventHandler(this.btYeniden_Click);
            // 
            // btCik
            // 
            this.btCik.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold);
            this.btCik.Location = new System.Drawing.Point(346, 291);
            this.btCik.Name = "btCik";
            this.btCik.Size = new System.Drawing.Size(194, 51);
            this.btCik.TabIndex = 68;
            this.btCik.Text = "Çık";
            this.btCik.UseVisualStyleBackColor = true;
            this.btCik.Click += new System.EventHandler(this.btCik_Click);
            // 
            // sonEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(909, 371);
            this.Controls.Add(this.btiletisim);
            this.Controls.Add(this.btYeniden);
            this.Controls.Add(this.btCik);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Name = "sonEkran";
            this.Text = "Son Ekran";
            this.Load += new System.EventHandler(this.sonEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btiletisim;
        private System.Windows.Forms.Button btYeniden;
        private System.Windows.Forms.Button btCik;
    }
}