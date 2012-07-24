namespace SIP_Toko
{
    partial class FrmBarang
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
            this.TxtRate = new System.Windows.Forms.MaskedTextBox();
            this.TxtStock = new System.Windows.Forms.MaskedTextBox();
            this.TxtStockMax = new System.Windows.Forms.MaskedTextBox();
            this.TxtStockMin = new System.Windows.Forms.MaskedTextBox();
            this.TxtHargaBeli = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtKode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSatuan = new System.Windows.Forms.ComboBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.CmdExit = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdEdit = new System.Windows.Forms.Button();
            this.CmdTambah = new System.Windows.Forms.Button();
            this.CmdRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtRate
            // 
            this.TxtRate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRate.Location = new System.Drawing.Point(578, 114);
            this.TxtRate.Mask = "000%";
            this.TxtRate.Name = "TxtRate";
            this.TxtRate.PromptChar = ' ';
            this.TxtRate.Size = new System.Drawing.Size(52, 25);
            this.TxtRate.TabIndex = 32;
            // 
            // TxtStock
            // 
            this.TxtStock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStock.Location = new System.Drawing.Point(578, 83);
            this.TxtStock.Mask = "0000";
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.PromptChar = ' ';
            this.TxtStock.Size = new System.Drawing.Size(52, 25);
            this.TxtStock.TabIndex = 31;
            // 
            // TxtStockMax
            // 
            this.TxtStockMax.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStockMax.Location = new System.Drawing.Point(578, 52);
            this.TxtStockMax.Mask = "0000";
            this.TxtStockMax.Name = "TxtStockMax";
            this.TxtStockMax.PromptChar = ' ';
            this.TxtStockMax.Size = new System.Drawing.Size(52, 25);
            this.TxtStockMax.TabIndex = 30;
            // 
            // TxtStockMin
            // 
            this.TxtStockMin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStockMin.Location = new System.Drawing.Point(578, 21);
            this.TxtStockMin.Mask = "0000";
            this.TxtStockMin.Name = "TxtStockMin";
            this.TxtStockMin.PromptChar = ' ';
            this.TxtStockMin.Size = new System.Drawing.Size(52, 25);
            this.TxtStockMin.TabIndex = 29;
            // 
            // TxtHargaBeli
            // 
            this.TxtHargaBeli.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHargaBeli.Location = new System.Drawing.Point(151, 112);
            this.TxtHargaBeli.Mask = "Rp 000000000000";
            this.TxtHargaBeli.Name = "TxtHargaBeli";
            this.TxtHargaBeli.PromptChar = ' ';
            this.TxtHargaBeli.Size = new System.Drawing.Size(136, 25);
            this.TxtHargaBeli.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(452, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Rate Jual";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(452, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(452, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Stock Max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(452, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Stock Min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Harga Beli";
            // 
            // TxtNama
            // 
            this.TxtNama.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNama.Location = new System.Drawing.Point(151, 52);
            this.TxtNama.Name = "TxtNama";
            this.TxtNama.Size = new System.Drawing.Size(219, 25);
            this.TxtNama.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Nama Barang";
            // 
            // TxtKode
            // 
            this.TxtKode.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtKode.Location = new System.Drawing.Point(151, 21);
            this.TxtKode.Name = "TxtKode";
            this.TxtKode.Size = new System.Drawing.Size(104, 25);
            this.TxtKode.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Kode Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Satuan";
            // 
            // TxtSatuan
            // 
            this.TxtSatuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtSatuan.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSatuan.FormattingEnabled = true;
            this.TxtSatuan.Items.AddRange(new object[] {
            "Buah",
            "Biji",
            "Lusin",
            "KG",
            "Gram",
            "Liter",
            "ml"});
            this.TxtSatuan.Location = new System.Drawing.Point(151, 81);
            this.TxtSatuan.Name = "TxtSatuan";
            this.TxtSatuan.Size = new System.Drawing.Size(136, 25);
            this.TxtSatuan.TabIndex = 35;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(612, 21);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(648, 191);
            this.Grid.TabIndex = 36;
            this.Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            this.Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellDoubleClick);
            // 
            // CmdExit
            // 
            this.CmdExit.Location = new System.Drawing.Point(578, 218);
            this.CmdExit.Name = "CmdExit";
            this.CmdExit.Size = new System.Drawing.Size(82, 24);
            this.CmdExit.TabIndex = 42;
            this.CmdExit.Text = "&Exit";
            this.CmdExit.UseVisualStyleBackColor = true;
            this.CmdExit.Click += new System.EventHandler(this.CmdExit_Click);
            // 
            // CmdCancel
            // 
            this.CmdCancel.Location = new System.Drawing.Point(489, 218);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(83, 24);
            this.CmdCancel.TabIndex = 41;
            this.CmdCancel.Text = "&Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(399, 218);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(84, 24);
            this.CmdSave.TabIndex = 40;
            this.CmdSave.Text = "&Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(174, 218);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(84, 24);
            this.CmdDelete.TabIndex = 39;
            this.CmdDelete.Text = "&Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // CmdEdit
            // 
            this.CmdEdit.Location = new System.Drawing.Point(93, 218);
            this.CmdEdit.Name = "CmdEdit";
            this.CmdEdit.Size = new System.Drawing.Size(75, 24);
            this.CmdEdit.TabIndex = 38;
            this.CmdEdit.Text = "&Edit";
            this.CmdEdit.UseVisualStyleBackColor = true;
            this.CmdEdit.Click += new System.EventHandler(this.CmdEdit_Click);
            // 
            // CmdTambah
            // 
            this.CmdTambah.Location = new System.Drawing.Point(12, 218);
            this.CmdTambah.Name = "CmdTambah";
            this.CmdTambah.Size = new System.Drawing.Size(75, 24);
            this.CmdTambah.TabIndex = 37;
            this.CmdTambah.Text = "&Tambah";
            this.CmdTambah.UseVisualStyleBackColor = true;
            this.CmdTambah.Click += new System.EventHandler(this.CmdTambah_Click);
            // 
            // CmdRefresh
            // 
            this.CmdRefresh.Location = new System.Drawing.Point(264, 219);
            this.CmdRefresh.Name = "CmdRefresh";
            this.CmdRefresh.Size = new System.Drawing.Size(83, 24);
            this.CmdRefresh.TabIndex = 43;
            this.CmdRefresh.Text = "&Refresh";
            this.CmdRefresh.UseVisualStyleBackColor = true;
            this.CmdRefresh.Click += new System.EventHandler(this.CmdRefresh_Click);
            // 
            // FrmBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 255);
            this.Controls.Add(this.CmdRefresh);
            this.Controls.Add(this.CmdExit);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdEdit);
            this.Controls.Add(this.CmdTambah);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.TxtSatuan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtRate);
            this.Controls.Add(this.TxtStock);
            this.Controls.Add(this.TxtStockMax);
            this.Controls.Add(this.TxtStockMin);
            this.Controls.Add(this.TxtHargaBeli);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNama);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtKode);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBarang";
            this.Text = "Barang";
            this.Load += new System.EventHandler(this.FrmBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox TxtRate;
        private System.Windows.Forms.MaskedTextBox TxtStock;
        private System.Windows.Forms.MaskedTextBox TxtStockMax;
        private System.Windows.Forms.MaskedTextBox TxtStockMin;
        private System.Windows.Forms.MaskedTextBox TxtHargaBeli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtKode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TxtSatuan;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button CmdExit;
        private System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Button CmdEdit;
        private System.Windows.Forms.Button CmdTambah;
        private System.Windows.Forms.Button CmdRefresh;
    }
}