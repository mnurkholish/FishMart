using FishMart.Controller;
using FishMart.Utils;
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
    public partial class V_Produk : Form
    {
        private readonly AuthController _authController;
        public V_Produk()
        {
            InitializeComponent();
            _authController = new AuthController();
        }

        private void GenerateProductCards(DataTable dt)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow row in dt.Rows)
            {
                // Panel mengikuti aset Figma 954x71 + shadow offset
                Panel card = new Panel
                {
                    Size = new Size(974, 91),  // ukuran aman untuk shadow
                    BackgroundImage = Properties.Resources.bgProduk,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Margin = new Padding(6)
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

                if (row["gambar_produk"] != DBNull.Value)
                {
                    byte[] bytes = (byte[])row["gambar_produk"];
                    using MemoryStream ms = new MemoryStream(bytes);
                    pic.Image = Image.FromStream(ms);
                }

                // === NAMA PRODUK ===
                Label lblNama = new Label
                {
                    Text = row["nama_produk"].ToString(),
                    Font = new Font("SF Pro Display", 14, FontStyle.Bold),
                    ForeColor = Color.Black,
                    BackColor = Color.Transparent,
                    Location = new Point(offsetX + 80, offsetY + 2),
                    Size = new Size(260, 30)
                };

                // === HARGA PRODUK ===
                Label lblHarga = new Label
                {
                    Text = "Rp " + row["harga"],
                    Font = new Font("SF Pro Display", 12, FontStyle.Regular),
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
                    Font = new Font("SF Pro Display", 16, FontStyle.Bold),
                    Size = new Size(35, 35),
                    Location = new Point(offsetX + 360, offsetY + 18),
                    BackColor = Color.FromArgb(230, 230, 230)
                };

                // === INPUT JUMLAH (TextBox) ===
                TextBox tbJumlah = new TextBox
                {
                    Text = row["stok"].ToString(),
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    Size = new Size(60, 35),
                    Location = new Point(offsetX + 400, offsetY + 18),
                    TextAlign = HorizontalAlignment.Center
                };

                // === PLUS BUTTON ===
                Button btnPlus = new Button
                {
                    BackgroundImage = Properties.Resources.plus_icon,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Font = new Font("SF Pro Display", 16, FontStyle.Bold),
                    Size = new Size(35, 35),
                    Location = new Point(offsetX + 465, offsetY + 18),
                    BackColor = Color.FromArgb(230, 230, 230)
                };

                // === EDIT BUTTON ===
                Button btnEdit = new Button
                {
                    BackgroundImage = Properties.Resources.edit_icon,
                    BackgroundImageLayout = ImageLayout.Zoom,
                    Font = new Font("SF Pro Display", 11, FontStyle.Bold),
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
                    Font = new Font("SF Pro Display", 16, FontStyle.Bold),
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
        private void V_Produk_Load(object sender, EventArgs e)
        {
            DataTable dt = Database.GetProducts();
            GenerateProductCards(dt);
        }
    }
}
