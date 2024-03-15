using NAudio.Wave;
using System.Runtime.InteropServices;

namespace Kvitten_min_bror
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guitar g1 = new Guitar("Fender stratocaster", false);
            Guitar g2 = new Guitar("Acustisk Guitar", true);
            Drum d1 = new Drum("Trumme", 6);
            Saxophone s1 = new Saxophone("saxo", 7);
            Violin v1 = new Violin("vio", 4);

            Console.WriteLine();
            Console.WriteLine();

            Piano p1 = new Piano("Yamaha", 88, 2);

            Console.WriteLine(p1);
            Console.WriteLine();
            Console.ReadKey();
            
          
           // g1.Play();
           d1.Play();
            s1.Play();
            v1.Play();
            p1.Play();

        }
    }
}
