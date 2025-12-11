using FishMart.Models;

namespace FishMart.Services
{
    public interface ITransaksiService
    {
        int BuatTransaksi(Transaksi transaksi, List<DetailTransaksi> details);
        List<Transaksi> GetAll();
        List<DetailTransaksi> GetDetail(int transaksiId);
        List<Transaksi> GetRiwayatKasir(int userId);
        int GetPemasukanHariIni();
        int GetJumlahTransaksiBulanIni();
        int GetTotalPemasukanBulanIni();
    }
}
