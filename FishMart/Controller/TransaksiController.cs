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
        private readonly ITransaksiService _transaksiService;

        public TransaksiController()
        {
            _transaksiService = new TransaksiService();
        }

        public int SimpanTransaksi(Transaksi trx, List<DetailTransaksi> items)
        {
            return _transaksiService.BuatTransaksi(trx, items);
        }

        public List<Transaksi> TampilkanTransaksi()
        {
            return _transaksiService.GetAll();
        }

        public List<DetailTransaksi> TampilkanDetail(int transaksiId)
        {
            return _transaksiService.GetDetail(transaksiId);
        }
    }
}
