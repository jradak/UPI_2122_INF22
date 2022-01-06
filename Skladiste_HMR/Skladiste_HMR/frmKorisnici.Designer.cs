namespace Skladiste_HMR
{
    partial class frmKorisnici
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBrisiKor = new System.Windows.Forms.Button();
            this.btnUrediKor = new System.Windows.Forms.Button();
            this.btnDodajKor = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.btnSpremiKor = new System.Windows.Forms.Button();
            this.btnPromijeniKor = new System.Windows.Forms.Button();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblKorIme = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblUloga = new System.Windows.Forms.Label();
            this.cmbBoxUloga = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(51, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(994, 331);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // btnBrisiKor
            // 
            this.btnBrisiKor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrisiKor.ForeColor = System.Drawing.Color.Salmon;
            this.btnBrisiKor.Location = new System.Drawing.Point(297, 412);
            this.btnBrisiKor.Name = "btnBrisiKor";
            this.btnBrisiKor.Size = new System.Drawing.Size(130, 58);
            this.btnBrisiKor.TabIndex = 1;
            this.btnBrisiKor.Text = "BRIŠI";
            this.btnBrisiKor.UseVisualStyleBackColor = true;
            this.btnBrisiKor.Click += new System.EventHandler(this.btnBrisiKor_Click);
            // 
            // btnUrediKor
            // 
            this.btnUrediKor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrediKor.ForeColor = System.Drawing.Color.Salmon;
            this.btnUrediKor.Location = new System.Drawing.Point(668, 412);
            this.btnUrediKor.Name = "btnUrediKor";
            this.btnUrediKor.Size = new System.Drawing.Size(130, 58);
            this.btnUrediKor.TabIndex = 2;
            this.btnUrediKor.Text = "UREDI";
            this.btnUrediKor.UseVisualStyleBackColor = true;
            this.btnUrediKor.Click += new System.EventHandler(this.btnUrediKor_Click);
            // 
            // btnDodajKor
            // 
            this.btnDodajKor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajKor.ForeColor = System.Drawing.Color.Salmon;
            this.btnDodajKor.Location = new System.Drawing.Point(483, 412);
            this.btnDodajKor.Name = "btnDodajKor";
            this.btnDodajKor.Size = new System.Drawing.Size(130, 58);
            this.btnDodajKor.TabIndex = 3;
            this.btnDodajKor.Text = "DODAJ";
            this.btnDodajKor.UseVisualStyleBackColor = true;
            this.btnDodajKor.Click += new System.EventHandler(this.btnDodajKor_Click);
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.ForeColor = System.Drawing.Color.DimGray;
            this.txtIme.Location = new System.Drawing.Point(404, 511);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(210, 37);
            this.txtIme.TabIndex = 4;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezime.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrezime.Location = new System.Drawing.Point(404, 554);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(210, 37);
            this.txtPrezime.TabIndex = 5;
            // 
            // txtKorIme
            // 
            this.txtKorIme.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKorIme.ForeColor = System.Drawing.Color.DimGray;
            this.txtKorIme.Location = new System.Drawing.Point(404, 597);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(210, 37);
            this.txtKorIme.TabIndex = 6;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLozinka.ForeColor = System.Drawing.Color.DimGray;
            this.txtLozinka.Location = new System.Drawing.Point(404, 640);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(210, 37);
            this.txtLozinka.TabIndex = 7;
            // 
            // btnSpremiKor
            // 
            this.btnSpremiKor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremiKor.ForeColor = System.Drawing.Color.Salmon;
            this.btnSpremiKor.Location = new System.Drawing.Point(678, 585);
            this.btnSpremiKor.Name = "btnSpremiKor";
            this.btnSpremiKor.Size = new System.Drawing.Size(136, 58);
            this.btnSpremiKor.TabIndex = 9;
            this.btnSpremiKor.Text = "SPREMI";
            this.btnSpremiKor.UseVisualStyleBackColor = true;
            this.btnSpremiKor.Click += new System.EventHandler(this.btnSpremiKor_Click);
            // 
            // btnPromijeniKor
            // 
            this.btnPromijeniKor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromijeniKor.ForeColor = System.Drawing.Color.Salmon;
            this.btnPromijeniKor.Location = new System.Drawing.Point(678, 585);
            this.btnPromijeniKor.Name = "btnPromijeniKor";
            this.btnPromijeniKor.Size = new System.Drawing.Size(148, 58);
            this.btnPromijeniKor.TabIndex = 10;
            this.btnPromijeniKor.Text = "PROMIJENI";
            this.btnPromijeniKor.UseVisualStyleBackColor = true;
            this.btnPromijeniKor.Click += new System.EventHandler(this.btnPromijeniKor_Click);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(320, 514);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(57, 29);
            this.lblIme.TabIndex = 11;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.Location = new System.Drawing.Point(276, 557);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(100, 29);
            this.lblPrezime.TabIndex = 12;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblKorIme
            // 
            this.lblKorIme.AutoSize = true;
            this.lblKorIme.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorIme.Location = new System.Drawing.Point(212, 600);
            this.lblKorIme.Name = "lblKorIme";
            this.lblKorIme.Size = new System.Drawing.Size(164, 29);
            this.lblKorIme.TabIndex = 13;
            this.lblKorIme.Text = "Korisničko ime:";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLozinka.Location = new System.Drawing.Point(280, 643);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(96, 29);
            this.lblLozinka.TabIndex = 14;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // lblUloga
            // 
            this.lblUloga.AutoSize = true;
            this.lblUloga.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUloga.Location = new System.Drawing.Point(296, 686);
            this.lblUloga.Name = "lblUloga";
            this.lblUloga.Size = new System.Drawing.Size(81, 29);
            this.lblUloga.TabIndex = 15;
            this.lblUloga.Text = "Uloga:";
            // 
            // cmbBoxUloga
            // 
            this.cmbBoxUloga.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxUloga.FormattingEnabled = true;
            this.cmbBoxUloga.Items.AddRange(new object[] {
            "admin",
            "poslovoda",
            "radnik"});
            this.cmbBoxUloga.Location = new System.Drawing.Point(404, 683);
            this.cmbBoxUloga.Name = "cmbBoxUloga";
            this.cmbBoxUloga.Size = new System.Drawing.Size(210, 37);
            this.cmbBoxUloga.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 751);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 17;
            // 
            // frmKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1102, 780);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxUloga);
            this.Controls.Add(this.lblUloga);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorIme);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.btnPromijeniKor);
            this.Controls.Add(this.btnSpremiKor);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorIme);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.btnDodajKor);
            this.Controls.Add(this.btnUrediKor);
            this.Controls.Add(this.btnBrisiKor);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmKorisnici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Korisnici";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBrisiKor;
        private System.Windows.Forms.Button btnUrediKor;
        private System.Windows.Forms.Button btnDodajKor;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Button btnSpremiKor;
        private System.Windows.Forms.Button btnPromijeniKor;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblKorIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblUloga;
        private System.Windows.Forms.ComboBox cmbBoxUloga;
        private System.Windows.Forms.Label label1;
    }
}