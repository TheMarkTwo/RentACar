namespace RentACar.Forms
{
    partial class frmDetaljiVozila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetaljiVozila));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.iznajmiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pboxSlika = new System.Windows.Forms.PictureBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AllowMerge = false;
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStrip.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iznajmiToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(10, 3, 15, 3);
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip.Size = new System.Drawing.Size(1306, 40);
            this.menuStrip.TabIndex = 27;
            this.menuStrip.Text = "menuStrip";
            // 
            // iznajmiToolStripMenuItem
            // 
            this.iznajmiToolStripMenuItem.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iznajmiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iznajmiToolStripMenuItem.Name = "iznajmiToolStripMenuItem";
            this.iznajmiToolStripMenuItem.Size = new System.Drawing.Size(83, 34);
            this.iznajmiToolStripMenuItem.Text = "Iznajmi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pboxSlika);
            this.panel1.Location = new System.Drawing.Point(456, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 522);
            this.panel1.TabIndex = 28;
            // 
            // pboxSlika
            // 
            this.pboxSlika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxSlika.Image = global::RentACar.Properties.Resources.placeholder;
            this.pboxSlika.InitialImage = ((System.Drawing.Image)(resources.GetObject("pboxSlika.InitialImage")));
            this.pboxSlika.Location = new System.Drawing.Point(3, 3);
            this.pboxSlika.Name = "pboxSlika";
            this.pboxSlika.Size = new System.Drawing.Size(791, 516);
            this.pboxSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxSlika.TabIndex = 25;
            this.pboxSlika.TabStop = false;
            // 
            // lblNaziv
            // 
            this.lblNaziv.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblNaziv.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNaziv.Location = new System.Drawing.Point(0, 87);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(453, 79);
            this.lblNaziv.TabIndex = 30;
            this.lblNaziv.Text = "Naziv vozila";
            this.lblNaziv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDetaljiVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1306, 647);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDetaljiVozila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalji vozila [ID]";
            this.Load += new System.EventHandler(this.frmDetaljiVozila_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxSlika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MenuStrip menuStrip;
        private Panel panel1;
        private PictureBox pboxSlika;
        private Label lblNaziv;
        private ToolStripMenuItem iznajmiToolStripMenuItem;
    }
}