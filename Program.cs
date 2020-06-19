using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLab8.ClassAnak;
using TugasLab8.ClassInduk;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {

            KariawanTetap kariawantetap = new kariawantetap();
            kariawantetap.NIK = "4567-2341-7654";
            kariawantetap.Nama = "Akbar Nurrizky";
            kariawantetap.GajiBulanan = 4000000;

            KariawanHarian kariawanharian = new karyawanharian();
            kariawanharian.NIK = "1234-0987-3456";
            kariawanharian.Nama = "Azazel";
            kariawanharian.UpahPerJam = 13000;
            kariawanharian.JumlahJamKerja = 8;

            Sales sales = new Sales();
            sales.NIK = "2345-6543-9876";
            sales.Nama = "Lucyfer";
            sales.JumlahPenjualan = 30;
            sales.Komisi = 45000;

            List<Kariawan> listKariawan = new List<Kariawan>();

            listKariawan.Add(kariawanTetap);
            listKariawan.Add(kariawanHarian);
            listKariawan.Add(sales);

            int noUrut = 1;

            foreach (Kariawan kariawan in listKariawan)
            {
                Console.WriteLine("{0}. NIK: {1}, Nama: {2}, Gaji: {3}", noUrut, kariawan.NIK, kariawan.Nama, kariawan.Gaji());

                noUrut++;
            }

            Console.ReadLine();
        }
    }
}
