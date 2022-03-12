using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302200037
{
    internal class PosisiKarakterGame
    {
        enum State { berdiri, TombolS, TombolW, exit };
        public static void Mulai()
        {
            Console.WriteLine("Masukan State");
            State state = State.berdiri;
            while (state != State.exit)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "TombolS ditekan":
                        Console.WriteLine("tombol arah bawah ditekan");
                        Console.WriteLine();
                        break;
                    case "TombolW ditekan":
                        Console.WriteLine("tombol arah atas ditekan");
                        Console.WriteLine();
                        break;
                    case "exit":
                        state = State.exit;
                        break;
                    default:
                        Console.WriteLine("Masukan ulang State");
                        break;
                }
            }

        }
    }
}

