using FishMart.Models;
using FishMart.Utils;
using FishMart.Controller;
using System.IO;
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

            string query = "SELECT * FROM produk WHERE is_delete = false ORDER BY id ASC";

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

            string query = "SELECT id, nama_produk, harga, stok, gambar_produk FROM produk WHERE is_delete = false LIMIT @limit";

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

        public Produk GetProdukById(int id)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string sql = "SELECT id, nama_produk, harga, stok FROM produk WHERE id = @id";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Produk
                {
                    Id = reader.GetInt32(0),
                    Nama = reader.GetString(1),
                    Harga = reader.GetInt32(2),
                    Stok = reader.GetInt32(3)
                };
            }
            return null;
        }

        public Produk? GetLowStock()
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string query = @"
            SELECT id, nama_produk, harga, stok, gambar_produk, is_delete 
            FROM produk
            WHERE stok > 0 AND stok < 10 AND is_delete = false
            ORDER BY stok ASC
            LIMIT 1";

            using var cmd = new NpgsqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new Produk
                {
                    Id = reader.GetInt32(0),
                    Nama = reader.GetString(1),
                    Harga = reader.GetInt32(2),
                    Stok = reader.GetInt32(3),
                    GambarProduk = reader.IsDBNull(4) ? null : (byte[])reader["gambar_produk"],
                    IsDelete = reader.GetBoolean(5)
                };
            }

            return null;
        }

        public void InsertProduk(Produk produk)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string query = @"
            INSERT INTO produk (nama_produk, harga, stok, gambar_produk)
            VALUES (@nama, @harga, @stok, @gambar)";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nama", produk.Nama);
            cmd.Parameters.AddWithValue("@harga", produk.Harga);
            cmd.Parameters.AddWithValue("@stok", produk.Stok);
            cmd.Parameters.AddWithValue("@gambar", (object?)produk.GambarProduk ?? DBNull.Value);

            cmd.ExecuteNonQuery();
        }

        public void UpdateProduk(Produk produk)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string query = @"
            UPDATE produk
            SET nama_produk = @nama,
            harga = @harga,
            stok = @stok,
            gambar_produk = @gambar
            WHERE id = @id";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nama", produk.Nama);
            cmd.Parameters.AddWithValue("@harga", produk.Harga);
            cmd.Parameters.AddWithValue("@stok", produk.Stok);
            cmd.Parameters.AddWithValue("@gambar", (object?)produk.GambarProduk ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@id", produk.Id);

            cmd.ExecuteNonQuery();
        }

        public void DeleteProduk(int produkId)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string query = "UPDATE produk SET is_delete = TRUE WHERE id = @id";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", produkId);

            cmd.ExecuteNonQuery();
        }

        public void UpdateStock(int produkId, int qtyBaru)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string sql = "UPDATE produk SET stok = @stok WHERE id = @id";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@stok", qtyBaru);
            cmd.Parameters.AddWithValue("@id", produkId);

            cmd.ExecuteNonQuery();
        }
    }
}
