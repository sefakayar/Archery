namespace Hedef_Vurma
{
    partial class oyunEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oyunEkrani));
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbHak = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSkor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmOk = new System.Windows.Forms.Timer(this.components);
            this.pbHedef = new System.Windows.Forms.PictureBox();
            this.timerAssagi = new System.Windows.Forms.Timer(this.components);
            this.timerYukari = new System.Windows.Forms.Timer(this.components);
            this.labelx = new System.Windows.Forms.Label();
            this.labely = new System.Windows.Forms.Label();
            this.pbOk = new System.Windows.Forms.PictureBox();
            this.pbAdam = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHedef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdam)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-4, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(916, 20);
            this.label4.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-4, -10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(916, 20);
            this.label2.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(899, -2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 366);
            this.label7.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-1, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 366);
            this.label5.TabIndex = 51;
            // 
            // lbHak
            // 
            this.lbHak.AutoSize = true;
            this.lbHak.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHak.Location = new System.Drawing.Point(72, 47);
            this.lbHak.Name = "lbHak";
            this.lbHak.Size = new System.Drawing.Size(24, 23);
            this.lbHak.TabIndex = 50;
            this.lbHak.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 49;
            this.label3.Text = "Hak :";
            // 
            // lbSkor
            // 
            this.lbSkor.AutoSize = true;
            this.lbSkor.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSkor.Location = new System.Drawing.Point(74, 21);
            this.lbSkor.Name = "lbSkor";
            this.lbSkor.Size = new System.Drawing.Size(22, 23);
            this.lbSkor.TabIndex = 48;
            this.lbSkor.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 47;
            this.label1.Text = "Skor :";
            // 
            // tmOk
            // 
            this.tmOk.Interval = 10;
            this.tmOk.Tick += new System.EventHandler(this.tmOk_Tick);
            // 
            // pbHedef
            // 
            this.pbHedef.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pbHedef.Image = ((System.Drawing.Image)(resources.GetObject("pbHedef.Image")));
            this.pbHedef.Location = new System.Drawing.Point(800, 10);
            this.pbHedef.Name = "pbHedef";
            this.pbHedef.Size = new System.Drawing.Size(85, 80);
            this.pbHedef.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHedef.TabIndex = 62;
            this.pbHedef.TabStop = false;
            // 
            // timerAssagi
            // 
            this.timerAssagi.Interval = 150;
            this.timerAssagi.Tick += new System.EventHandler(this.timerAssagi_Tick);
            // 
            // timerYukari
            // 
            this.timerYukari.Interval = 150;
            this.timerYukari.Tick += new System.EventHandler(this.timerYukari_Tick);
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.Font = new System.Drawing.Font("Ink Free", 8F, System.Drawing.FontStyle.Bold);
            this.labelx.Location = new System.Drawing.Point(16, 313);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(14, 14);
            this.labelx.TabIndex = 64;
            this.labelx.Text = "0";
            this.labelx.Click += new System.EventHandler(this.labelx_Click);
            // 
            // labely
            // 
            this.labely.AutoSize = true;
            this.labely.Font = new System.Drawing.Font("Ink Free", 8F, System.Drawing.FontStyle.Bold);
            this.labely.Location = new System.Drawing.Point(16, 347);
            this.labely.Name = "labely";
            this.labely.Size = new System.Drawing.Size(14, 14);
            this.labely.TabIndex = 65;
            this.labely.Text = "0";
            // 
            // pbOk
            // 
            this.pbOk.Image = ((System.Drawing.Image)(resources.GetObject("pbOk.Image")));
            this.pbOk.Location = new System.Drawing.Point(135, 165);
            this.pbOk.Name = "pbOk";
            this.pbOk.Size = new System.Drawing.Size(55, 45);
            this.pbOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOk.TabIndex = 69;
            this.pbOk.TabStop = false;
            // 
            // pbAdam
            // 
            this.pbAdam.Image = ((System.Drawing.Image)(resources.GetObject("pbAdam.Image")));
            this.pbAdam.Location = new System.Drawing.Point(135, 132);
            this.pbAdam.Name = "pbAdam";
            this.pbAdam.Size = new System.Drawing.Size(95, 89);
            this.pbAdam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdam.TabIndex = 70;
            this.pbAdam.TabStop = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(236, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 366);
            this.label8.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(119, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 366);
            this.label6.TabIndex = 52;
            // 
            // oyunEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(909, 372);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pbAdam);
            this.Controls.Add(this.pbOk);
            this.Controls.Add(this.labely);
            this.Controls.Add(this.labelx);
            this.Controls.Add(this.pbHedef);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbHak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbSkor);
            this.Controls.Add(this.label1);
            this.Name = "oyunEkrani";
            this.Text = "oyunEkrani";
            this.Load += new System.EventHandler(this.oyunEkrani_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.oyunEkrani_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.oyunEkrani_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbHedef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbHak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSkor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmOk;
        private System.Windows.Forms.PictureBox pbHedef;
        private System.Windows.Forms.Timer timerAssagi;
        private System.Windows.Forms.Timer timerYukari;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.Label labely;
        private System.Windows.Forms.PictureBox pbOk;
        private System.Windows.Forms.PictureBox pbAdam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
    }
}