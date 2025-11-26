using FishMart.Controller;
using FishMart.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishMart.View
{
    public partial class V_TambahProduk : Form
    {
        private readonly ProdukController _produkController;
        public V_TambahProduk()
        {
            InitializeComponent();
            _produkController = new ProdukController();
        }

        private void gambarProduk_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                gambarProduk.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btnTambahProduk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNamaProduk.Text) ||
                string.IsNullOrWhiteSpace(tbHarga.Text) ||
                string.IsNullOrWhiteSpace(tbStok.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (gambarProduk.Image == null)
            {
                MessageBox.Show("Gambar produk harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] imgBytes = null;
            using (MemoryStream ms = new MemoryStream())
            {
                gambarProduk.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imgBytes = ms.ToArray();
            }

            Produk produk = new Produk
            {
                Nama = tbNamaProduk.Text,
                Harga = int.Parse(tbHarga.Text),
                Stok = int.Parse(tbStok.Text),
                GambarProduk = imgBytes
            };

            _produkController.InsertProduk(produk);

            MessageBox.Show("Produk berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
