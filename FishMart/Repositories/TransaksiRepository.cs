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
    public class TransaksiRepository : ITransaksiRepository
    {
        public int CreateTransaksi(Transaksi transaksi)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string sql = @"INSERT INTO transaksi (user_id, total_harga)
                        VALUES (@uid, @total)
                        RETURNING id";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@uid", transaksi.UserId);
            cmd.Parameters.AddWithValue("@total", transaksi.TotalHarga);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void AddDetail(DetailTransaksi detail)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string sql = @"INSERT INTO detail_transaksi
                        (transaksi_id, produk_id, qty, harga_satuan, subtotal)
                        VALUES (@tid, @pid, @qty, @harga, @sub)";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@tid", detail.TransaksiId);
            cmd.Parameters.AddWithValue("@pid", detail.ProdukId);
            cmd.Parameters.AddWithValue("@qty", detail.Qty);
            cmd.Parameters.AddWithValue("@harga", detail.HargaSatuan);
            cmd.Parameters.AddWithValue("@sub", detail.Subtotal);

            cmd.ExecuteNonQuery();
        }

        public List<Transaksi> GetAll()
        {
            var list = new List<Transaksi>();

            using var conn = Database.GetConnection();
            conn.Open();

            string sql = "SELECT * FROM transaksi ORDER BY id DESC";
            using var cmd = new NpgsqlCommand(sql, conn);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Transaksi
                {
                    Id = reader.GetInt32(0),
                    UserId = reader.GetInt32(1),
                    Tanggal = reader.GetDateTime(2),
                    TotalHarga = reader.GetInt32(3)
                });
            }

            return list;
        }

        public List<DetailTransaksi> GetDetails(int transaksiId)
        {
            var list = new List<DetailTransaksi>();

            using var conn = Database.GetConnection();
            conn.Open();

            string sql = "SELECT * FROM detail_transaksi WHERE transaksi_id=@tid";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@tid", transaksiId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new DetailTransaksi
                {
                    Id = reader.GetInt32(0),
                    TransaksiId = reader.GetInt32(1),
                    ProdukId = reader.GetInt32(2),
                    Qty = reader.GetInt32(3),
                    HargaSatuan = reader.GetInt32(4),
                    Subtotal = reader.GetInt32(5)
                });
            }

            return list;
        }

        public int GetPemasukanHariIni()
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string sql = @"
                        SELECT COALESCE(SUM(total_harga), 0)
                        FROM transaksi
                        WHERE DATE(tanggal) = CURRENT_DATE
                        ";

            using var cmd = new NpgsqlCommand(sql, conn);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }


        public int GetJumlahTransaksiBulanIni()
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string sql = @"
                        SELECT COUNT(*)
                        FROM transaksi
                        WHERE EXTRACT(MONTH FROM tanggal) = EXTRACT(MONTH FROM CURRENT_DATE)
                        AND EXTRACT(YEAR FROM tanggal) = EXTRACT(YEAR FROM CURRENT_DATE)
                        ";

            using var cmd = new NpgsqlCommand(sql, conn);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public int GetTotalPemasukanBulanIni()
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string sql = @"
                    SELECT COALESCE(SUM(total_harga), 0)
                    FROM transaksi
                    WHERE EXTRACT(MONTH FROM tanggal) = EXTRACT(MONTH FROM CURRENT_DATE)
                    AND EXTRACT(YEAR FROM tanggal) = EXTRACT(YEAR FROM CURRENT_DATE)
                    ";

            using var cmd = new NpgsqlCommand(sql, conn);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}
