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
    public partial class V_DashboardAdmin : Form
    {
        private readonly AuthController _authController;
        private readonly ProdukController _produkController;
        private readonly TransaksiController _transaksiController;

        public V_DashboardAdmin()
        {
            InitializeComponent();
            _authController = new AuthController();
            _produkController = new ProdukController();
            _transaksiController = new TransaksiController();
        }

        private void V_DashboardAdmin_Load(object sender, EventArgs e)
        {
            lblUsername.Text = UserSession.Username;
            lblEmail.Text = UserSession.Email;
            Produk hampirHabis = _produkController.GetProdukHampirHabis();
            lblProdukStokHampirHabis.Text = hampirHabis?.Nama ?? "Tidak ada";
            lblStokHampirHabis.Text = hampirHabis != null ? $"sisa {hampirHabis.Stok} ekor" : "";
            int display = 4;
            List<Produk> listProduks = _produkController.GetListProduk(display);
            GenerateProductCards(listProduks);

            lblPemasukanHariIni.Text = $"Rp {_transaksiController.GetPemasukanHariIni():N0}";
            lblJumlahTransaksi.Text = _transaksiController.GetJumlahTransaksiBulanIni().ToString();
            lblTotalPenjualanBulanan.Text = $"Rp {_transaksiController.GetTotalPemasukanBulanIni():N0}";
        }

        private void GenerateProductCards(List<Produk> produkList)
        {
            PanelDisplayProduk.Controls.Clear();
            PanelDisplayProduk.AutoScroll = true;

            foreach (var produk in produkList)
            {
                // --- Card Panel ---
                Panel card = new Panel
                {
                    Width = 220,
                    Height = 240,
                    BackgroundImage = Properties.Resources.cardProduk,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    BorderStyle = BorderStyle.None,
                    Margin = new Padding(9),
                    Padding = new Padding(0),
                };

                // --- Picture ---
                PictureBox pic = new PictureBox
                {
                    Width = 110,
                    Height = 110,
                    BackColor = Color.Transparent,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Left = (card.Width - 110) / 2,
                    Top = 40
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
                    Top = pic.Bottom + 15,
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
                PanelDisplayProduk.Controls.Add(card);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
            V_DashboardAdmin dasborAdmin = new V_DashboardAdmin();
            dasborAdmin.Show();
        }

        private void btnProduk_Click(object sender, EventArgs e)
        {
            this.Close();
            V_Produk produk = new V_Produk();
            produk.Show();
        }

        private void btnRiwayatTransaksi_Click(object sender, EventArgs e)
        {
            this.Close();
            V_RiwayatTransaksi riwayatTransaksi = new V_RiwayatTransaksi();
            riwayatTransaksi.Show();
        }

        private void btnAkunKasir_Click(object sender, EventArgs e)
        {
            this.Close();
            V_AkunKasir akunKasir = new V_AkunKasir();
            akunKasir.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _authController.logout(this);
        }
    }
}
