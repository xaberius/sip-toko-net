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
    public partial class FrmBarang : Form
    {
        private barang barangxx = new barang();
        private string kodes,msg;

        bool edit;
        Dictionary<string, List<barang>> databarang = new Dictionary<string, List<barang>>();

        public FrmBarang()
        {
            InitializeComponent();
            databarang.Add("lama", barangxx.barangx(0));

            Grid.Columns.Add("kodebarang", "Kode Barang");
            Grid.Columns.Add("namabarang", "Nama Barang");
            Grid.Columns.Add("satuan", "Satuan");
            Grid.Columns.Add("hargabeli", "Harga Beli");
            Grid.Columns.Add("stockmin", "Stock Min");
            Grid.Columns.Add("stockmax", "Stock Max");
            Grid.Columns.Add("stock", "Stock");
            Grid.Columns.Add("Rate", "Rate Jual(%)");

            IsiGrid();            
        }

        public string KodeAuto()
        {
            databarang["lama"] = databarang["lama"] = barangxx.barangx(1);
            if (databarang["lama"].Count == 0)
            {
                return "BR0001";
            }
            else
            {
                int no = int.Parse(databarang["lama"][0].kodebarang.Substring(3,3));
                no = no + 1;
                
                return string.Format("BR{0}",no.ToString("0000"));
            }
        }

        public void IsiGrid()
        {           
            Grid.Rows.Clear();

            foreach (var barangz in databarang["lama"])
            {
                Grid.Rows.Add(new string[] { barangz.kodebarang, barangz.namabarang, barangz.satuan, "Rp. " + barangz.hargabeli.ToString(), 
                barangz.stockmin.ToString(),barangz.stockmax.ToString(),barangz.stock.ToString(),barangz.rate.ToString() });
            }
        }

        public void tombol(bool status)
        {
            CmdTambah.Visible = status;
            CmdEdit.Visible = status;
            CmdDelete.Visible = status;
            CmdRefresh.Visible = status;

            CmdSave.Visible = !status;
            CmdCancel.Visible = !status;
            
            Grid.Visible = status;

        }


        private void FrmBarang_Load(object sender, EventArgs e)
        {
            tombol(true);
            Grid.Location = new Point(12, 12);
            kodes = Grid.Rows[Grid.CurrentCell.RowIndex].Cells[0].Value.ToString();
            TxtKode.Text = KodeAuto();
        }

        private void CmdTambah_Click(object sender, EventArgs e)
        {
            tombol(false);
            this.Text = "Add new";
            edit = false;
            TxtKode.ReadOnly = false;
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            ClearScreen();
            tombol(true);
            IsiGrid();
            this.Text = "Barang";
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tombol(false);
            edit = true;
            TxtKode.Text = Grid.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtNama.Text = Grid.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtSatuan.Text = Grid.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtHargaBeli.Text = Grid.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtStockMin.Text = Grid.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtStockMax.Text = Grid.Rows[e.RowIndex].Cells[5].Value.ToString();
            TxtStock.Text = Grid.Rows[e.RowIndex].Cells[6].Value.ToString();
            TxtRate.Text = Grid.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(kodes + " Yakin akan dihapus??", "Alert", MessageBoxButtons.OKCancel,MessageBoxIcon.Stop) == DialogResult.OK)
            {
                if(barangxx.DeleteBarang(kodes.Trim()))
                {
                    MessageBox.Show("Data deleted!");
                    databarang["lama"] = barangxx.barangx(0);
                    IsiGrid();
                }                
            }
            
        }

        public void ClearScreen()
        {
            TxtKode.Text = "";
            TxtNama.Text = "";
            TxtSatuan.Text = "";
            TxtHargaBeli.Text = "";
            TxtStockMin.Text = "";
            TxtStockMax.Text = "";
            TxtStock.Text = "";
            TxtRate.Text = "";
        }

        private void CmdRefresh_Click(object sender, EventArgs e)
        {
            databarang["lama"] = barangxx.barangx(0);
            IsiGrid();
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kodes = Grid.Rows[Grid.CurrentCell.RowIndex].Cells[0].Value.ToString();
        }

        private void CmdEdit_Click(object sender, EventArgs e)
        {
            edit = true;
            tombol(false);
            this.Text = "Editing";

            TxtKode.Text = Grid.Rows[Grid.CurrentCell.RowIndex].Cells[0].Value.ToString();
            TxtNama.Text = Grid.Rows[Grid.CurrentCell.RowIndex].Cells[1].Value.ToString();
            TxtSatuan.Text = Grid.Rows[Grid.CurrentCell.RowIndex].Cells[2].Value.ToString();
            TxtHargaBeli.Text = Grid.Rows[Grid.CurrentCell.RowIndex].Cells[3].Value.ToString();
            TxtStockMin.Text = Grid.Rows[Grid.CurrentCell.RowIndex].Cells[4].Value.ToString();
            TxtStockMax.Text = Grid.Rows[Grid.CurrentCell.RowIndex].Cells[5].Value.ToString();
            TxtStock.Text = Grid.Rows[Grid.CurrentCell.RowIndex].Cells[6].Value.ToString();
            TxtRate.Text = Grid.Rows[Grid.CurrentCell.RowIndex].Cells[7].Value.ToString();
            TxtKode.ReadOnly = true;
        }

        public bool CheckIsi()
        {
            if (TxtKode.Text.Trim() == "")
            {
                TxtKode.Focus();
                msg ="Kode barang";
                return false;
            }
            else if (TxtNama.Text.Trim() == "")
            {
                TxtNama.Focus();
                msg ="Nama barang";
                return false;
            }
            else if (TxtSatuan.Text.Trim() == "")
            {
                TxtSatuan.Focus();
                msg ="Satuan";
                return false;
            }
            else if (TxtHargaBeli.Text.Replace("Rp ", "").Trim() == "")
            {
                TxtHargaBeli.Focus();
                msg ="Harga beli";
                return false;
            }
            else if (TxtStockMin.Text.Trim() == "")
            {
                TxtStockMin.Focus();
                msg ="Stock minimum";
                return false;
            }
            else if (TxtStockMax.Text.Trim() == "")
            {
                TxtStockMax.Focus();
                msg ="Stock maksimum";
                return false;
            }
            else if (TxtStock.Text.Trim() == "")
            {
                TxtStock.Focus();
                msg ="Stock";
                return false;
            }
            else if (TxtRate.Text.Replace("%", "").Trim() == "")
            {
                TxtRate.Focus();
                msg ="Rate";
                return false;
            }
            else
            {
                return true;
            }            
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            barang barangs = new barang();
            if (!CheckIsi())
            {
                MessageBox.Show(msg + " belum terisi!");
                return;
            }
            TxtKode.Text = KodeAuto();

            barangs.kodebarang = TxtKode.Text.Trim();
            barangs.namabarang = TxtNama.Text.Trim();
            barangs.satuan = TxtSatuan.Text.Trim();
            barangs.hargabeli = double.Parse(TxtHargaBeli.Text.Replace("Rp ", "").Trim());
            barangs.stockmax = int.Parse(TxtStockMax.Text.Trim());
            barangs.stockmin = int.Parse(TxtStockMin.Text.Trim());
            barangs.stock = int.Parse(TxtStock.Text.Trim());
            barangs.rate = int.Parse(TxtRate.Text.Replace("%", "").Trim());

            if (!edit)
            {
                if (barangxx.SaveBarang(barangs))
                {
                    MessageBox.Show("Data Saved!");
                    databarang["lama"] = barangxx.barangx(0);
                }
                IsiGrid();
                tombol(true);
            }
            else
            {
                if (barangxx.UpdateBarang(barangs))
                {
                    MessageBox.Show("Data Saved!");
                    databarang["lama"] = barangxx.barangx(0);
                }
                IsiGrid();
                tombol(true);
            }
            
        }
   
    }
}
