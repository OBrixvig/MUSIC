using NAudio.Wave;

namespace Kvitten_min_bror
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guitar g1 = new Guitar("Fender stratocaster", false);
            Guitar g2 = new Guitar("Acustisk Guitar", true);
            
            Console.WriteLine();
            Console.WriteLine();

            Piano p1 = new Piano("Yamaha", 88, 2);

            Console.WriteLine(p1);
            Console.WriteLine();
            Console.ReadKey();

          
           // g1.Play();

            p1.Play();

        }
    }
}
