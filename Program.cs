using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasIPAC
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Tugas Lab 8 (Pertemuan 11) - Polymorphsim, Inheritance, Abstraction, dan Collection";


      //membuat objek untuk semua karyawan
      KaryawanTetap karyawantetap = new KaryawanTetap();
      karyawantetap.nik = "123-234-345";
      karyawantetap.nama = "Michael Suyana";
      karyawantetap.gajibulanan = 4000000;

      KaryawanHarian karyawanharian = new KaryawanHarian();
      karyawanharian.nik = "123-321-346";
      karyawanharian.nama = "Laura Callahan";
      karyawanharian.jmljamkerja = 8;
      karyawanharian.upahperjam = 13000;

      Sales sales = new Sales
      sales.nik = "123-333-347";
      sales.nama = "Andrew Fuller";
      sales.jmljualan = 30;
      sales.komisi = 45000;


      //objek class collection
      List <Karyawan> listkaryawan = new List <Karyawan> ();

      listkaryawan.Add (karyawantetap);
      listkaryawan.Add (karyawanharian);
      listkaryawan.Add (sales);

      int nomor = 1;

      foreach (Karyawan karyawan in listkaryawan)
      {
        Console.WriteLine("{0}.   NIK : {1},   Nama : {2},   Gaji : {3}",
           nomor, karyawan.nik, karyawan.nama, karyawan.gaji());

        nomor++;
      }

      Console.ReadLine();
    }
  }
}
