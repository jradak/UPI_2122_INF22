namespace Skladiste_HMR
{
    partial class frmSkladiste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSkladiste));
            this.btnGotoveIsporuke = new System.Windows.Forms.Button();
            this.btnUrediSkladiste = new System.Windows.Forms.Button();
            this.btnPrimjeni = new System.Windows.Forms.Button();
            this.cmbBoxSektor = new System.Windows.Forms.ComboBox();
            this.lblSektor = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.numericKolicina = new System.Windows.Forms.NumericUpDown();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnNedefinirani = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSektorE = new System.Windows.Forms.Button();
            this.btnSektorD = new System.Windows.Forms.Button();
            this.btnSektorC = new System.Windows.Forms.Button();
            this.btnSektorB = new System.Windows.Forms.Button();
            this.btnSektorA = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericKolicina)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGotoveIsporuke
            // 
            this.btnGotoveIsporuke.Location = new System.Drawing.Point(33, 486);
            this.btnGotoveIsporuke.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGotoveIsporuke.Name = "btnGotoveIsporuke";
            this.btnGotoveIsporuke.Size = new System.Drawing.Size(266, 47);
            this.btnGotoveIsporuke.TabIndex = 47;
            this.btnGotoveIsporuke.Text = "gotove isporuke";
            this.btnGotoveIsporuke.UseVisualStyleBackColor = true;
            this.btnGotoveIsporuke.Click += new System.EventHandler(this.btnGotoveIsporuke_Click);
            // 
            // btnUrediSkladiste
            // 
            this.btnUrediSkladiste.BackColor = System.Drawing.Color.Transparent;
            this.btnUrediSkladiste.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUrediSkladiste.BackgroundImage")));
            this.btnUrediSkladiste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUrediSkladiste.Location = new System.Drawing.Point(305, 213);
            this.btnUrediSkladiste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUrediSkladiste.Name = "btnUrediSkladiste";
            this.btnUrediSkladiste.Size = new System.Drawing.Size(21, 20);
            this.btnUrediSkladiste.TabIndex = 46;
            this.btnUrediSkladiste.UseVisualStyleBackColor = false;
            this.btnUrediSkladiste.Click += new System.EventHandler(this.btnUrediSkladiste_Click);
            // 
            // btnPrimjeni
            // 
            this.btnPrimjeni.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimjeni.ForeColor = System.Drawing.Color.Salmon;
            this.btnPrimjeni.Location = new System.Drawing.Point(564, 439);
            this.btnPrimjeni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrimjeni.Name = "btnPrimjeni";
            this.btnPrimjeni.Size = new System.Drawing.Size(87, 38);
            this.btnPrimjeni.TabIndex = 45;
            this.btnPrimjeni.Text = "PRIMJENI";
            this.btnPrimjeni.UseVisualStyleBackColor = true;
            this.btnPrimjeni.Click += new System.EventHandler(this.btnPrimjeni_Click);
            // 
            // cmbBoxSektor
            // 
            this.cmbBoxSektor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxSektor.FormattingEnabled = true;
            this.cmbBoxSektor.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "nesvrstani"});
            this.cmbBoxSektor.Location = new System.Drawing.Point(486, 389);
            this.cmbBoxSektor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBoxSektor.Name = "cmbBoxSektor";
            this.cmbBoxSektor.Size = new System.Drawing.Size(167, 27);
            this.cmbBoxSektor.TabIndex = 44;
            // 
            // lblSektor
            // 
            this.lblSektor.AutoSize = true;
            this.lblSektor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSektor.Location = new System.Drawing.Point(414, 391);
            this.lblSektor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSektor.Name = "lblSektor";
            this.lblSektor.Size = new System.Drawing.Size(58, 19);
            this.lblSektor.TabIndex = 43;
            this.lblSektor.Text = "Sektor:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(486, 343);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(167, 27);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(414, 347);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(59, 19);
            this.lblDatum.TabIndex = 41;
            this.lblDatum.Text = "Datum:";
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKolicina.Location = new System.Drawing.Point(407, 306);
            this.lblKolicina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(67, 19);
            this.lblKolicina.TabIndex = 40;
            this.lblKolicina.Text = "Količina:";
            // 
            // numericKolicina
            // 
            this.numericKolicina.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericKolicina.Location = new System.Drawing.Point(486, 305);
            this.numericKolicina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericKolicina.Name = "numericKolicina";
            this.numericKolicina.Size = new System.Drawing.Size(165, 27);
            this.numericKolicina.TabIndex = 39;
            // 
            // btnUredi
            // 
            this.btnUredi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUredi.ForeColor = System.Drawing.Color.Salmon;
            this.btnUredi.Location = new System.Drawing.Point(564, 224);
            this.btnUredi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(87, 38);
            this.btnUredi.TabIndex = 37;
            this.btnUredi.Text = "UREDI";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnNedefinirani
            // 
            this.btnNedefinirani.Location = new System.Drawing.Point(33, 430);
            this.btnNedefinirani.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNedefinirani.Name = "btnNedefinirani";
            this.btnNedefinirani.Size = new System.Drawing.Size(266, 47);
            this.btnNedefinirani.TabIndex = 36;
            this.btnNedefinirani.Text = "nesvrstani";
            this.btnNedefinirani.UseVisualStyleBackColor = true;
            this.btnNedefinirani.Click += new System.EventHandler(this.btnNedefinirani_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSektorE);
            this.panel1.Controls.Add(this.btnSektorD);
            this.panel1.Controls.Add(this.btnSektorC);
            this.panel1.Controls.Add(this.btnSektorB);
            this.panel1.Controls.Add(this.btnSektorA);
            this.panel1.Location = new System.Drawing.Point(31, 213);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 213);
            this.panel1.TabIndex = 35;
            // 
            // btnSektorE
            // 
            this.btnSektorE.Location = new System.Drawing.Point(180, 153);
            this.btnSektorE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSektorE.Name = "btnSektorE";
            this.btnSektorE.Size = new System.Drawing.Size(88, 58);
            this.btnSektorE.TabIndex = 4;
            this.btnSektorE.Text = "E";
            this.btnSektorE.UseVisualStyleBackColor = true;
            this.btnSektorE.Click += new System.EventHandler(this.btnSektorE_Click);
            // 
            // btnSektorD
            // 
            this.btnSektorD.Location = new System.Drawing.Point(92, 153);
            this.btnSektorD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSektorD.Name = "btnSektorD";
            this.btnSektorD.Size = new System.Drawing.Size(84, 58);
            this.btnSektorD.TabIndex = 3;
            this.btnSektorD.Text = "D";
            this.btnSektorD.UseVisualStyleBackColor = true;
            this.btnSektorD.Click += new System.EventHandler(this.btnSektorD_Click);
            // 
            // btnSektorC
            // 
            this.btnSektorC.Location = new System.Drawing.Point(2, 153);
            this.btnSektorC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSektorC.Name = "btnSektorC";
            this.btnSektorC.Size = new System.Drawing.Size(86, 58);
            this.btnSektorC.TabIndex = 2;
            this.btnSektorC.Text = "C";
            this.btnSektorC.UseVisualStyleBackColor = true;
            this.btnSektorC.Click += new System.EventHandler(this.btnSektorC_Click);
            // 
            // btnSektorB
            // 
            this.btnSektorB.Location = new System.Drawing.Point(107, 2);
            this.btnSektorB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSektorB.Name = "btnSektorB";
            this.btnSektorB.Size = new System.Drawing.Size(161, 58);
            this.btnSektorB.TabIndex = 1;
            this.btnSektorB.Text = "B";
            this.btnSektorB.UseVisualStyleBackColor = true;
            this.btnSektorB.Click += new System.EventHandler(this.btnSektorB_Click);
            // 
            // btnSektorA
            // 
            this.btnSektorA.Location = new System.Drawing.Point(2, 2);
            this.btnSektorA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSektorA.Name = "btnSektorA";
            this.btnSektorA.Size = new System.Drawing.Size(101, 58);
            this.btnSektorA.TabIndex = 0;
            this.btnSektorA.Text = "A";
            this.btnSektorA.UseVisualStyleBackColor = true;
            this.btnSektorA.Click += new System.EventHandler(this.btnSektorA_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 8);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(689, 201);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // frmSkladiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(757, 542);
            this.Controls.Add(this.btnGotoveIsporuke);
            this.Controls.Add(this.btnUrediSkladiste);
            this.Controls.Add(this.btnPrimjeni);
            this.Controls.Add(this.cmbBoxSektor);
            this.Controls.Add(this.lblSektor);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.numericKolicina);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnNedefinirani);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSkladiste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericKolicina)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGotoveIsporuke;
        private System.Windows.Forms.Button btnUrediSkladiste;
        private System.Windows.Forms.Button btnPrimjeni;
        private System.Windows.Forms.ComboBox cmbBoxSektor;
        private System.Windows.Forms.Label lblSektor;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.NumericUpDown numericKolicina;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnNedefinirani;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSektorE;
        private System.Windows.Forms.Button btnSektorD;
        private System.Windows.Forms.Button btnSektorC;
        private System.Windows.Forms.Button btnSektorB;
        private System.Windows.Forms.Button btnSektorA;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}