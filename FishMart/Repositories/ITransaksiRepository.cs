using FishMart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
