using FishMart.Controller;
using FishMart.Models;
using FishMart.Session;
using FishMart.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishMart.View
{
    public partial class V_ProdukKasir : Form
    {
        private readonly AuthController _authController;
        private readonly ProdukController _produkController;

        public V_ProdukKasir()
        {
            InitializeComponent();
            _authController = new AuthController();
            _produkController = new ProdukController();
        }

        private void V_ProdukKasir_Load(object sender, EventArgs e)
        {
            lblUsername.Text = UserSession.Username;
            lblEmail.Text = UserSession.Email;
            List<Produk> produks = _produkController.GetListProduk().OrderBy(p => p.Id).ToList();
            GenerateProductCardsKasir(produks);
        }

        private void btnTKasir_Click(object sender, EventArgs e)
        {
            this.Close();
            V_Transaksi v_Transaksi = new V_Transaksi();
            v_Transaksi.Show();
        }

        private void btnRTKasir_Click(object sender, EventArgs e)
        {
            this.Close();
            V_RiwayatTransaksiKasir RWTKasir = new V_RiwayatTransaksiKasir(); 
            RWTKasir.Show();
        }

        private void btnProdukKasir_Click(object sender, EventArgs e)
        {
            this.Close();
            V_ProdukKasir produkKasir = new V_ProdukKasir();
            produkKasir.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _authController.logout(this);
        }

        private void GenerateProductCardsKasir(List<Produk> dt)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var produk in dt)
            {
                Panel card = new Panel
                {
                    Size = new Size(970, 90),
                    BackgroundImage = Properties.Resources.bgProduk,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Margin = new Padding(2)
                };

                int offsetX = 12;
                int offsetY = 10;

                // === GAMBAR PRODUK ===
                PictureBox pic = new PictureBox
                {
                    Size = new Size(55, 55),
                    Location = new Point(offsetX + 10, offsetY + 5),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BackColor = Color.Transparent
                };

                if (produk.GambarProduk != null)
                {
                    using var ms = new MemoryStream(produk.GambarProduk);
                    pic.Image = Image.FromStream(ms);
                }

                // === NAMA PRODUK ===
                Label lblNama = new Label
                {
                    Text = produk.Nama,
                    Font = new Font("Poppins", 12, FontStyle.Bold),
                    ForeColor = Color.Black,
                    BackColor = Color.Transparent,
                    Location = new Point(offsetX + 80, offsetY + 15),
                    Size = new Size(260, 30)
                };

                // === HARGA PRODUK (DI SEBELAH KANAN NAMA) ===
                Label lblHarga = new Label
                {
                    Text = "Rp " + produk.Harga.ToString("N0"),
                    Font = new Font("Poppins", 12, FontStyle.Bold),
                    ForeColor = Color.Black,
                    BackColor = Color.Transparent,
                    Location = new Point(offsetX + 400, offsetY + 17),
                    Size = new Size(180, 30)
                };

                // === STOK ===
                Label lblStok = new Label
                {
                    Text = produk.Stok.ToString(),
                    Font = new Font("Poppins", 12, FontStyle.Bold),
                    BackColor = Color.Transparent,
                    Location = new Point(offsetX + 870, offsetY + 17),
                    Size = new Size(80, 30)
                };

                // Add Controls
                card.Controls.Add(pic);
                card.Controls.Add(lblNama);
                card.Controls.Add(lblHarga);
                card.Controls.Add(lblStok);

                flowLayoutPanel1.Controls.Add(card);
            }
        }


    }
}
