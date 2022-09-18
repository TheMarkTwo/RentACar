namespace RentACar.Forms
{
    partial class frmVozila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVozila));
            this.lblVozila = new System.Windows.Forms.Label();
            this.dgvVozila = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Snaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brzina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NulaDoSto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaDan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izbrisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVozila
            // 
            this.lblVozila.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVozila.Location = new System.Drawing.Point(12, 43);
            this.lblVozila.Name = "lblVozila";
            this.lblVozila.Size = new System.Drawing.Size(1282, 67);
            this.lblVozila.TabIndex = 8;
            this.lblVozila.Text = "Popis vozila";
            this.lblVozila.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvVozila
            // 
            this.dgvVozila.AllowUserToAddRows = false;
            this.dgvVozila.AllowUserToDeleteRows = false;
            this.dgvVozila.AllowUserToResizeColumns = false;
            this.dgvVozila.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvVozila.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVozila.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVozila.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvVozila.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVozila.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvVozila.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVozila.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Slika,
            this.Naziv,
            this.Snaga,
            this.Brzina,
            this.NulaDoSto,
            this.CijenaDan});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVozila.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVozila.EnableHeadersVisualStyles = false;
            this.dgvVozila.Location = new System.Drawing.Point(12, 112);
            this.dgvVozila.MultiSelect = false;
            this.dgvVozila.Name = "dgvVozila";
            this.dgvVozila.ReadOnly = true;
            this.dgvVozila.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVozila.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVozila.RowHeadersVisible = false;
            this.dgvVozila.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVozila.RowTemplate.Height = 140;
            this.dgvVozila.RowTemplate.ReadOnly = true;
            this.dgvVozila.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVozila.Size = new System.Drawing.Size(1282, 523);
            this.dgvVozila.TabIndex = 9;
            this.dgvVozila.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVozila_CellContentDoubleClick);
            // 
            // ID
            // 
            this.ID.FillWeight = 33.2091F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Slika
            // 
            this.Slika.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Slika.FillWeight = 103.3988F;
            this.Slika.HeaderText = "Slika";
            this.Slika.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            this.Slika.Width = 208;
            // 
            // Naziv
            // 
            this.Naziv.FillWeight = 130.9053F;
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Snaga
            // 
            this.Snaga.FillWeight = 85.15334F;
            this.Snaga.HeaderText = "Snaga";
            this.Snaga.Name = "Snaga";
            this.Snaga.ReadOnly = true;
            // 
            // Brzina
            // 
            this.Brzina.FillWeight = 80.94453F;
            this.Brzina.HeaderText = "Najveca brzina";
            this.Brzina.Name = "Brzina";
            this.Brzina.ReadOnly = true;
            // 
            // NulaDoSto
            // 
            this.NulaDoSto.FillWeight = 114.1099F;
            this.NulaDoSto.HeaderText = "0 - 100km/h";
            this.NulaDoSto.Name = "NulaDoSto";
            this.NulaDoSto.ReadOnly = true;
            // 
            // CijenaDan
            // 
            this.CijenaDan.FillWeight = 88.82803F;
            this.CijenaDan.HeaderText = "Cijena po danu";
            this.CijenaDan.Name = "CijenaDan";
            this.CijenaDan.ReadOnly = true;
            // 
            // menuStrip
            // 
            this.menuStrip.AllowMerge = false;
            this.menuStrip.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.urediToolStripMenuItem,
            this.izbrisiToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip.Size = new System.Drawing.Size(1306, 42);
            this.menuStrip.TabIndex = 16;
            this.menuStrip.Text = "menuStrip";
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dodajToolStripMenuItem.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(124, 36);
            this.dodajToolStripMenuItem.Text = "Dodaj vozilo";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // urediToolStripMenuItem
            // 
            this.urediToolStripMenuItem.Name = "urediToolStripMenuItem";
            this.urediToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.urediToolStripMenuItem.Size = new System.Drawing.Size(203, 36);
            this.urediToolStripMenuItem.Text = "Uredi podatke o vozlu";
            this.urediToolStripMenuItem.Click += new System.EventHandler(this.urediToolStripMenuItem_Click);
            // 
            // izbrisiToolStripMenuItem
            // 
            this.izbrisiToolStripMenuItem.Name = "izbrisiToolStripMenuItem";
            this.izbrisiToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.izbrisiToolStripMenuItem.Size = new System.Drawing.Size(126, 36);
            this.izbrisiToolStripMenuItem.Text = "Izbrisi vozilo";
            this.izbrisiToolStripMenuItem.Click += new System.EventHandler(this.izbrisiToolStripMenuItem_Click);
            // 
            // frmVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1306, 647);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.dgvVozila);
            this.Controls.Add(this.lblVozila);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVozila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled vozila";
            this.Load += new System.EventHandler(this.frmVozila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblVozila;
        private DataGridView dgvVozila;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewImageColumn Slika;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn Snaga;
        private DataGridViewTextBoxColumn Brzina;
        private DataGridViewTextBoxColumn NulaDoSto;
        private DataGridViewTextBoxColumn CijenaDan;
        private MenuStrip menuStrip;
        private ToolStripMenuItem dodajToolStripMenuItem;
        private ToolStripMenuItem izbrisiToolStripMenuItem;
        private ToolStripMenuItem urediToolStripMenuItem;
    }
}