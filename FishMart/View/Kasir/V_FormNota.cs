using FishMart.Controller;
using FishMart.Models;

namespace FishMart.View.Kasir
{
    public partial class V_FormNota : Form
    {
        private readonly int _uangBayar;
        private readonly Transaksi _trx;
        private readonly List<DetailTransaksi> _details;
        private readonly ProdukController _produkController;

        public V_FormNota(int uangBayar, Transaksi trx, List<DetailTransaksi> details)
        {
            InitializeComponent();
            _uangBayar = uangBayar;
            _trx = trx;
            _details = details;
            _produkController = new ProdukController();

            panelContainer.AutoSize = true;
            panelContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.MinimumSize = new Size(250, 50);

            flowLayoutPanel1.Layout += FlowLayoutPanel1_Layout;
            flowLayoutPanel1.ControlAdded += FlowLayoutPanel1_ControlAdded;

            V_FormNota_Load(this, EventArgs.Empty);
        }

        private void V_FormNota_Load(object sender, EventArgs e)
        {
            lblTanggal.Text = _trx.Tanggal.ToString("yyyy-MM-dd HH:mm");
            lblNoTransaksi.Text = $"No Transaksi : {_trx.Id}";

            flowLayoutPanel1.Controls.Clear();

            foreach (var d in _details)
            {
                var produk = _produkController.GetProdukById(d.ProdukId);

                Panel item = new Panel()
                {
                    BackColor = Color.Transparent,
                    Width = 358,
                    Height = 60,
                    Margin = new Padding(0, 0, 0, 0)
                };

                // Nama produk
                item.Controls.Add(new Label()
                {
                    BackColor = Color.Transparent,
                    Text = produk.Nama,
                    Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0),
                    AutoSize = true,
                    Left = 10,
                    Top = 5
                });

                // qty x harga
                item.Controls.Add(new Label()
                {
                    BackColor = Color.Transparent,
                    Text = $"{d.Qty} x {produk.Harga:N0}",
                    AutoSize = true,
                    Left = 10,
                    Top = 30
                });

                // Subtotal
                item.Controls.Add(new Label()
                {
                    BackColor = Color.Transparent,
                    Text = $"Rp {d.Subtotal:N0}",
                    Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0),
                    AutoSize = true,
                    Left = 358 - 120,
                    Top = 20
                });

                flowLayoutPanel1.Controls.Add(item);

                Label separator = new Label()
                {
                    Width = 358,
                    Height = 1,
                    BackColor = Color.Gray,
                    Margin = new Padding(0, 0, 0, 5)
                };

                flowLayoutPanel1.Controls.Add(separator);
            }

            Label totalLabel = new Label()
            {
                Text = $"TOTAL : Rp {_trx.TotalHarga:N0}",
                Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0),
                Width = 358,
                Height = 30,
                TextAlign = ContentAlignment.MiddleRight,
                Padding = new Padding(0, 0, 10, 0),
                Margin = new Padding(0, 20, 0, 0)
            };
            flowLayoutPanel1.Controls.Add(totalLabel);

            Label bayarLabel = new Label()
            {
                Text = $"BAYAR : Rp {_uangBayar:N0}",
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                Width = 358,
                Height = 25,
                TextAlign = ContentAlignment.MiddleRight,
                Padding = new Padding(0, 0, 10, 0),
                Margin = new Padding(0, 5, 0, 0)
            };
            flowLayoutPanel1.Controls.Add(bayarLabel);

            int kembali = _uangBayar - _trx.TotalHarga;

            Label kembaliLabel = new Label()
            {
                Text = $"KEMBALI : Rp {kembali:N0}",
                Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0),
                Width = 358,
                Height = 25,
                TextAlign = ContentAlignment.MiddleRight,
                Padding = new Padding(0, 0, 10, 0),
                Margin = new Padding(0, 5, 0, 10)
            };
            flowLayoutPanel1.Controls.Add(kembaliLabel);

            Label thankyou = new Label()
            {
                Text = "Terimakasih Telah Berbelanja",
                Font = new Font("Segoe UI", 10, FontStyle.Italic),
                Width = 358,
                Height = 30,
                TextAlign = ContentAlignment.MiddleCenter,
                Margin = new Padding(0, 15, 0, 10)
            };
            flowLayoutPanel1.Controls.Add(thankyou);

            ResizeDynamicUI();
        }

        private void CaptureStruk()
        {
            Bitmap bmp = new Bitmap(panelContainer.Width, panelContainer.Height);

            panelContainer.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));

            SaveFileDialog sfd = new SaveFileDialog
            {
                Title = "Simpan Struk",
                Filter = "PNG Image|*.png",
                FileName = $"Nota_{_trx.Id}.png"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(sfd.FileName);
                MessageBox.Show("Struk berhasil disimpan!");
            }
        }

        private void FlowLayoutPanel1_Layout(object sender, LayoutEventArgs e)
        {
            ResizeDynamicUI();
        }

        private void FlowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            ResizeDynamicUI();
        }

        private void ResizeDynamicUI()
        {
            int padding = 80;

            this.Height = panelContainer.Bottom + padding;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            CaptureStruk();
        }
    }
}
