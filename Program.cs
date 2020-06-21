using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OOPCollection.Classinduk;
using OOPCollection.Classanak;
namespace OOPCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 Hilman Aulia Rahman 19.11.2656";
            Karyawantetap Karyawantetap = new Karyawantetap();
            Karyawantetap.nik = "19.11.2656";
            Karyawantetap.nama = "Hilman Aulia Rahman";
            Karyawantetap.gajibulanan = 12000000;

            Karyawanharian Karyawanharian = new Karyawanharian();
            Karyawanharian.nik = "19.11.2020";
            Karyawanharian.nama = "RA Hilman";
            Karyawanharian.jumlahjamkerja = 8;
            Karyawanharian.upahperjam = 13000;

            Sales Sales = new Sales();
            Sales.nik = "19.11.2001";
            Sales.nama = "Rahman HA";
            Sales.jumlahpenjualan = 30;
            Sales.komisi = 45000;

            //objek class collection
            List<Karyawan> listkaryawan = new List<Karyawan>();
            listkaryawan.Add(Karyawantetap);
            listkaryawan.Add(Karyawanharian);
            listkaryawan.Add(Sales);

            int noUrut = 1;
            foreach(Karyawan karyawan in listkaryawan){
                Console.WriteLine("{0}. NIK: {1}, Nama: {2}, Gaji: {3}",noUrut,karyawan.nik, karyawan.nama, karyawan.gaji());
                noUrut++;
            }
            Console.ReadKey();
        }
    }
}
