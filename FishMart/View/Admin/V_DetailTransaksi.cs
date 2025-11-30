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

namespace FishMart.View.Admin
{
    public partial class V_DetailTransaksi : Form
    {
        private readonly Transaksi _trx;
        private readonly List<DetailTransaksi> _details;
        private readonly RiwayatController _controller;

        public V_DetailTransaksi(Transaksi trx, List<DetailTransaksi> details)
        {
            InitializeComponent();
            _trx = trx;
            _details = details;
            _controller = new RiwayatController();

            V_DetailTransaksi_Load(this, EventArgs.Empty);
        }

        private void V_DetailTransaksi_Load(object sender, EventArgs e)
        {
            lblId.Text = $"Transaksi #{_trx.Id}";
            lblTanggal.Text = $"Tanggal : {_trx.Tanggal:yyyy-MM-dd HH:mm}";
            lblUser.Text = $"Kasir : {_controller.GetNamaKasir(_trx.UserId)}";
            lblTotal.Text = $"Total : Rp {_trx.TotalHarga:N0}";

            flowLayoutPanel1.Controls.Clear();

            foreach (var d in _details)
            {
                var produk = _controller.GetNamaProduk(d.ProdukId);

                Panel card = new Panel()
                {
                    Width = flowLayoutPanel1.Width - 25,
                    Height = 60,
                    BackColor = Color.Transparent,
                    Margin = new Padding(5),
                    BorderStyle = BorderStyle.FixedSingle
                };

                card.Controls.Add(new Label()
                {
                    Text = produk,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Left = 10,
                    Top = 5,
                    AutoSize = true
                });

                card.Controls.Add(new Label()
                {
                    Text = $"{d.Qty} x {d.HargaSatuan:N0}",
                    Left = 10,
                    Top = 30,
                    AutoSize = true
                });

                card.Controls.Add(new Label()
                {
                    Text = $"Rp {d.Subtotal:N0}",
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    Left = card.Width - 120,
                    Top = 20,
                    AutoSize = true
                });

                flowLayoutPanel1.Controls.Add(card);
            }

            // setelah load semua item → resize otomatis
            ResizeDynamicUI();
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

            // update height form
            this.Height = panelContainer.Bottom + padding;
        }
    }
}
