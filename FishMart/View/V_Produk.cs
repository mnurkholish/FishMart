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
    public partial class V_Produk : Form
    {
        private readonly AuthController _authController;
        private readonly ProdukController _produkController;

        public V_Produk()
        {
            InitializeComponent();
            _authController = new AuthController();
            _produkController = new ProdukController();
        }

        private void V_Produk_Load(object sender, EventArgs e)
        {
            lblUsername.Text = UserSession.Username;
            lblEmail.Text = UserSession.Email;
            List<Produk> produks = _produkController.GetListProduk();
            GenerateProductCards(produks);
        }

        private void GenerateProductCards(List<Produk> dt)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var produk in dt)
            {
                // Panel mengikuti aset Figma 954x71 + shadow offset
                Panel card = new Panel
                {
                    Size = new Size(930, 90),  // ukuran aman untuk shadow
                    BackgroundImage = Properties.Resources.bgProduk,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Margin = new Padding(2)
                };

                // SHADOW OFFSET (karena PNG ada shadow sekitar 10px)
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
                    Font = new Font("Poppins", 12, FontStyle.Regular),
                    ForeColor = Color.Black,
                    BackColor = Color.Transparent,
                    Location = new Point(offsetX + 80, offsetY + 2),
                    Size = new Size(260, 30)
                };

                // === HARGA PRODUK ===
                Label lblHarga = new Label
                {
                    Text = "Rp " + produk.Harga.ToString("N0"),
                    Font = new Font("Poppins", 10, FontStyle.Regular),
                    ForeColor = Color.Black,
                    BackColor = Color.Transparent,
                    Location = new Point(offsetX + 80, offsetY + 33),
                    Size = new Size(250, 25)
                };

                // === MIN BUTTON ===
                Button btnMinus = new Button
                {
                    BackgroundImage = Properties.Resources.minus_icon,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Font = new Font("Poppins", 16, FontStyle.Bold),
                    Size = new Size(35, 35),
                    Location = new Point(offsetX + 360, offsetY + 18),
                    BackColor = Color.FromArgb(230, 230, 230)
                };

                // === INPUT JUMLAH (TextBox) ===
                TextBox tbJumlah = new TextBox
                {
                    Text = produk.Stok.ToString(),
                    Font = new Font("Poppins", 10, FontStyle.Regular),
                    Size = new Size(60, 35),
                    Location = new Point(offsetX + 400, offsetY + 18),
                    TextAlign = HorizontalAlignment.Center
                };

                // === PLUS BUTTON ===
                Button btnPlus = new Button
                {
                    BackgroundImage = Properties.Resources.plus_icon,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Font = new Font("Poppins", 16, FontStyle.Bold),
                    Size = new Size(35, 35),
                    Location = new Point(offsetX + 465, offsetY + 18),
                    BackColor = Color.FromArgb(230, 230, 230)
                };

                // === EDIT BUTTON ===
                Button btnEdit = new Button
                {
                    BackgroundImage = Properties.Resources.edit_icon,
                    BackgroundImageLayout = ImageLayout.Zoom,
                    Font = new Font("Poppins", 11, FontStyle.Bold),
                    Size = new Size(90, 40),
                    Location = new Point(offsetX + 650, offsetY + 15),
                    BackColor = Color.DodgerBlue,
                    ForeColor = Color.White
                };

                // === DELETE BUTTON ===
                Button btnDelete = new Button
                {
                    BackgroundImage = Properties.Resources.trash_icon,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Font = new Font("Poppins", 14, FontStyle.Regular),
                    Size = new Size(40, 40),
                    Location = new Point(offsetX + 750, offsetY + 15),
                    ForeColor = Color.White
                };

                // Add Controls
                card.Controls.Add(pic);
                card.Controls.Add(lblNama);
                card.Controls.Add(lblHarga);
                card.Controls.Add(btnMinus);
                card.Controls.Add(tbJumlah);
                card.Controls.Add(btnPlus);
                card.Controls.Add(btnEdit);
                card.Controls.Add(btnDelete);

                flowLayoutPanel1.Controls.Add(card);
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
