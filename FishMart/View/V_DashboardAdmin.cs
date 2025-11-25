using FishMart.Controller;
using FishMart.Models;
using FishMart.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;   // ❗ WAJIB untuk MemoryStream
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishMart.View
{
    public partial class V_DashboardAdmin : Form
    {
        private readonly AuthController _authController;
        private readonly ProdukController _produkController;

        public V_DashboardAdmin()
        {
            InitializeComponent();
            _authController = new AuthController();
            _produkController = new ProdukController();
        }

        private void V_DashboardAdmin_Load(object sender, EventArgs e)
        {
            List<Produk> listProduks = _produkController.GetListProduk();
            GenerateProductCards(listProduks);
        }

        private void GenerateProductCards(List<Produk> produkList)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.AutoScroll = true;

            foreach (var produk in produkList)
            {
                // --- Card Panel ---
                Panel card = new Panel
                {
                    Width = 150,
                    Height = 210,
                    BackgroundImage = Properties.Resources.cardProduk,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    BorderStyle = BorderStyle.None,
                    Margin = new Padding(4),
                    Padding = new Padding(0),
                };

                // --- Picture ---
                PictureBox pic = new PictureBox
                {
                    Width = 95,
                    Height = 95,
                    BackColor = Color.Transparent,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Left = (card.Width - 95) / 2,
                    Top = 15
                };

                if (produk.GambarProduk != null)
                {
                    using var ms = new MemoryStream(produk.GambarProduk);
                    pic.Image = Image.FromStream(ms);
                }

                // --- Nama Produk ---
                Label nama = new Label
                {
                    AutoSize = false,
                    Text = produk.Nama,
                    Font = new Font("SF Pro Display", 10, FontStyle.Bold),
                    BackColor = Color.Transparent,
                    ForeColor = Color.Black,
                    Width = card.Width - 10,
                    Height = 22,
                    Top = pic.Bottom + 10,
                    Left = 5,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                // --- Harga Produk ---
                Label harga = new Label
                {
                    AutoSize = false,
                    Text = "Rp " + produk.Harga.ToString("N0"),
                    Font = new Font("SF Pro Display", 11, FontStyle.Bold),
                    BackColor = Color.Transparent,
                    ForeColor = Color.Firebrick,
                    Width = card.Width - 10,
                    Height = 24,
                    Top = nama.Bottom + 5,
                    Left = 5,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                // Menambahkan ke card
                card.Controls.Add(pic);
                card.Controls.Add(nama);
                card.Controls.Add(harga);

                // Tambah ke flowLayoutPanel
                flowLayoutPanel1.Controls.Add(card);
            }
        }

    }
}
