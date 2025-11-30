using FishMart.Models;
using FishMart.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishMart.Services
{
    public class TransaksiService : ITransaksiService
    {
        private readonly ITransaksiRepository _repo;
        private readonly IProdukRepository _produkRepository;

        public TransaksiService()
        {
            _repo = new TransaksiRepository();
            _produkRepository = new ProdukRepository();
        }

        public int BuatTransaksi(Transaksi transaksi, List<DetailTransaksi> details)
        {
            int id = _repo.CreateTransaksi(transaksi);

            int total = 0;
            foreach (var d in details)
            {
                d.TransaksiId = id;
                d.Subtotal = d.Qty * d.HargaSatuan;
                total += d.Subtotal;

                _repo.AddDetail(d);

                var produk = _produkRepository.GetProdukById(d.ProdukId);

                if (produk != null)
                {
                    int stokBaru = produk.Stok - d.Qty;
                    if (stokBaru < 0) stokBaru = 0;

                    _produkRepository.UpdateStock(d.ProdukId, stokBaru);
                }
            }

            // Update total harga
            using var conn = new Npgsql.NpgsqlConnection();
            return id;
        }

        public List<Transaksi> GetAll() => _repo.GetAll();

        public List<DetailTransaksi> GetDetail(int transaksiId) => _repo.GetDetails(transaksiId);

        public int GetPemasukanHariIni()
        {
            return _repo.GetPemasukanHariIni();
        }

        public int GetJumlahTransaksiBulanIni()
        {
            return _repo.GetJumlahTransaksiBulanIni();
        }

        public int GetTotalPemasukanBulanIni()
        {
            return _repo.GetTotalPemasukanBulanIni();
        }

        public List<Transaksi> GetRiwayatKasir(int userId)
        {
            return _repo.GetRiwayatByKasir(userId);
        }
    }
}
