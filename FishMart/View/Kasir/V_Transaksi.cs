using FishMart.Controller;
using FishMart.Models;
using FishMart.Session;
using FishMart.View.Kasir;
using System.Data;

namespace FishMart.View
{
    public partial class V_Transaksi : Form
    {
        private readonly AuthController _authController;
        private readonly ProdukController _produkController;
        private List<Panel> cartItems = new List<Panel>();
        private Dictionary<int, int> cartQuantities = new Dictionary<int, int>();
        private Dictionary<int, Panel> cartPanelsById = new Dictionary<int, Panel>();

        public V_Transaksi()
        {
            InitializeComponent();
            _authController = new AuthController();
            _produkController = new ProdukController();
        }

        private void V_Transaksi_Load(object sender, EventArgs e)
        {
            lblUsername.Text = UserSession.Username;
            lblEmail.Text = UserSession.Email;
            List<Produk> produks = _produkController.GetListProduk().OrderBy(p => p.Id).ToList();
            GenerateProductCards(produks);
            RecalculateTotal();
        }

        private void GenerateProductCards(List<Produk> produkList)
        {
            PanelDisplayProduk.Controls.Clear();
            PanelDisplayProduk.AutoScroll = true;

            foreach (var produk in produkList)
            {
                // skip produk yang stoknya 0 (opsional)
                if (produk.Stok <= 0) continue;

                Panel card = new Panel
                {
                    Width = 180,
                    Height = 260,
                    BackgroundImage = Properties.Resources.cardProduk,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    BorderStyle = BorderStyle.None,
                    Margin = new Padding(2),
                    Padding = new Padding(0),
                    Tag = produk
                };

                PictureBox pic = new PictureBox
                {
                    Width = 100,
                    Height = 100,
                    BackColor = Color.Transparent,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Left = (card.Width - 100) / 2,
                    Top = 20
                };

                if (produk.GambarProduk != null && produk.GambarProduk.Length > 0)
                {
                    try
                    {
                        using var ms = new MemoryStream(produk.GambarProduk);
                        pic.Image = Image.FromStream(ms);
                    }
                    catch { /* ignore image load errors */ }
                }

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

                Button btnPlus = new Button
                {
                    BackgroundImage = Properties.Resources.plus_icon,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Width = 36,
                    Height = 36,
                    Top = harga.Bottom + 15,
                    Left = (card.Width - 36) / 2,
                    FlatStyle = FlatStyle.Flat
                };
                btnPlus.FlatAppearance.BorderSize = 0;

                // klik tambah ke keranjang
                btnPlus.Click += (s, e) =>
                {
                    AddOrIncrementCartItem(produk);
                };

                card.Controls.Add(pic);
                card.Controls.Add(nama);
                card.Controls.Add(harga);
                card.Controls.Add(btnPlus);

                PanelDisplayProduk.Controls.Add(card);
            }
        }

        private void AddOrIncrementCartItem(Produk produk)
        {
            if (cartPanelsById.TryGetValue(produk.Id, out Panel existingPanel))
            {
                // sudah ada di keranjang -> tambah 1 (cek stok)
                if (cartQuantities.TryGetValue(produk.Id, out int currentQty))
                {
                    if (currentQty + 1 > produk.Stok)
                    {
                        MessageBox.Show($"Stok tidak cukup. Maks: {produk.Stok}", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    UpdateCartItemQuantity(existingPanel, produk.Id, 1);
                }
            }
            else
            {
                // belum ada -> tambah baru
                Panel cartPanel = CreateCartItemPanel(produk, 1);
                cartItems.Add(cartPanel);
                cartPanelsById[produk.Id] = cartPanel;
                cartQuantities[produk.Id] = 1;
                PanelCart.Controls.Add(cartPanel);
            }
            RecalculateTotal();
        }

        private Panel CreateCartItemPanel(Produk produk, int jumlah)
        {
            Panel panel = new Panel
            {
                Width = 379,      // ukuran dengan shadow
                Height = 91,
                BackgroundImage = Properties.Resources.bgDaftarTransaksi,
                BackgroundImageLayout = ImageLayout.Stretch,
                Margin = new Padding(4),
                Padding = new Padding(0),
                Tag = produk
            };

            // Offset agar isi tetap pas dengan ukuran asli tanpa shadow (358x71)
            int offsetX = 11;
            int offsetY = 10;

            PictureBox pic = new PictureBox
            {
                Width = 50,
                Height = 50,
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.Transparent,
                Left = offsetX + 10,
                Top = offsetY + (67 - 50) / 2
            };

            if (produk.GambarProduk != null && produk.GambarProduk.Length > 0)
            {
                try
                {
                    using var ms = new MemoryStream(produk.GambarProduk);
                    pic.Image = Image.FromStream(ms);
                }
                catch { }
            }

            Label lblNamaProduk = new Label
            {
                AutoSize = false,
                Text = produk.Nama,
                Font = new Font("Poppins", 9, FontStyle.Bold),
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
                Width = 150,
                Height = 22,
                Left = pic.Right + 5,
                Top = offsetY + 8,
                TextAlign = ContentAlignment.MiddleLeft
            };

            Label lblHarga = new Label
            {
                AutoSize = false,
                Text = "Rp " + (produk.Harga * jumlah).ToString("N0"),
                Font = new Font("Poppins", 9, FontStyle.Bold),
                BackColor = Color.Transparent,
                ForeColor = Color.Firebrick,
                Width = 150,
                Height = 22,
                Left = pic.Right + 5,
                Top = lblNamaProduk.Bottom + 2,
                TextAlign = ContentAlignment.MiddleLeft
            };

            // Tombol dan textbox berada di ujung kanan area isi (358px)
            int isiRight = offsetX + 358;

            Button btnHapus = new Button
            {
                BackgroundImage = Properties.Resources.trash_icon,
                BackgroundImageLayout = ImageLayout.Stretch,
                Width = 26,
                Height = 26,
                Left = isiRight - 135,
                Top = offsetY + (71 - 26) / 2,
                FlatStyle = FlatStyle.Flat
            };
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.Click += (s, e) => RemoveCartItem(panel, produk.Id);

            TextBox txtJumlah = new TextBox
            {
                Name = "txtJumlah",
                Text = jumlah.ToString(),
                Width = 35,
                Height = 24,
                Font = new Font("Poppins", 9),
                TextAlign = HorizontalAlignment.Center,
                Left = isiRight - 70,
                Top = offsetY + (68 - 24) / 2,
                BorderStyle = BorderStyle.None,
            };

            txtJumlah.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (int.TryParse(txtJumlah.Text, out int newJumlah) && newJumlah > 0)
                    {
                        if (newJumlah > produk.Stok)
                        {
                            MessageBox.Show($"Jumlah melebihi stok ({produk.Stok})", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtJumlah.Text = produk.Stok.ToString();
                            UpdateCartItemQuantity(panel, produk.Id, 0, produk.Stok);
                        }
                        else
                        {
                            UpdateCartItemQuantity(panel, produk.Id, 0, newJumlah);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Jumlah tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtJumlah.Text = cartQuantities.ContainsKey(produk.Id)
                            ? cartQuantities[produk.Id].ToString()
                            : "1";
                    }
                    e.SuppressKeyPress = true;
                }
            };

            Button btnMinus = new Button
            {
                BackgroundImage = Properties.Resources.minus_icon,
                BackgroundImageLayout = ImageLayout.Stretch,
                Width = 26,
                Height = 26,
                Left = isiRight - 100,
                Top = offsetY + (71 - 26) / 2,
                FlatStyle = FlatStyle.Flat
            };
            btnMinus.FlatAppearance.BorderSize = 0;
            btnMinus.Click += (s, e) =>
            {
                if (int.TryParse(txtJumlah.Text, out int cur))
                {
                    if (cur > 1) UpdateCartItemQuantity(panel, produk.Id, -1);
                    else RemoveCartItem(panel, produk.Id);
                }
            };

            Button btnPlus = new Button
            {
                BackgroundImage = Properties.Resources.plus_icon,
                BackgroundImageLayout = ImageLayout.Stretch,
                Width = 26,
                Height = 26,
                Left = isiRight - 35,
                Top = offsetY + (71 - 26) / 2,
                FlatStyle = FlatStyle.Flat
            };
            btnPlus.FlatAppearance.BorderSize = 0;
            btnPlus.Click += (s, e) => UpdateCartItemQuantity(panel, produk.Id, 1);

            // Add Controls
            panel.Controls.Add(pic);
            panel.Controls.Add(lblNamaProduk);
            panel.Controls.Add(lblHarga);
            panel.Controls.Add(btnHapus);
            panel.Controls.Add(btnMinus);
            panel.Controls.Add(txtJumlah);
            panel.Controls.Add(btnPlus);

            return panel;
        }


        private void UpdateCartItemQuantity(Panel cartitem, int produkId, int increment, int setExactValue = -1)
        {
            var txtJumlah = cartitem.Controls.OfType<TextBox>().FirstOrDefault(t => t.Name == "txtJumlah");
            var lblHarga = cartitem.Controls.OfType<Label>().FirstOrDefault(l => l != null && l.ForeColor == Color.Firebrick);

            if (txtJumlah == null || lblHarga == null) return;

            int current = 1;
            if (!int.TryParse(txtJumlah.Text, out current)) current = 1;

            Produk produk = _produkController.GetListProduk().FirstOrDefault(p => p.Id == produkId);
            if (produk == null) return;

            int newQty;
            if (increment != 0)
            {
                newQty = current + increment;
            }
            else if (setExactValue >= 0)
            {
                newQty = setExactValue;
            }
            else
            {
                newQty = current;
            }

            if (newQty <= 0)
            {
                // hapus
                RemoveCartItem(cartitem, produkId);
                return;
            }

            if (newQty > produk.Stok)
            {
                MessageBox.Show($"Stok tidak mencukupi. Stok tersedia: {produk.Stok}", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                newQty = produk.Stok;
            }

            txtJumlah.Text = newQty.ToString();
            lblHarga.Text = "Rp " + (produk.Harga * newQty).ToString("N0");

            cartQuantities[produkId] = newQty;

            RecalculateTotal();
        }

        private void RemoveCartItem(Panel panel, int produkId)
        {
            if (PanelCart.Controls.Contains(panel))
            {
                PanelCart.Controls.Remove(panel);
            }
            cartItems.Remove(panel);
            cartPanelsById.Remove(produkId);
            cartQuantities.Remove(produkId);

            RecalculateTotal();
        }

        private void RecalculateTotal()
        {
            long total = 0;
            foreach (var kv in cartPanelsById)
            {
                int pid = kv.Key;
                Panel panel = kv.Value;
                if (panel.Tag is Produk produk)
                {
                    if (cartQuantities.TryGetValue(pid, out int qty))
                    {
                        total += (long)produk.Harga * qty;
                    }
                    else
                    {
                        // fallback: coba baca textbox
                        var txt = panel.Controls.OfType<TextBox>().FirstOrDefault(t => t.Name == "txtJumlah");
                        if (txt != null && int.TryParse(txt.Text, out int q))
                        {
                            total += (long)produk.Harga * q;
                            cartQuantities[pid] = q;
                        }
                    }
                }
            }

            lblTotalHarga.Text = "Rp " + total.ToString("N0");
        }

        private List<DetailTransaksi> BuildDetailTransaksiList()
        {
            List<DetailTransaksi> list = new List<DetailTransaksi>();

            foreach (var kv in cartPanelsById)
            {
                int produkId = kv.Key;
                Panel panel = kv.Value;

                if (panel.Tag is Produk p)
                {
                    int qty = cartQuantities[produkId];
                    list.Add(new DetailTransaksi
                    {
                        ProdukId = produkId,
                        Qty = qty,
                        HargaSatuan = p.Harga,
                        Subtotal = qty * p.Harga
                    });
                }
            }

            return list;
        }

        private Transaksi BuildTransaksi()
        {
            long total = 0;
            foreach (var kv in cartQuantities)
            {
                int pid = kv.Key;
                int qty = kv.Value;

                Produk p = _produkController.GetListProduk().First(pr => pr.Id == pid);
                total += p.Harga * qty;
            }

            return new Transaksi
            {
                UserId = UserSession.Id,
                TotalHarga = (int)total,
                Tanggal = DateTime.Now
            };
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (cartPanelsById.Count == 0)
            {
                MessageBox.Show("Keranjang belanja kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var result = MessageBox.Show($"Total: {lblTotalHarga.Text}\nLanjutkan transaksi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            Transaksi transaksi = BuildTransaksi();
            List<DetailTransaksi> details = BuildDetailTransaksiList();

            var formCheckout = new V_FormCheckout(transaksi, details);
            formCheckout.ShowDialog();

            PanelCart.Controls.Clear();
            cartItems.Clear();
            cartPanelsById.Clear();
            cartQuantities.Clear();
            RecalculateTotal();

            var produks = _produkController.GetListProduk().OrderBy(p => p.Id).ToList();
            GenerateProductCards(produks);
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
    }
}
