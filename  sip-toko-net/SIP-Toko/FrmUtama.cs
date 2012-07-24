using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SIP_Toko
{
    public partial class FrmUtama : Form
    {
        public FrmUtama()
        {
            InitializeComponent();
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBarang frmbarang = new FrmBarang();
            frmbarang.ShowDialog();
        }
    }
}
