
namespace Skladiste_HMR
{
    partial class frmIsporuke
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
            this.lblSektor = new System.Windows.Forms.Label();
            this.lblIdNarudzba = new System.Windows.Forms.Label();
            this.btnPromijeniIsp = new System.Windows.Forms.Button();
            this.btnDodajIsp = new System.Windows.Forms.Button();
            this.btnUrediIsp = new System.Windows.Forms.Button();
            this.btnBrisiIsp = new System.Windows.Forms.Button();
            this.dataGridViewIsp = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            this.btnOdaberiPr = new System.Windows.Forms.Button();
            this.lblProizvod = new System.Windows.Forms.Label();
            this.dataGridViewPr = new System.Windows.Forms.DataGridView();
            this.lblKolicinaPr = new System.Windows.Forms.Label();
            this.btnZakljuciNar = new System.Windows.Forms.Button();
            this.btnSpremiIsp = new System.Windows.Forms.Button();
            this.lblIdProizvod = new System.Windows.Forms.Label();
            this.numericKol = new System.Windows.Forms.NumericUpDown();
            this.txtBoxSektor = new System.Windows.Forms.TextBox();
            this.txtBoxProizvod = new System.Windows.Forms.TextBox();
            this.txtBoxNarudzba = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKol)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSektor
            // 
            this.lblSektor.AutoSize = true;
            this.lblSektor.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSektor.Location = new System.Drawing.Point(129, 531);
            this.lblSektor.Name = "lblSektor";
            this.lblSektor.Size = new System.Drawing.Size(89, 29);
            this.lblSektor.TabIndex = 40;
            this.lblSektor.Text = "Sektor: ";
            // 
            // lblIdNarudzba
            // 
            this.lblIdNarudzba.AutoSize = true;
            this.lblIdNarudzba.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdNarudzba.Location = new System.Drawing.Point(68, 485);
            this.lblIdNarudzba.Name = "lblIdNarudzba";
            this.lblIdNarudzba.Size = new System.Drawing.Size(152, 29);
            this.lblIdNarudzba.TabIndex = 39;
            this.lblIdNarudzba.Text = "ID_Narudzba:";
            // 
            // btnPromijeniIsp
            // 
            this.btnPromijeniIsp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromijeniIsp.ForeColor = System.Drawing.Color.Salmon;
            this.btnPromijeniIsp.Location = new System.Drawing.Point(70, 880);
            this.btnPromijeniIsp.Name = "btnPromijeniIsp";
            this.btnPromijeniIsp.Size = new System.Drawing.Size(150, 58);
            this.btnPromijeniIsp.TabIndex = 38;
            this.btnPromijeniIsp.Text = "PROMIJENI";
            this.btnPromijeniIsp.UseVisualStyleBackColor = true;
            this.btnPromijeniIsp.Click += new System.EventHandler(this.btnPromijeniIsp_Click);
            // 
            // btnDodajIsp
            // 
            this.btnDodajIsp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajIsp.ForeColor = System.Drawing.Color.Salmon;
            this.btnDodajIsp.Location = new System.Drawing.Point(489, 383);
            this.btnDodajIsp.Name = "btnDodajIsp";
            this.btnDodajIsp.Size = new System.Drawing.Size(130, 58);
            this.btnDodajIsp.TabIndex = 34;
            this.btnDodajIsp.Text = "DODAJ";
            this.btnDodajIsp.UseVisualStyleBackColor = true;
            this.btnDodajIsp.Click += new System.EventHandler(this.btnDodajIsp_Click);
            // 
            // btnUrediIsp
            // 
            this.btnUrediIsp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrediIsp.ForeColor = System.Drawing.Color.Salmon;
            this.btnUrediIsp.Location = new System.Drawing.Point(674, 383);
            this.btnUrediIsp.Name = "btnUrediIsp";
            this.btnUrediIsp.Size = new System.Drawing.Size(130, 58);
            this.btnUrediIsp.TabIndex = 33;
            this.btnUrediIsp.Text = "UREDI";
            this.btnUrediIsp.UseVisualStyleBackColor = true;
            this.btnUrediIsp.Click += new System.EventHandler(this.btnUrediIsp_Click);
            // 
            // btnBrisiIsp
            // 
            this.btnBrisiIsp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrisiIsp.ForeColor = System.Drawing.Color.Salmon;
            this.btnBrisiIsp.Location = new System.Drawing.Point(303, 383);
            this.btnBrisiIsp.Name = "btnBrisiIsp";
            this.btnBrisiIsp.Size = new System.Drawing.Size(130, 58);
            this.btnBrisiIsp.TabIndex = 32;
            this.btnBrisiIsp.Text = "BRIŠI";
            this.btnBrisiIsp.UseVisualStyleBackColor = true;
            this.btnBrisiIsp.Click += new System.EventHandler(this.btnBrisiIsp_Click);
            // 
            // dataGridViewIsp
            // 
            this.dataGridViewIsp.AllowUserToAddRows = false;
            this.dataGridViewIsp.AllowUserToDeleteRows = false;
            this.dataGridViewIsp.AllowUserToResizeColumns = false;
            this.dataGridViewIsp.AllowUserToResizeRows = false;
            this.dataGridViewIsp.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewIsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIsp.Location = new System.Drawing.Point(70, 29);
            this.dataGridViewIsp.Name = "dataGridViewIsp";
            this.dataGridViewIsp.ReadOnly = true;
            this.dataGridViewIsp.RowHeadersWidth = 62;
            this.dataGridViewIsp.RowTemplate.Height = 28;
            this.dataGridViewIsp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewIsp.Size = new System.Drawing.Size(952, 331);
            this.dataGridViewIsp.TabIndex = 31;
            this.dataGridViewIsp.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewIsp_RowHeaderMouseClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(225, 583);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 37);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(128, 589);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(88, 29);
            this.lblDatum.TabIndex = 43;
            this.lblDatum.Text = "Datum:";
            // 
            // btnOdaberiPr
            // 
            this.btnOdaberiPr.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdaberiPr.ForeColor = System.Drawing.Color.Salmon;
            this.btnOdaberiPr.Location = new System.Drawing.Point(220, 709);
            this.btnOdaberiPr.Name = "btnOdaberiPr";
            this.btnOdaberiPr.Size = new System.Drawing.Size(214, 58);
            this.btnOdaberiPr.TabIndex = 44;
            this.btnOdaberiPr.Text = "ODABERI";
            this.btnOdaberiPr.UseVisualStyleBackColor = true;
            this.btnOdaberiPr.Click += new System.EventHandler(this.btnOdaberiPr_Click);
            // 
            // lblProizvod
            // 
            this.lblProizvod.AutoSize = true;
            this.lblProizvod.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProizvod.Location = new System.Drawing.Point(106, 725);
            this.lblProizvod.Name = "lblProizvod";
            this.lblProizvod.Size = new System.Drawing.Size(107, 29);
            this.lblProizvod.TabIndex = 45;
            this.lblProizvod.Text = "Proizvod:";
            // 
            // dataGridViewPr
            // 
            this.dataGridViewPr.AllowUserToAddRows = false;
            this.dataGridViewPr.AllowUserToDeleteRows = false;
            this.dataGridViewPr.AllowUserToResizeColumns = false;
            this.dataGridViewPr.AllowUserToResizeRows = false;
            this.dataGridViewPr.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPr.Location = new System.Drawing.Point(486, 485);
            this.dataGridViewPr.Name = "dataGridViewPr";
            this.dataGridViewPr.ReadOnly = true;
            this.dataGridViewPr.RowHeadersWidth = 62;
            this.dataGridViewPr.RowTemplate.Height = 28;
            this.dataGridViewPr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPr.Size = new System.Drawing.Size(537, 334);
            this.dataGridViewPr.TabIndex = 46;
            this.dataGridViewPr.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPr_RowHeaderMouseClick);
            // 
            // lblKolicinaPr
            // 
            this.lblKolicinaPr.AutoSize = true;
            this.lblKolicinaPr.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKolicinaPr.Location = new System.Drawing.Point(114, 658);
            this.lblKolicinaPr.Name = "lblKolicinaPr";
            this.lblKolicinaPr.Size = new System.Drawing.Size(100, 29);
            this.lblKolicinaPr.TabIndex = 47;
            this.lblKolicinaPr.Text = "Kolicina:";
            // 
            // btnZakljuciNar
            // 
            this.btnZakljuciNar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZakljuciNar.ForeColor = System.Drawing.Color.Salmon;
            this.btnZakljuciNar.Location = new System.Drawing.Point(768, 880);
            this.btnZakljuciNar.Name = "btnZakljuciNar";
            this.btnZakljuciNar.Size = new System.Drawing.Size(255, 58);
            this.btnZakljuciNar.TabIndex = 49;
            this.btnZakljuciNar.Text = "ZAKLJUČI NARUDŽBU";
            this.btnZakljuciNar.UseVisualStyleBackColor = true;
            this.btnZakljuciNar.Click += new System.EventHandler(this.btnZakljuciNar_Click);
            // 
            // btnSpremiIsp
            // 
            this.btnSpremiIsp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremiIsp.ForeColor = System.Drawing.Color.Salmon;
            this.btnSpremiIsp.Location = new System.Drawing.Point(70, 880);
            this.btnSpremiIsp.Name = "btnSpremiIsp";
            this.btnSpremiIsp.Size = new System.Drawing.Size(150, 58);
            this.btnSpremiIsp.TabIndex = 50;
            this.btnSpremiIsp.Text = "SPREMI";
            this.btnSpremiIsp.UseVisualStyleBackColor = true;
            this.btnSpremiIsp.Click += new System.EventHandler(this.btnSpremiIsp_Click);
            // 
            // lblIdProizvod
            // 
            this.lblIdProizvod.AutoSize = true;
            this.lblIdProizvod.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProizvod.Location = new System.Drawing.Point(81, 792);
            this.lblIdProizvod.Name = "lblIdProizvod";
            this.lblIdProizvod.Size = new System.Drawing.Size(140, 29);
            this.lblIdProizvod.TabIndex = 53;
            this.lblIdProizvod.Text = "ID_Proizvod:";
            // 
            // numericKol
            // 
            this.numericKol.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericKol.Location = new System.Drawing.Point(225, 660);
            this.numericKol.Name = "numericKol";
            this.numericKol.Size = new System.Drawing.Size(208, 37);
            this.numericKol.TabIndex = 55;
            // 
            // txtBoxSektor
            // 
            this.txtBoxSektor.Enabled = false;
            this.txtBoxSektor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSektor.Location = new System.Drawing.Point(225, 528);
            this.txtBoxSektor.Name = "txtBoxSektor";
            this.txtBoxSektor.Size = new System.Drawing.Size(210, 37);
            this.txtBoxSektor.TabIndex = 56;
            this.txtBoxSektor.Text = "nesvrstani";
            // 
            // txtBoxProizvod
            // 
            this.txtBoxProizvod.Enabled = false;
            this.txtBoxProizvod.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxProizvod.Location = new System.Drawing.Point(225, 792);
            this.txtBoxProizvod.Name = "txtBoxProizvod";
            this.txtBoxProizvod.Size = new System.Drawing.Size(210, 37);
            this.txtBoxProizvod.TabIndex = 57;
            // 
            // txtBoxNarudzba
            // 
            this.txtBoxNarudzba.Enabled = false;
            this.txtBoxNarudzba.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNarudzba.Location = new System.Drawing.Point(224, 482);
            this.txtBoxNarudzba.Name = "txtBoxNarudzba";
            this.txtBoxNarudzba.Size = new System.Drawing.Size(210, 37);
            this.txtBoxNarudzba.TabIndex = 58;
            // 
            // frmIsporuke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1089, 962);
            this.Controls.Add(this.txtBoxNarudzba);
            this.Controls.Add(this.txtBoxProizvod);
            this.Controls.Add(this.txtBoxSektor);
            this.Controls.Add(this.numericKol);
            this.Controls.Add(this.lblIdProizvod);
            this.Controls.Add(this.btnSpremiIsp);
            this.Controls.Add(this.btnZakljuciNar);
            this.Controls.Add(this.lblKolicinaPr);
            this.Controls.Add(this.dataGridViewPr);
            this.Controls.Add(this.lblProizvod);
            this.Controls.Add(this.btnOdaberiPr);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblSektor);
            this.Controls.Add(this.lblIdNarudzba);
            this.Controls.Add(this.btnPromijeniIsp);
            this.Controls.Add(this.btnDodajIsp);
            this.Controls.Add(this.btnUrediIsp);
            this.Controls.Add(this.btnBrisiIsp);
            this.Controls.Add(this.dataGridViewIsp);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmIsporuke";
            this.Text = "Isporuke";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSektor;
        private System.Windows.Forms.Label lblIdNarudzba;
        private System.Windows.Forms.Button btnPromijeniIsp;
        private System.Windows.Forms.Button btnDodajIsp;
        private System.Windows.Forms.Button btnUrediIsp;
        private System.Windows.Forms.Button btnBrisiIsp;
        private System.Windows.Forms.DataGridView dataGridViewIsp;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Button btnOdaberiPr;
        private System.Windows.Forms.Label lblProizvod;
        private System.Windows.Forms.DataGridView dataGridViewPr;
        private System.Windows.Forms.Label lblKolicinaPr;
        private System.Windows.Forms.Button btnZakljuciNar;
        private System.Windows.Forms.Button btnSpremiIsp;
        private System.Windows.Forms.Label lblIdProizvod;
        private System.Windows.Forms.NumericUpDown numericKol;
        private System.Windows.Forms.TextBox txtBoxSektor;
        private System.Windows.Forms.TextBox txtBoxProizvod;
        private System.Windows.Forms.TextBox txtBoxNarudzba;
    }
}