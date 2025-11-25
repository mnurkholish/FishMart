using FishMart.Models;
using FishMart.Utils;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishMart.Repositories
{
    public class ProdukRepository : IProdukRepository
    {
        public List<Produk> GetListProduk()
        {
            var daftarProduk = new List<Produk>();

            using var conn = Database.GetConnection();
            conn.Open();

            string query = "SELECT id, nama_produk, harga, stok, gambar_produk FROM produk";

            using var cmd = new NpgsqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                daftarProduk.Add(new Produk
                {
                    Id = reader.GetInt32(0),
                    Nama = reader.GetString(1),
                    Harga = reader.GetInt32(2),
                    Stok = reader.GetInt32(3),
                    GambarProduk = reader.IsDBNull(4) ? null : (byte[])reader["gambar_produk"]
                });
            }

            return daftarProduk;
        }

        public List<Produk> GetListProduk(int limit)
        {
            var daftarProduk = new List<Produk>();

            using var conn = Database.GetConnection();
            conn.Open();

            string query = "SELECT id, nama_produk, harga, stok, gambar_produk FROM produk LIMIT @limit";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("limit", limit);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                daftarProduk.Add(new Produk
                {
                    Id = reader.GetInt32(0),
                    Nama = reader.GetString(1),
                    Harga = reader.GetInt32(2),
                    Stok = reader.GetInt32(3),
                    GambarProduk = reader.IsDBNull(4) ? null : (byte[])reader["gambar_produk"]
                });
            }

            return daftarProduk;
        }
    }
}
