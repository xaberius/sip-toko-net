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
    public partial class FrmSatuan : Form
    {        
        public FrmSatuan()
        {
            InitializeComponent();            
        }

        private void FrmSatuan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Satuan' table. You can move, or remove it, as needed.
            this.satuanTableAdapter.Fill(this.database1DataSet.Satuan);
            Grid.Location = new Point(12, 12);
            TxtKode.Text = "";
            TxtNama.Text = "";

            Tombol(true);
        }

        public void Tombol(bool Status)
        {
            CmdTambah.Visible = Status;
            CmdEdit.Visible = Status;
            CmdDelete.Visible = Status;

            CmdSave.Visible = !Status;
            CmdCancel.Visible = !Status;

            Grid.Visible = Status;
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdTambah_Click(object sender, EventArgs e)
        {
            Tombol(false);
            int kode = Grid.Rows.Count;
            if (kode != 0)
            {
                TxtKode.Text = string.Format("ST-{0}", kode);
            }
            else
            {
                TxtKode.Text = "ST-0";
            }
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            Tombol(true);
            TxtKode.Text = "";
            TxtNama.Text = "";
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            
        }

    }
}
