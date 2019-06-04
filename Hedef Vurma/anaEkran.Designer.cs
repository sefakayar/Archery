namespace Hedef_Vurma
{
    partial class anaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaEkran));
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btYardim = new System.Windows.Forms.Button();
            this.btOyna = new System.Windows.Forms.Button();
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
            this.label4.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-4, -10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(916, 20);
            this.label2.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(899, -2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 366);
            this.label7.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-1, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 366);
            this.label5.TabIndex = 51;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(170, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(600, 225);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogo.TabIndex = 60;
            this.pbLogo.TabStop = false;
            // 
            // btYardim
            // 
            this.btYardim.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold);
            this.btYardim.Location = new System.Drawing.Point(347, 226);
            this.btYardim.Name = "btYardim";
            this.btYardim.Size = new System.Drawing.Size(194, 51);
            this.btYardim.TabIndex = 63;
            this.btYardim.Text = "Nasıl Oynanır ?";
            this.btYardim.UseVisualStyleBackColor = true;
            this.btYardim.Click += new System.EventHandler(this.btYardim_Click);
            // 
            // btOyna
            // 
            this.btOyna.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold);
            this.btOyna.Location = new System.Drawing.Point(347, 160);
            this.btOyna.Name = "btOyna";
            this.btOyna.Size = new System.Drawing.Size(194, 51);
            this.btOyna.TabIndex = 62;
            this.btOyna.Text = "Oyna";
            this.btOyna.UseVisualStyleBackColor = true;
            this.btOyna.Click += new System.EventHandler(this.btOyna_Click);
            // 
            // btCik
            // 
            this.btCik.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold);
            this.btCik.Location = new System.Drawing.Point(347, 292);
            this.btCik.Name = "btCik";
            this.btCik.Size = new System.Drawing.Size(194, 51);
            this.btCik.TabIndex = 61;
            this.btCik.Text = "Çık";
            this.btCik.UseVisualStyleBackColor = true;
            this.btCik.Click += new System.EventHandler(this.btCik_Click);
            // 
            // anaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(909, 371);
            this.Controls.Add(this.btYardim);
            this.Controls.Add(this.btOyna);
            this.Controls.Add(this.btCik);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Name = "anaEkran";
            this.Text = "Ana Ekran";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btYardim;
        private System.Windows.Forms.Button btOyna;
        private System.Windows.Forms.Button btCik;
    }
}

