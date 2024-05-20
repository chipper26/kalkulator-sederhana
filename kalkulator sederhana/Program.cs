using System;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Kalkulator Sederhana");
            Console.WriteLine("Pilih operasi:");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine("5. Keluar");
            Console.Write("Pilihan Anda: ");

            int pilihan;
            double angka1, angka2, hasil;

            if (!int.TryParse(Console.ReadLine(), out pilihan))
            {
                Console.WriteLine("Masukan tidak valid. Silakan masukkan nomor pilihan.");
                continue;
            }

            if (pilihan == 5)
            {
                Console.WriteLine("Terima kasih telah menggunakan kalkulator. Sampai jumpa!");
                break;
            }

            Console.Write("Masukkan angka pertama: ");
            angka1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan angka kedua: ");
            angka2 = Convert.ToDouble(Console.ReadLine());

            switch (pilihan)
            {
                case 1:
                    hasil = angka1 + angka2;
                    Console.WriteLine("Hasil penjumlahan: " + hasil);
                    break;
                case 2:
                    hasil = angka1 - angka2;
                    Console.WriteLine("Hasil pengurangan: " + hasil);
                    break;
                case 3:
                    hasil = angka1 * angka2;
                    Console.WriteLine("Hasil perkalian: " + hasil);
                    break;
                case 4:
                    if (angka2 == 0)
                    {
                        Console.WriteLine("Tidak bisa melakukan pembagian dengan nol.");
                    }
                    else
                    {
                        hasil = angka1 / angka2;
                        Console.WriteLine("Hasil pembagian: " + hasil);
                    }
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid. Silakan pilih operasi yang sesuai.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Tekan enter tombol untuk melanjutkan atau pilih 5 untuk keluar.");
            Console.ReadKey();
            Console.Clear(); // Bersihkan layar sebelum kembali ke menu utama
        }
    }
}
