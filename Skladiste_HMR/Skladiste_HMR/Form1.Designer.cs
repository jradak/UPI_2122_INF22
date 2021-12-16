namespace Skladiste_HMR
{
    partial class Form1
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
            this.lblPrijava = new System.Windows.Forms.Label();
            this.lblkIme = new System.Windows.Forms.Label();
            this.tbKIme = new System.Windows.Forms.TextBox();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrijava
            // 
            this.lblPrijava.AutoSize = true;
            this.lblPrijava.Font = new System.Drawing.Font("Calibri", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrijava.ForeColor = System.Drawing.Color.Black;
            this.lblPrijava.Location = new System.Drawing.Point(12, 41);
            this.lblPrijava.Name = "lblPrijava";
            this.lblPrijava.Size = new System.Drawing.Size(175, 64);
            this.lblPrijava.TabIndex = 0;
            this.lblPrijava.Text = "Prijava";
            // 
            // lblkIme
            // 
            this.lblkIme.AutoSize = true;
            this.lblkIme.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkIme.ForeColor = System.Drawing.Color.Black;
            this.lblkIme.Location = new System.Drawing.Point(18, 148);
            this.lblkIme.Name = "lblkIme";
            this.lblkIme.Size = new System.Drawing.Size(161, 29);
            this.lblkIme.TabIndex = 1;
            this.lblkIme.Text = "Korisničko ime:";
            // 
            // tbKIme
            // 
            this.tbKIme.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKIme.ForeColor = System.Drawing.Color.DimGray;
            this.tbKIme.Location = new System.Drawing.Point(23, 180);
            this.tbKIme.Name = "tbKIme";
            this.tbKIme.Size = new System.Drawing.Size(424, 37);
            this.tbKIme.TabIndex = 2;
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLozinka.ForeColor = System.Drawing.Color.Black;
            this.lblLozinka.Location = new System.Drawing.Point(18, 252);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(93, 29);
            this.lblLozinka.TabIndex = 3;
            this.lblLozinka.Text = "Lozinka:";
            this.lblLozinka.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbLozinka
            // 
            this.tbLozinka.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLozinka.ForeColor = System.Drawing.Color.DimGray;
            this.tbLozinka.Location = new System.Drawing.Point(23, 284);
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.Size = new System.Drawing.Size(424, 37);
            this.tbLozinka.TabIndex = 4;
            this.tbLozinka.UseSystemPasswordChar = true;
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.Color.Salmon;
            this.btnPrijava.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijava.ForeColor = System.Drawing.Color.White;
            this.btnPrijava.Location = new System.Drawing.Point(23, 405);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(424, 75);
            this.btnPrijava.TabIndex = 5;
            this.btnPrijava.Tag = "";
            this.btnPrijava.Text = "Prijavi se";
            this.btnPrijava.UseVisualStyleBackColor = false;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 503);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.tbLozinka);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.tbKIme);
            this.Controls.Add(this.lblkIme);
            this.Controls.Add(this.lblPrijava);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skladište";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrijava;
        private System.Windows.Forms.Label lblkIme;
        private System.Windows.Forms.TextBox tbKIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.Button btnPrijava;
    }
}

