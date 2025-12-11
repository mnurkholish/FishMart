using FishMart.Controller;
using FishMart.Models;
using FishMart.Session;
using System.Data;

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
            List<Produk> produks = _produkController.GetListProduk().OrderBy(p => p.Id).ToList();
            GenerateProductCards(produks);
        }

        private void GenerateProductCards(List<Produk> dt)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var produk in dt)
            {
                Panel card = new Panel
                {
                    Size = new Size(973, 90),
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

                // === INPUT JUMLAH (TextBox) ===
                TextBox tbJumlah = new TextBox
                {
                    Text = produk.Stok.ToString(),
                    Font = new Font("Poppins", 10, FontStyle.Regular),
                    Size = new Size(60, 35),
                    Location = new Point(offsetX + 413, offsetY + 18),
                    TextAlign = HorizontalAlignment.Center
                };

                tbJumlah.KeyDown += (s, e) =>
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        if (int.TryParse(tbJumlah.Text, out int stokBaru))
                        {
                            if (stokBaru < 0)
                            {
                                MessageBox.Show("Stok tidak boleh kurang dari 0.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                tbJumlah.Focus();
                            }
                            else
                            {
                                produk.Stok = stokBaru;
                                _produkController.UpdateProduk(produk);
                                RefreshProduk();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Stok harus berupa angka.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tbJumlah.Focus();
                        }
                    }
                };


                // === MIN BUTTON ===
                Button btnMinus = new Button
                {
                    BackgroundImage = Properties.Resources.minus_icon,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Font = new Font("Poppins", 16, FontStyle.Bold),
                    Size = new Size(35, 35),
                    Location = new Point(offsetX + 373, offsetY + 18),
                    BackColor = Color.FromArgb(230, 230, 230)
                };
                btnMinus.Click += (s, e) =>
                {
                    int stok = int.Parse(tbJumlah.Text);
                    if (stok > 0) stok--;
                    tbJumlah.Text = stok.ToString();

                    produk.Stok = stok;
                    _produkController.UpdateProduk(produk);
                    RefreshProduk();
                };

                // === PLUS BUTTON ===
                Button btnPlus = new Button
                {
                    BackgroundImage = Properties.Resources.plus_icon,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Font = new Font("Poppins", 16, FontStyle.Bold),
                    Size = new Size(35, 35),
                    Location = new Point(offsetX + 478, offsetY + 18),
                    BackColor = Color.FromArgb(230, 230, 230)
                };
                btnPlus.Click += (s, e) =>
                {
                    int stok = int.Parse(tbJumlah.Text);
                    stok++;
                    tbJumlah.Text = stok.ToString();

                    produk.Stok = stok;
                    _produkController.UpdateProduk(produk);
                    RefreshProduk();
                };

                // === EDIT BUTTON ===
                Button btnEdit = new Button
                {
                    BackgroundImage = Properties.Resources.edit_icon,
                    BackgroundImageLayout = ImageLayout.Zoom,
                    Font = new Font("Poppins", 11, FontStyle.Bold),
                    Size = new Size(90, 40),
                    Location = new Point(offsetX + 765, offsetY + 15),
                    BackColor = Color.DodgerBlue,
                    ForeColor = Color.White
                };
                btnEdit.Click += (s, e) =>
                {
                    V_EditProduk formEdit = new V_EditProduk(produk);
                    formEdit.ShowDialog();
                    RefreshProduk();
                };


                // === DELETE BUTTON ===
                Button btnDelete = new Button
                {
                    BackgroundImage = Properties.Resources.trash_icon,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Poppins", 14, FontStyle.Regular),
                    Size = new Size(37, 37),
                    Location = new Point(offsetX + 865, offsetY + 15),
                    ForeColor = Color.White
                };
                btnDelete.FlatAppearance.BorderSize = 0;
                btnDelete.Click += (s, e) =>
                {
                    var confirm = MessageBox.Show(
                        "Yakin ingin menghapus produk ini?",
                        "Konfirmasi Hapus",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirm == DialogResult.Yes)
                    {
                        _produkController.DeleteProduk(produk.Id);
                        RefreshProduk();
                    }
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

        private void BtnTambahProduk_Click(object sender, EventArgs e)
        {
            V_TambahProduk formTambah = new V_TambahProduk();
            formTambah.ShowDialog();
            RefreshProduk();
        }

        private void RefreshProduk()
        {
            List<Produk> produks = _produkController.GetListProduk().OrderBy(p => p.Id).ToList();
            GenerateProductCards(produks);
        }

    }
}
