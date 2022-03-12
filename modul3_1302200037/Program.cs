using System;

namespace modul3_1302200037
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.buah.Apel));
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.buah.Aprikot));
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.buah.Alpukat));
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.buah.Pisang));
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.buah.Paprika));
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.buah.Blackberry));
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.buah.Ceri));
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.buah.Kelapa));
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.buah.Jagung));
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.buah.Kurma));
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.buah.Durian));
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.buah.Anggur));
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.buah.Melon));
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.buah.Semangka));

            PosisiKarakterGame.Mulai();
        }
    }
}