using System;
namespace spelet21an
{
    class Program
    {
        static void Main(string[] args)
        {
            int spelarkort = 0;
            int datorkort = 0;
            int meny = 0;
            Console.WriteLine("Välkommen till 21:an!");
            Console.WriteLine("Välj ett alternativ");
            Random slump = new Random();
            while (meny != 4)
            {
                Console.WriteLine($"\n1.Spela 21:an\n2.visa senaste vinnaren\n3.spelets regler\n4.avsluta programmet");
                meny = int.Parse(Console.ReadLine());
                switch (meny)
                {
                    case 1: Console.WriteLine("Spela 21:an spelet");
                        break;
                    case 2: Console.WriteLine("Visa senaste vinnaren");
                        break;
                    case 3: Console.WriteLine("Spelets regler");
                        break;
                    case 4: Console.WriteLine("Avsluta programmet");
                        break;
                }
            }
        }
    }
}