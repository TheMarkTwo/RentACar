namespace RentACar.Forms
{
    partial class frmIznajmi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIznajmi));
            this.dgvVozila = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaDan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.lblDo = new System.Windows.Forms.Label();
            this.lblOd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.txtVozilo = new System.Windows.Forms.TextBox();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.btnIznajmi = new System.Windows.Forms.Button();
            this.lblNedostupno = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
            this.lblBrojDana = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVozila
            // 
            this.dgvVozila.AllowUserToAddRows = false;
            this.dgvVozila.AllowUserToDeleteRows = false;
            this.dgvVozila.AllowUserToResizeColumns = false;
            this.dgvVozila.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvVozila.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVozila.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVozila.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvVozila.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVozila.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvVozila.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVozila.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Naziv,
            this.CijenaDan});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVozila.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvVozila.EnableHeadersVisualStyles = false;
            this.dgvVozila.Location = new System.Drawing.Point(12, 53);
            this.dgvVozila.MultiSelect = false;
            this.dgvVozila.Name = "dgvVozila";
            this.dgvVozila.ReadOnly = true;
            this.dgvVozila.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVozila.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvVozila.RowHeadersVisible = false;
            this.dgvVozila.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVozila.RowTemplate.Height = 60;
            this.dgvVozila.RowTemplate.ReadOnly = true;
            this.dgvVozila.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVozila.Size = new System.Drawing.Size(483, 582);
            this.dgvVozila.TabIndex = 10;
            this.dgvVozila.SelectionChanged += new System.EventHandler(this.dgvVozila_SelectionChanged);
            // 
            // ID
            // 
            this.ID.FillWeight = 39.49203F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.FillWeight = 155.6717F;
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // CijenaDan
            // 
            this.CijenaDan.FillWeight = 57.77873F;
            this.CijenaDan.HeaderText = "Cijena dan";
            this.CijenaDan.Name = "CijenaDan";
            this.CijenaDan.ReadOnly = true;
            // 
            // menuStrip
            // 
            this.menuStrip.AllowMerge = false;
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStrip.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(10, 3, 15, 3);
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip.Size = new System.Drawing.Size(1306, 40);
            this.menuStrip.TabIndex = 27;
            this.menuStrip.Text = "menuStrip";
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.CalendarFont = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDatumDo.CustomFormat = "dd.MM.yyyy";
            this.dtpDatumDo.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDatumDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumDo.Location = new System.Drawing.Point(936, 318);
            this.dtpDatumDo.MinDate = new System.DateTime(2022, 9, 20, 0, 0, 0, 0);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(348, 40);
            this.dtpDatumDo.TabIndex = 31;
            this.dtpDatumDo.ValueChanged += new System.EventHandler(this.dtpDatumDo_ValueChanged);
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.CalendarFont = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDatumOd.CustomFormat = "dd.MM.yyyy";
            this.dtpDatumOd.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDatumOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumOd.Location = new System.Drawing.Point(936, 239);
            this.dtpDatumOd.MinDate = new System.DateTime(2022, 9, 20, 0, 0, 0, 0);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(348, 40);
            this.dtpDatumOd.TabIndex = 30;
            this.dtpDatumOd.ValueChanged += new System.EventHandler(this.dtpDatumOd_ValueChanged);
            // 
            // lblDo
            // 
            this.lblDo.AutoSize = true;
            this.lblDo.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDo.Location = new System.Drawing.Point(930, 289);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(225, 27);
            this.lblDo.TabIndex = 35;
            this.lblDo.Text = "Datum najma do (ne ukljucujuci):";
            // 
            // lblOd
            // 
            this.lblOd.AutoSize = true;
            this.lblOd.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOd.Location = new System.Drawing.Point(931, 209);
            this.lblOd.Name = "lblOd";
            this.lblOd.Size = new System.Drawing.Size(206, 27);
            this.lblOd.TabIndex = 34;
            this.lblOd.Text = "Datum najma od (ukljucujuci):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(527, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 27);
            this.label2.TabIndex = 33;
            this.label2.Text = "OIB:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(931, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 27);
            this.label1.TabIndex = 32;
            this.label1.Text = "Vozilo:";
            // 
            // txtOIB
            // 
            this.txtOIB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOIB.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOIB.Location = new System.Drawing.Point(533, 163);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(348, 36);
            this.txtOIB.TabIndex = 29;
            this.txtOIB.Leave += new System.EventHandler(this.txtOIB_Leave);
            // 
            // txtVozilo
            // 
            this.txtVozilo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVozilo.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVozilo.Location = new System.Drawing.Point(937, 163);
            this.txtVozilo.Name = "txtVozilo";
            this.txtVozilo.ReadOnly = true;
            this.txtVozilo.Size = new System.Drawing.Size(348, 36);
            this.txtVozilo.TabIndex = 28;
            // 
            // lblNaslov
            // 
            this.lblNaslov.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblNaslov.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNaslov.Location = new System.Drawing.Point(937, 68);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(348, 59);
            this.lblNaslov.TabIndex = 36;
            this.lblNaslov.Text = "Podaci o vozilu";
            this.lblNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(533, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 59);
            this.label3.TabIndex = 37;
            this.label3.Text = "Podaci o kupcu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(527, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 27);
            this.label4.TabIndex = 39;
            this.label4.Text = "Ime:";
            // 
            // txtIme
            // 
            this.txtIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIme.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIme.Location = new System.Drawing.Point(533, 241);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(348, 36);
            this.txtIme.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(527, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 27);
            this.label5.TabIndex = 41;
            this.label5.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrezime.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrezime.Location = new System.Drawing.Point(533, 320);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(348, 36);
            this.txtPrezime.TabIndex = 40;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(527, 446);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(57, 27);
            this.lbl1.TabIndex = 45;
            this.lbl1.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(533, 476);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(348, 36);
            this.txtEmail.TabIndex = 44;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl.Location = new System.Drawing.Point(527, 367);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(43, 27);
            this.lbl.TabIndex = 43;
            this.lbl.Text = "Broj:";
            // 
            // txtBroj
            // 
            this.txtBroj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBroj.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBroj.Location = new System.Drawing.Point(533, 397);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(348, 36);
            this.txtBroj.TabIndex = 42;
            // 
            // btnIznajmi
            // 
            this.btnIznajmi.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnIznajmi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIznajmi.FlatAppearance.BorderSize = 0;
            this.btnIznajmi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIznajmi.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIznajmi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIznajmi.Location = new System.Drawing.Point(533, 564);
            this.btnIznajmi.Name = "btnIznajmi";
            this.btnIznajmi.Size = new System.Drawing.Size(348, 53);
            this.btnIznajmi.TabIndex = 46;
            this.btnIznajmi.Text = "IZNAJMI";
            this.btnIznajmi.UseVisualStyleBackColor = false;
            this.btnIznajmi.Click += new System.EventHandler(this.btnIznajmi_Click);
            // 
            // lblNedostupno
            // 
            this.lblNedostupno.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblNedostupno.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNedostupno.ForeColor = System.Drawing.Color.Red;
            this.lblNedostupno.Location = new System.Drawing.Point(936, 412);
            this.lblNedostupno.Name = "lblNedostupno";
            this.lblNedostupno.Size = new System.Drawing.Size(348, 139);
            this.lblNedostupno.TabIndex = 47;
            this.lblNedostupno.Text = "Ovo vozilo je nedostupno u odabranom\r\n vremenskom periodu\r\n";
            this.lblNedostupno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNedostupno.Visible = false;
            // 
            // lblCijena
            // 
            this.lblCijena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCijena.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCijena.Location = new System.Drawing.Point(937, 564);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(347, 53);
            this.lblCijena.TabIndex = 48;
            this.lblCijena.Text = "Cijena:";
            this.lblCijena.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBrojDana
            // 
            this.lblBrojDana.AutoSize = true;
            this.lblBrojDana.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBrojDana.Location = new System.Drawing.Point(929, 366);
            this.lblBrojDana.Name = "lblBrojDana";
            this.lblBrojDana.Size = new System.Drawing.Size(94, 32);
            this.lblBrojDana.TabIndex = 49;
            this.lblBrojDana.Text = "Broj dana:";
            // 
            // frmIznajmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1306, 647);
            this.Controls.Add(this.lblBrojDana);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblNedostupno);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.btnIznajmi);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtBroj);
            this.Controls.Add(this.dtpDatumDo);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.dtpDatumOd);
            this.Controls.Add(this.lblDo);
            this.Controls.Add(this.lblOd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOIB);
            this.Controls.Add(this.txtVozilo);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.dgvVozila);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmIznajmi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iznajmi";
            this.Load += new System.EventHandler(this.frmIznajmi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvVozila;
        private MenuStrip menuStrip;
        private DateTimePicker dtpDatumDo;
        private DateTimePicker dtpDatumOd;
        private Label lblDo;
        private Label lblOd;
        private Label label2;
        private Label label1;
        private TextBox txtOIB;
        private TextBox txtVozilo;
        private Label lblNaslov;
        private Label label3;
        private Label label4;
        private TextBox txtIme;
        private Label label5;
        private TextBox txtPrezime;
        private Label lbl1;
        private TextBox txtEmail;
        private Label lbl;
        private TextBox txtBroj;
        private Button btnIznajmi;
        private Label lblNedostupno;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn CijenaDan;
        private Label lblCijena;
        private Label lblBrojDana;
    }
}