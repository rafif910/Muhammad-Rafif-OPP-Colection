using System;
using System.Collections.Generic;
using System.Ling;
using System.Text;
using Tugas_Lab_8.ClassAnak;
using Tugas_Lab_8.ClassInduk;

namespace Tugas_Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 (Pertemuan 11) - Polymorphsim, Anbstaction & Collection";

            // membuat objek untuk semua karyawan

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.NIK = "123.234.345";
            karyawanTetap.Nama = "Muhammad";
            karyawanTetap.GajiBulanan = 7000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.NIK = "345.456.567";
            karyawanHarian.Nama = "Rafif";
            karyawanHarian.JumlahJamKerja = 8;
            karyawanHarian.UpahPerjam = 130000;

            Sales sales = new Sales();
            sales.NIK = "567.678.789";
            sales.Nama = "Muh Rafif";
            sales.JumlahPenjualan = 30;
            sales.Komisi = 45000;

            // objek class collectio
            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. NIK: {1}, Nama: {2}, Gaji: {3:NO}", noUrut, karyawan.NIK, karyawan.Nama, karyawan.Gaji());

                noUrut++;
            }

            Console.ReadKey();
        }
    }
}