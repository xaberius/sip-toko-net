using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace SIP_Toko
{
    public class barang
    {
        public string kodebarang { get; set; }
        public string namabarang { get; set; }
        public string satuan { get; set; }
        public double hargabeli { get; set; }
        public int stockmin { get; set; }
        public int stockmax { get; set; }
        public int stock { get; set; }
        public int rate { get; set; }
        private CommonClass CClass = new CommonClass();
                
        public List<barang> barangx(int pilihan)
        {
            string sql ="";
            MySqlConnection db = new MySqlConnection(CClass.connectionSQL);
            db.Open();
            MySqlCommand dbcmd = db.CreateCommand();
            if (pilihan == 0)
            {
                sql = "select * from barang order by kodebarang;";
            }
            else if (pilihan == 1)
            {
                sql = "select * from barang order by kodebarang desc;";
            }

            dbcmd.CommandText = sql;
            MySqlDataReader reader = dbcmd.ExecuteReader();
            List<barang> xx = new List<barang>(40);
            while (reader.Read())
            {
                barang barangy = new barang();
                barangy.kodebarang = reader.GetString(0);
                barangy.namabarang = reader.GetString(1);
                barangy.satuan = reader.GetString(2);
                barangy.hargabeli = double.Parse(reader.GetString(3));
                barangy.stockmin = int.Parse(reader.GetString(4));
                barangy.stockmax = int.Parse(reader.GetString(5));
                barangy.stock = int.Parse(reader.GetString(6));
                barangy.rate = int.Parse(reader.GetString(7));
                xx.Add(barangy);
                // lakukan sesuatu sesuka anda didalam scope ini           
            }

            db.Close();
            return xx;
        }

        public bool SaveBarang(barang barangSave)
        {
            try
            {
                MySqlConnection db = new MySqlConnection(CClass.connectionSQL);
                db.Open();
                MySqlCommand dbcmd = db.CreateCommand();
                string sql = "INSERT INTO `barang`(`kodebarang`, `namabarang`, `satuan`, `hargabeli`, `stockmin`, `stockmax`, `stock`, `rate`) VALUES ('" + barangSave.kodebarang + "','" + barangSave.namabarang + "','" + barangSave.satuan + "'," + barangSave.hargabeli + "," + barangSave.stockmin + "," + barangSave.stockmax + "," + barangSave.stock + "," + barangSave.rate + ");";
                dbcmd.CommandText = sql;
                MySqlDataReader reader = dbcmd.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateBarang(barang barangSave)
        {
            try
            {
                MySqlConnection db = new MySqlConnection(CClass.connectionSQL);
                db.Open();
                MySqlCommand dbcmd = db.CreateCommand();
                string sql = "UPDATE `barang` SET `namabarang`='" + barangSave.namabarang + "',`satuan`='" + barangSave.satuan + "',`hargabeli`=" + barangSave.hargabeli + ",`stockmin`='" + barangSave.stockmin + "',`stockmax`='" + barangSave.stockmax + "',`stock`='" + barangSave.stock + "',`rate`='" + barangSave.rate + "' WHERE kodebarang='"+ barangSave.kodebarang +"';";
                dbcmd.CommandText = sql;
                MySqlDataReader reader = dbcmd.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteBarang(string kodedelete)
        {
            try
            {
                MySqlConnection db = new MySqlConnection(CClass.connectionSQL);
                db.Open();
                MySqlCommand dbcmd = db.CreateCommand();
                string sql = "delete from barang where kodebarang ='" + kodedelete + "';";
                dbcmd.CommandText = sql;                
                MySqlDataReader reader = dbcmd.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
