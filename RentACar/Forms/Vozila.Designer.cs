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
            this.lblKatalog = new System.Windows.Forms.Label();
            this.dgvKatalog = new System.Windows.Forms.DataGridView();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Snaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brzina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NulaDoSto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaDan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKatalog
            // 
            this.lblKatalog.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKatalog.Location = new System.Drawing.Point(12, 1);
            this.lblKatalog.Name = "lblKatalog";
            this.lblKatalog.Size = new System.Drawing.Size(1282, 66);
            this.lblKatalog.TabIndex = 8;
            this.lblKatalog.Text = "Katalog vozila";
            this.lblKatalog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvKatalog
            // 
            this.dgvKatalog.AllowUserToAddRows = false;
            this.dgvKatalog.AllowUserToDeleteRows = false;
            this.dgvKatalog.AllowUserToResizeColumns = false;
            this.dgvKatalog.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvKatalog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKatalog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKatalog.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvKatalog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKatalog.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvKatalog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKatalog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKatalog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Slika,
            this.Naziv,
            this.Snaga,
            this.Brzina,
            this.NulaDoSto,
            this.CijenaDan});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKatalog.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKatalog.EnableHeadersVisualStyles = false;
            this.dgvKatalog.Location = new System.Drawing.Point(12, 72);
            this.dgvKatalog.MultiSelect = false;
            this.dgvKatalog.Name = "dgvKatalog";
            this.dgvKatalog.ReadOnly = true;
            this.dgvKatalog.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKatalog.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKatalog.RowHeadersVisible = false;
            this.dgvKatalog.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvKatalog.RowTemplate.Height = 160;
            this.dgvKatalog.RowTemplate.ReadOnly = true;
            this.dgvKatalog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKatalog.Size = new System.Drawing.Size(1282, 577);
            this.dgvKatalog.TabIndex = 9;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPretrazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPretrazi.FlatAppearance.BorderSize = 0;
            this.btnPretrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretrazi.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPretrazi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPretrazi.Location = new System.Drawing.Point(60, 664);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(348, 45);
            this.btnPretrazi.TabIndex = 13;
            this.btnPretrazi.Text = "Uredi podatke o vozli";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(479, 664);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(348, 45);
            this.button1.TabIndex = 14;
            this.button1.Text = "Dodaj vozilo";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(895, 664);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(348, 45);
            this.button2.TabIndex = 15;
            this.button2.Text = "Izbrisi vozilo";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ID
            // 
            this.ID.FillWeight = 27.90349F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Slika
            // 
            this.Slika.FillWeight = 129.2484F;
            this.Slika.HeaderText = "Slika";
            this.Slika.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.FillWeight = 95.87928F;
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Snaga
            // 
            this.Snaga.FillWeight = 95.87928F;
            this.Snaga.HeaderText = "Snaga";
            this.Snaga.Name = "Snaga";
            this.Snaga.ReadOnly = true;
            // 
            // Brzina
            // 
            this.Brzina.FillWeight = 95.87928F;
            this.Brzina.HeaderText = "Najveca brzina";
            this.Brzina.Name = "Brzina";
            this.Brzina.ReadOnly = true;
            // 
            // NulaDoSto
            // 
            this.NulaDoSto.FillWeight = 95.87928F;
            this.NulaDoSto.HeaderText = "0 - 100km/h";
            this.NulaDoSto.Name = "NulaDoSto";
            this.NulaDoSto.ReadOnly = true;
            // 
            // CijenaDan
            // 
            this.CijenaDan.FillWeight = 95.87928F;
            this.CijenaDan.HeaderText = "Cijena po danu";
            this.CijenaDan.Name = "CijenaDan";
            this.CijenaDan.ReadOnly = true;
            // 
            // frmVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1306, 721);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.dgvKatalog);
            this.Controls.Add(this.lblKatalog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVozila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled vozila";
            this.Load += new System.EventHandler(this.frmVozila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKatalog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblKatalog;
        private DataGridView dgvKatalog;
        private Button btnPretrazi;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewImageColumn Slika;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn Snaga;
        private DataGridViewTextBoxColumn Brzina;
        private DataGridViewTextBoxColumn NulaDoSto;
        private DataGridViewTextBoxColumn CijenaDan;
    }
}