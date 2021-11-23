namespace Skladiste_HMR
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btnOdjava = new System.Windows.Forms.Button();
            this.lblKorIme = new System.Windows.Forms.Label();
            this.lblInfoOPrijavi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Sjena1 = new System.Windows.Forms.PictureBox();
            this.lblInfoKorR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sjena1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.Color.White;
            this.btnOdjava.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjava.ForeColor = System.Drawing.Color.Salmon;
            this.btnOdjava.Location = new System.Drawing.Point(591, 94);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(161, 41);
            this.btnOdjava.TabIndex = 11;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // lblKorIme
            // 
            this.lblKorIme.AutoSize = true;
            this.lblKorIme.BackColor = System.Drawing.Color.Transparent;
            this.lblKorIme.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorIme.ForeColor = System.Drawing.Color.White;
            this.lblKorIme.Location = new System.Drawing.Point(645, 67);
            this.lblKorIme.Name = "lblKorIme";
            this.lblKorIme.Size = new System.Drawing.Size(59, 24);
            this.lblKorIme.TabIndex = 10;
            this.lblKorIme.Text = "@ime";
            // 
            // lblInfoOPrijavi
            // 
            this.lblInfoOPrijavi.AutoSize = true;
            this.lblInfoOPrijavi.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoOPrijavi.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoOPrijavi.ForeColor = System.Drawing.Color.White;
            this.lblInfoOPrijavi.Location = new System.Drawing.Point(587, 34);
            this.lblInfoOPrijavi.Name = "lblInfoOPrijavi";
            this.lblInfoOPrijavi.Size = new System.Drawing.Size(165, 24);
            this.lblInfoOPrijavi.TabIndex = 9;
            this.lblInfoOPrijavi.Text = "Prijavljeni ste kao:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(388, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // Sjena1
            // 
            this.Sjena1.BackColor = System.Drawing.Color.Transparent;
            this.Sjena1.Image = ((System.Drawing.Image)(resources.GetObject("Sjena1.Image")));
            this.Sjena1.Location = new System.Drawing.Point(373, 193);
            this.Sjena1.Name = "Sjena1";
            this.Sjena1.Size = new System.Drawing.Size(190, 334);
            this.Sjena1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sjena1.TabIndex = 13;
            this.Sjena1.TabStop = false;
            this.Sjena1.Visible = false;
            // 
            // lblInfoKorR
            // 
            this.lblInfoKorR.AutoSize = true;
            this.lblInfoKorR.BackColor = System.Drawing.Color.White;
            this.lblInfoKorR.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoKorR.ForeColor = System.Drawing.Color.DimGray;
            this.lblInfoKorR.Location = new System.Drawing.Point(380, 459);
            this.lblInfoKorR.Name = "lblInfoKorR";
            this.lblInfoKorR.Size = new System.Drawing.Size(178, 29);
            this.lblInfoKorR.TabIndex = 14;
            this.lblInfoKorR.Text = "Korisnički računi";
            this.lblInfoKorR.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(926, 562);
            this.Controls.Add(this.lblInfoKorR);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Sjena1);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.lblKorIme);
            this.Controls.Add(this.lblInfoOPrijavi);
            this.DoubleBuffered = true;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sjena1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Label lblKorIme;
        private System.Windows.Forms.Label lblInfoOPrijavi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Sjena1;
        private System.Windows.Forms.Label lblInfoKorR;
    }
}