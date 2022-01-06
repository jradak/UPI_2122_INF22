namespace Skladiste_HMR
{
    partial class frmPlaner
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
            this.lblDatum = new System.Windows.Forms.Label();
            this.btnDodajNar = new System.Windows.Forms.Button();
            this.btnBrisiNar = new System.Windows.Forms.Button();
            this.dataGridViewNar = new System.Windows.Forms.DataGridView();
            this.datumNar = new System.Windows.Forms.DateTimePicker();
            this.btnSpremiDodaj = new System.Windows.Forms.Button();
            this.dataGridViewIsp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIsp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(86, 478);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(88, 29);
            this.lblDatum.TabIndex = 31;
            this.lblDatum.Text = "Datum:";
            // 
            // btnDodajNar
            // 
            this.btnDodajNar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNar.ForeColor = System.Drawing.Color.Salmon;
            this.btnDodajNar.Location = new System.Drawing.Point(292, 383);
            this.btnDodajNar.Name = "btnDodajNar";
            this.btnDodajNar.Size = new System.Drawing.Size(146, 58);
            this.btnDodajNar.TabIndex = 20;
            this.btnDodajNar.Text = "DODAJ";
            this.btnDodajNar.UseVisualStyleBackColor = true;
            this.btnDodajNar.Click += new System.EventHandler(this.btnDodajNar_Click);
            // 
            // btnBrisiNar
            // 
            this.btnBrisiNar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrisiNar.ForeColor = System.Drawing.Color.Salmon;
            this.btnBrisiNar.Location = new System.Drawing.Point(29, 383);
            this.btnBrisiNar.Name = "btnBrisiNar";
            this.btnBrisiNar.Size = new System.Drawing.Size(146, 58);
            this.btnBrisiNar.TabIndex = 18;
            this.btnBrisiNar.Text = "BRIŠI";
            this.btnBrisiNar.UseVisualStyleBackColor = true;
            this.btnBrisiNar.Click += new System.EventHandler(this.btnBrisiNar_Click);
            // 
            // dataGridViewNar
            // 
            this.dataGridViewNar.AllowUserToAddRows = false;
            this.dataGridViewNar.AllowUserToDeleteRows = false;
            this.dataGridViewNar.AllowUserToResizeColumns = false;
            this.dataGridViewNar.AllowUserToResizeRows = false;
            this.dataGridViewNar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewNar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNar.Location = new System.Drawing.Point(29, 25);
            this.dataGridViewNar.Name = "dataGridViewNar";
            this.dataGridViewNar.ReadOnly = true;
            this.dataGridViewNar.RowHeadersWidth = 62;
            this.dataGridViewNar.RowTemplate.Height = 28;
            this.dataGridViewNar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNar.Size = new System.Drawing.Size(409, 331);
            this.dataGridViewNar.TabIndex = 17;
            this.dataGridViewNar.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewNar_RowHeaderMouseClick);
            this.dataGridViewNar.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewNar_RowHeaderMouseDoubleClick);
            // 
            // datumNar
            // 
            this.datumNar.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datumNar.CalendarMonthBackground = System.Drawing.Color.White;
            this.datumNar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datumNar.Location = new System.Drawing.Point(226, 472);
            this.datumNar.Name = "datumNar";
            this.datumNar.Size = new System.Drawing.Size(212, 37);
            this.datumNar.TabIndex = 33;
            // 
            // btnSpremiDodaj
            // 
            this.btnSpremiDodaj.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremiDodaj.ForeColor = System.Drawing.Color.Salmon;
            this.btnSpremiDodaj.Location = new System.Drawing.Point(226, 551);
            this.btnSpremiDodaj.Name = "btnSpremiDodaj";
            this.btnSpremiDodaj.Size = new System.Drawing.Size(212, 71);
            this.btnSpremiDodaj.TabIndex = 34;
            this.btnSpremiDodaj.Text = "SPREMI I DODAJ";
            this.btnSpremiDodaj.UseVisualStyleBackColor = true;
            this.btnSpremiDodaj.Click += new System.EventHandler(this.btnSpremiDodaj_Click);
            // 
            // dataGridViewIsp
            // 
            this.dataGridViewIsp.AllowUserToAddRows = false;
            this.dataGridViewIsp.AllowUserToDeleteRows = false;
            this.dataGridViewIsp.AllowUserToResizeColumns = false;
            this.dataGridViewIsp.AllowUserToResizeRows = false;
            this.dataGridViewIsp.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewIsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIsp.Location = new System.Drawing.Point(472, 25);
            this.dataGridViewIsp.Name = "dataGridViewIsp";
            this.dataGridViewIsp.ReadOnly = true;
            this.dataGridViewIsp.RowHeadersWidth = 62;
            this.dataGridViewIsp.RowTemplate.Height = 28;
            this.dataGridViewIsp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewIsp.Size = new System.Drawing.Size(768, 331);
            this.dataGridViewIsp.TabIndex = 35;
            // 
            // frmPlaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1295, 655);
            this.Controls.Add(this.dataGridViewIsp);
            this.Controls.Add(this.btnSpremiDodaj);
            this.Controls.Add(this.datumNar);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.btnDodajNar);
            this.Controls.Add(this.btnBrisiNar);
            this.Controls.Add(this.dataGridViewNar);
            this.Name = "frmPlaner";
            this.Text = "Planer";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Button btnDodajNar;
        private System.Windows.Forms.Button btnBrisiNar;
        private System.Windows.Forms.DataGridView dataGridViewNar;
        private System.Windows.Forms.DateTimePicker datumNar;
        private System.Windows.Forms.Button btnSpremiDodaj;
        private System.Windows.Forms.DataGridView dataGridViewIsp;
    }
}