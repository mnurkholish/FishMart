using FishMart.Models;

namespace FishMart.Repositories
{
    public interface ITransaksiRepository
    {
        int CreateTransaksi(Transaksi transaksi);
        void AddDetail(DetailTransaksi detail);
        List<Transaksi> GetAll();
        List<DetailTransaksi> GetDetails(int transaksiId);
        List<Transaksi> GetRiwayatByKasir(int userId);
        int GetPemasukanHariIni();
        int GetJumlahTransaksiBulanIni();
        int GetTotalPemasukanBulanIni();
    }
}
