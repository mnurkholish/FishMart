using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace FishMart.Models
{
    public class ProdukContext
    {
        private static string connString = "Host=ep-flat-sunset-a1u2t2wg-pooler.ap-southeast-1.aws.neon.tech;" +
                                           "Port=5432;" +
                                           "Username=neondb_owner;" +
                                           "Password=npg_ZxMFe50bEuzO;" +
                                           "Database=neondb;" +
                                           "SSL Mode=Require;" +
                                           "Trust Server Certificate=true;";
        public List<Produk> GetProdukFromDatabase()
        {
            List<Produk> daftarProduk = new List<Produk>();

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = "SELECT id, nama_produk, harga, stok, gambar_produk FROM produk";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
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
                }
            }

            return daftarProduk;
        }
    }
}
