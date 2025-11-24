using FishMart.Controler;
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
using System.IO;   // ❗ WAJIB untuk MemoryStream

namespace FishMart.View
{
    public partial class V_DashboardAdmin : Form
    {
        private readonly AuthController _authController;

        public V_DashboardAdmin(AuthController authController)
        {
            InitializeComponent();
            _authController = authController;

        }

        private void V_DashboardAdmin_Load(object sender, EventArgs e)
        {
            DataTable dt = Database.GetProducts();
            GenerateProductCards(dt);
        }

        private void GenerateProductCards(DataTable dt)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow row in dt.Rows)
            {
                Panel card = new Panel
                {
                    Size = new Size(149, 204),                // ukuran sama seperti background
                    BackgroundImage = Properties.Resources.cardProduk,
                    BackgroundImageLayout = ImageLayout.Zoom,
                    BorderStyle = BorderStyle.None,
                    Margin = new Padding(6)
                    
                };

                PictureBox pic = new PictureBox
                {
                    Size = new Size(90, 90),                 // diperkecil agar proporsional
                    BackColor = Color.Transparent,
                    Location = new Point((149 - 90) / 2, 15), // center otomatis
                    SizeMode = PictureBoxSizeMode.Zoom
                };

                // Convert BYTEA → Image
                if (row["gambar_produk"] != DBNull.Value)
                {
                    byte[] imgBytes = (byte[])row["gambar_produk"];
                    using (MemoryStream ms = new MemoryStream(imgBytes))
                    {
                        pic.Image = Image.FromStream(ms);
                    }
                }

                Label nama = new Label
                {
                    Text = row["nama_produk"].ToString(),
                    Font = new Font("SF Pro Display", 10, FontStyle.Bold),
                    BackColor = Color.Transparent,
                    Location = new Point(5, 120),
                    Size = new Size(139, 20),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                Label harga = new Label
                {
                    Text = "Rp " + row["harga"].ToString(),
                    Font = new Font("SF Pro Display", 11, FontStyle.Bold),
                    BackColor = Color.Transparent,
                    Location = new Point(5, 145),
                    Size = new Size(139, 22),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                card.Controls.Add(pic);
                card.Controls.Add(nama);
                card.Controls.Add(harga);

                flowLayoutPanel1.Controls.Add(card);
            }
        }

    }
}
