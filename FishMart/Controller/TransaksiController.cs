using FishMart.Models;
using FishMart.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishMart.Controller
{
    public class TransaksiController
    {
        private readonly ITransaksiService _service;

        public TransaksiController()
        {
            _service = new TransaksiService();
        }

        public int SimpanTransaksi(Transaksi trx, List<DetailTransaksi> items)
        {
            return _service.BuatTransaksi(trx, items);
        }

        public List<Transaksi> TampilkanTransaksi()
        {
            return _service.GetAll();
        }

        public List<DetailTransaksi> TampilkanDetail(int transaksiId)
        {
            return _service.GetDetail(transaksiId);
        }
    }
}
