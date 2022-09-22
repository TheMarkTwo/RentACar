namespace RentACar.Forms
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.iznajmiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vozilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kupciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvNajmovi = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vozilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kupac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumNajma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumKraja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtVozilo = new System.Windows.Forms.TextBox();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOd = new System.Windows.Forms.Label();
            this.lblDo = new System.Windows.Forms.Label();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.cboxPretragaDatum = new System.Windows.Forms.CheckBox();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNajmovi)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AllowMerge = false;
            this.menuStrip.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iznajmiToolStripMenuItem,
            this.vozilaToolStripMenuItem,
            this.kupciToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip.Size = new System.Drawing.Size(1306, 42);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // iznajmiToolStripMenuItem
            // 
            this.iznajmiToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.iznajmiToolStripMenuItem.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iznajmiToolStripMenuItem.Name = "iznajmiToolStripMenuItem";
            this.iznajmiToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iznajmiToolStripMenuItem.Size = new System.Drawing.Size(83, 36);
            this.iznajmiToolStripMenuItem.Text = "Iznajmi";
            this.iznajmiToolStripMenuItem.Click += new System.EventHandler(this.iznajmiToolStripMenuItem_Click);
            // 
            // vozilaToolStripMenuItem
            // 
            this.vozilaToolStripMenuItem.Name = "vozilaToolStripMenuItem";
            this.vozilaToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.vozilaToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.vozilaToolStripMenuItem.Text = "Vozila";
            this.vozilaToolStripMenuItem.Click += new System.EventHandler(this.vozilaToolStripMenuItem_Click);
            // 
            // kupciToolStripMenuItem
            // 
            this.kupciToolStripMenuItem.Name = "kupciToolStripMenuItem";
            this.kupciToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.kupciToolStripMenuItem.Size = new System.Drawing.Size(73, 36);
            this.kupciToolStripMenuItem.Text = "Kupci";
            this.kupciToolStripMenuItem.Click += new System.EventHandler(this.kupciToolStripMenuItem_Click);
            // 
            // dgvNajmovi
            // 
            this.dgvNajmovi.AllowUserToAddRows = false;
            this.dgvNajmovi.AllowUserToDeleteRows = false;
            this.dgvNajmovi.AllowUserToResizeColumns = false;
            this.dgvNajmovi.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvNajmovi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNajmovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNajmovi.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvNajmovi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNajmovi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvNajmovi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNajmovi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNajmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNajmovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Vozilo,
            this.Kupac,
            this.DatumNajma,
            this.DatumKraja,
            this.Cijena});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNajmovi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNajmovi.EnableHeadersVisualStyles = false;
            this.dgvNajmovi.Location = new System.Drawing.Point(459, 58);
            this.dgvNajmovi.MultiSelect = false;
            this.dgvNajmovi.Name = "dgvNajmovi";
            this.dgvNajmovi.ReadOnly = true;
            this.dgvNajmovi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNajmovi.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNajmovi.RowHeadersVisible = false;
            this.dgvNajmovi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvNajmovi.RowTemplate.Height = 40;
            this.dgvNajmovi.RowTemplate.ReadOnly = true;
            this.dgvNajmovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNajmovi.Size = new System.Drawing.Size(835, 577);
            this.dgvNajmovi.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.FillWeight = 36.54822F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Vozilo
            // 
            this.Vozilo.FillWeight = 112.6903F;
            this.Vozilo.HeaderText = "Vozilo";
            this.Vozilo.Name = "Vozilo";
            this.Vozilo.ReadOnly = true;
            // 
            // Kupac
            // 
            this.Kupac.FillWeight = 112.6903F;
            this.Kupac.HeaderText = "Kupac";
            this.Kupac.Name = "Kupac";
            this.Kupac.ReadOnly = true;
            // 
            // DatumNajma
            // 
            this.DatumNajma.FillWeight = 112.6903F;
            this.DatumNajma.HeaderText = "Datum najma";
            this.DatumNajma.Name = "DatumNajma";
            this.DatumNajma.ReadOnly = true;
            // 
            // DatumKraja
            // 
            this.DatumKraja.FillWeight = 112.6903F;
            this.DatumKraja.HeaderText = "Datum kraja";
            this.DatumKraja.Name = "DatumKraja";
            this.DatumKraja.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.FillWeight = 112.6903F;
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // txtVozilo
            // 
            this.txtVozilo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVozilo.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVozilo.Location = new System.Drawing.Point(50, 167);
            this.txtVozilo.Name = "txtVozilo";
            this.txtVozilo.Size = new System.Drawing.Size(348, 36);
            this.txtVozilo.TabIndex = 0;
            // 
            // txtOIB
            // 
            this.txtOIB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOIB.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOIB.Location = new System.Drawing.Point(50, 247);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(348, 36);
            this.txtOIB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(44, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vozilo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "OIB Kupca:";
            // 
            // lblOd
            // 
            this.lblOd.AutoSize = true;
            this.lblOd.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOd.Location = new System.Drawing.Point(45, 336);
            this.lblOd.Name = "lblOd";
            this.lblOd.Size = new System.Drawing.Size(121, 27);
            this.lblOd.TabIndex = 10;
            this.lblOd.Text = "Datum najma od:";
            // 
            // lblDo
            // 
            this.lblDo.AutoSize = true;
            this.lblDo.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDo.Location = new System.Drawing.Point(44, 416);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(121, 27);
            this.lblDo.TabIndex = 11;
            this.lblDo.Text = "Datum najma do:";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPretrazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPretrazi.FlatAppearance.BorderSize = 0;
            this.btnPretrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretrazi.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPretrazi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPretrazi.Location = new System.Drawing.Point(50, 514);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(348, 45);
            this.btnPretrazi.TabIndex = 4;
            this.btnPretrazi.Text = "PRETRAZI";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.CalendarFont = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDatumOd.CustomFormat = " ";
            this.dtpDatumOd.Enabled = false;
            this.dtpDatumOd.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDatumOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumOd.Location = new System.Drawing.Point(50, 366);
            this.dtpDatumOd.MinDate = new System.DateTime(2021, 9, 1, 0, 0, 0, 0);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(348, 40);
            this.dtpDatumOd.TabIndex = 2;
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.CalendarFont = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDatumDo.CustomFormat = " ";
            this.dtpDatumDo.Enabled = false;
            this.dtpDatumDo.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDatumDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumDo.Location = new System.Drawing.Point(50, 445);
            this.dtpDatumDo.MinDate = new System.DateTime(2022, 9, 20, 0, 0, 0, 0);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(348, 40);
            this.dtpDatumDo.TabIndex = 3;
            // 
            // cboxPretragaDatum
            // 
            this.cboxPretragaDatum.AutoSize = true;
            this.cboxPretragaDatum.FlatAppearance.BorderSize = 4;
            this.cboxPretragaDatum.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboxPretragaDatum.Location = new System.Drawing.Point(50, 297);
            this.cboxPretragaDatum.Name = "cboxPretragaDatum";
            this.cboxPretragaDatum.Size = new System.Drawing.Size(160, 31);
            this.cboxPretragaDatum.TabIndex = 15;
            this.cboxPretragaDatum.Text = "Pretraga po datumu";
            this.cboxPretragaDatum.UseVisualStyleBackColor = true;
            this.cboxPretragaDatum.CheckedChanged += new System.EventHandler(this.cboxPretragaDatum_CheckedChanged);
            // 
            // lblPretraga
            // 
            this.lblPretraga.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPretraga.Location = new System.Drawing.Point(10, 60);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(432, 66);
            this.lblPretraga.TabIndex = 7;
            this.lblPretraga.Text = "Pretraga aktivnih najmova";
            this.lblPretraga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnIzbrisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzbrisi.FlatAppearance.BorderSize = 0;
            this.btnIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzbrisi.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIzbrisi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIzbrisi.Location = new System.Drawing.Point(50, 577);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(348, 45);
            this.btnIzbrisi.TabIndex = 16;
            this.btnIzbrisi.Text = "IZBRISI";
            this.btnIzbrisi.UseVisualStyleBackColor = false;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1306, 647);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.cboxPretragaDatum);
            this.Controls.Add(this.dtpDatumDo);
            this.Controls.Add(this.dtpDatumOd);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.lblDo);
            this.Controls.Add(this.lblOd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.txtOIB);
            this.Controls.Add(this.txtVozilo);
            this.Controls.Add(this.dgvNajmovi);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matkov Luksuzni Rent a Car";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNajmovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private DataGridView dgvNajmovi;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Vozilo;
        private DataGridViewTextBoxColumn Kupac;
        private DataGridViewTextBoxColumn DatumNajma;
        private DataGridViewTextBoxColumn DatumKraja;
        private DataGridViewTextBoxColumn Cijena;
        private ToolStripMenuItem iznajmiToolStripMenuItem;
        private ToolStripMenuItem vozilaToolStripMenuItem;
        private ToolStripMenuItem kupciToolStripMenuItem;
        private TextBox txtVozilo;
        private TextBox txtOIB;
        private Label label1;
        private Label label2;
        private Label lblOd;
        private Label lblDo;
        private Button btnPretrazi;
        private DateTimePicker dtpDatumOd;
        private DateTimePicker dtpDatumDo;
        private CheckBox cboxPretragaDatum;
        private Label lblPretraga;
        private Button btnIzbrisi;
    }
}