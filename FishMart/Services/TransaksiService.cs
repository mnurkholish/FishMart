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

        public TransaksiService()
        {
            _repo = new TransaksiRepository();
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
            }

            // Update total harga
            using var conn = new Npgsql.NpgsqlConnection();
            return id;
        }

        public List<Transaksi> GetAll() => _repo.GetAll();

        public List<DetailTransaksi> GetDetail(int transaksiId) => _repo.GetDetails(transaksiId);
    }
}
