using RentACar.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                dgvNajmovi.Rows.Add(1, "BMW 750li", "482764121", DateOnly.Parse("25.5.2022"), DateOnly.Parse("30.5.2022"), 500);
                dgvNajmovi.Rows.Add(2, "BMW 740li", "153121234", DateOnly.Parse("25.5.2022"), DateOnly.Parse("30.5.2022"), 300);
                dgvNajmovi.Rows.Add(3, "BMW 730li", "521622312", DateOnly.Parse("25.5.2022"), DateOnly.Parse("30.5.2022"), 150);
            }
        }
    }
}
