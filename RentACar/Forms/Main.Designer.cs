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
            this.txtDatumKraja = new System.Windows.Forms.TextBox();
            this.txtDatumPocetka = new System.Windows.Forms.TextBox();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPretrazi = new System.Windows.Forms.Button();
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
            // 
            // vozilaToolStripMenuItem
            // 
            this.vozilaToolStripMenuItem.Name = "vozilaToolStripMenuItem";
            this.vozilaToolStripMenuItem.Size = new System.Drawing.Size(73, 36);
            this.vozilaToolStripMenuItem.Text = "Vozila";
            this.vozilaToolStripMenuItem.Click += new System.EventHandler(this.vozilaToolStripMenuItem_Click);
            // 
            // kupciToolStripMenuItem
            // 
            this.kupciToolStripMenuItem.Name = "kupciToolStripMenuItem";
            this.kupciToolStripMenuItem.Size = new System.Drawing.Size(69, 36);
            this.kupciToolStripMenuItem.Text = "Kupci";
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.dgvNajmovi.TabIndex = 1;
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
            this.txtVozilo.Location = new System.Drawing.Point(50, 194);
            this.txtVozilo.Name = "txtVozilo";
            this.txtVozilo.Size = new System.Drawing.Size(348, 36);
            this.txtVozilo.TabIndex = 2;
            // 
            // txtOIB
            // 
            this.txtOIB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOIB.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOIB.Location = new System.Drawing.Point(50, 274);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(348, 36);
            this.txtOIB.TabIndex = 3;
            // 
            // txtDatumKraja
            // 
            this.txtDatumKraja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDatumKraja.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDatumKraja.Location = new System.Drawing.Point(50, 434);
            this.txtDatumKraja.Name = "txtDatumKraja";
            this.txtDatumKraja.Size = new System.Drawing.Size(348, 36);
            this.txtDatumKraja.TabIndex = 5;
            // 
            // txtDatumPocetka
            // 
            this.txtDatumPocetka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDatumPocetka.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDatumPocetka.Location = new System.Drawing.Point(50, 354);
            this.txtDatumPocetka.Name = "txtDatumPocetka";
            this.txtDatumPocetka.Size = new System.Drawing.Size(348, 36);
            this.txtDatumPocetka.TabIndex = 6;
            // 
            // lblPretraga
            // 
            this.lblPretraga.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPretraga.Location = new System.Drawing.Point(10, 74);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(432, 66);
            this.lblPretraga.TabIndex = 7;
            this.lblPretraga.Text = "Pretraga aktivnih najmova";
            this.lblPretraga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(44, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vozilo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "OIB Kupca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(45, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "Datum najma od:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(44, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "Datum najma do:";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPretrazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPretrazi.FlatAppearance.BorderSize = 0;
            this.btnPretrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretrazi.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPretrazi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPretrazi.Location = new System.Drawing.Point(50, 536);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(348, 45);
            this.btnPretrazi.TabIndex = 12;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1306, 647);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.txtDatumPocetka);
            this.Controls.Add(this.txtDatumKraja);
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
        private TextBox txtDatumKraja;
        private TextBox txtDatumPocetka;
        private Label lblPretraga;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnPretrazi;
    }
}