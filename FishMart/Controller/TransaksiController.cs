using FishMart.Models;
using FishMart.Services;

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

        public int GetPemasukanHariIni() => _transaksiService.GetPemasukanHariIni();
        public int GetJumlahTransaksiBulanIni() => _transaksiService.GetJumlahTransaksiBulanIni();
        public int GetTotalPemasukanBulanIni() => _transaksiService.GetTotalPemasukanBulanIni();
    }
}
