using System;
using modul4_103022300149;

class program {
    static void Main() {
        kodeProduk KP = new kodeProduk();
        Console.WriteLine("Masukkan nama produk: ");
        string produk = Console.ReadLine();

        string kode = KP.getKodeProduk(produk);
        if (kode != null)
        {
            Console.WriteLine($"Kode Produk {produk}: {kode}");
        }
        else {
            Console.WriteLine("Kode Produk tidak ditemukan");
        }
    }
};