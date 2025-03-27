using System;
using System.Collections.Generic;

class Program
{
    static List<string> daftarNama = new List<string>();

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== PENDAFTARAN MEMBER BILLIARD =====");
            Console.WriteLine("1. Tambah Nama");
            Console.WriteLine("2. Tampilkan Nama");
            Console.WriteLine("3. Edit Nama");
            Console.WriteLine("4. Hapus Nama");
            Console.WriteLine("5. Keluar");
            Console.Write("Pilih menu: ");

            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    TambahNama();
                    break;
                case "2":
                    TampilkanNama();
                    break;
                case "3":
                    EditNama();
                    break;
                case "4":
                    HapusNama();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Pilihan tidak valid!");
                    break;
            }
        }
    }

    static void TambahNama()
    {
        Console.Write("Masukkan nama: ");
        string nama = Console.ReadLine();
        daftarNama.Add(nama);
        Console.WriteLine("Nama berhasil ditambahkan!");
        Console.ReadKey();
    }

    static void TampilkanNama()
    {
        Console.WriteLine("\n===== Daftar Nama =====");
        if (daftarNama.Count == 0)
        {
            Console.WriteLine("Belum ada data!");
        }
        else
        {
            for (int i = 0; i < daftarNama.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {daftarNama[i]}");
            }
        }
        Console.ReadKey();
    }

    static void EditNama()
    {
        TampilkanNama();
        Console.Write("\nMasukkan nomor yang ingin diubah: ");
        int index;
        if (int.TryParse(Console.ReadLine(), out index) && index > 0 && index <= daftarNama.Count)
        {
            Console.Write("Masukkan nama baru: ");
            daftarNama[index - 1] = Console.ReadLine();
            Console.WriteLine("Nama berhasil diperbarui!");
        }
        else
        {
            Console.WriteLine("Nomor tidak valid!");
        }
        Console.ReadKey();
    }

    static void HapusNama()
    {
        TampilkanNama();
        Console.Write("\nMasukkan nomor yang ingin dihapus: ");
        int index;
        if (int.TryParse(Console.ReadLine(), out index) && index > 0 && index <= daftarNama.Count)
        {
            daftarNama.RemoveAt(index - 1);
            Console.WriteLine("Nama berhasil dihapus!");
        }
        else
        {
            Console.WriteLine("Nomor tidak valid!");
        }
        Console.ReadKey();
    }
}
