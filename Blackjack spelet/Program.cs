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
            string Senastevinnaren = "ingen har vunnit";
            while (meny != 4)
            {
                Console.WriteLine($"\n1.Spela 21:an\n2.visa senaste vinnaren\n3.spelets regler\n4.avsluta programmet");
                meny = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (meny)
                {
                    case 1: Console.WriteLine("Spela 21:an spelet");
                        break;
                    case 2: Console.WriteLine($"Visa senaste vinnaren:{Senastevinnaren}");
                        break;
                    case 3: Console.WriteLine("Spelets regler:\nDitt mål är att få datorn till att få mer än 21 poäng" +
                        "\nDu får poäng genom att dra kort, varje kort är värt mellan 1-10 poäng" +
                        "\nOm du får mer än 21 poäng har du förlorat" +
                        "\nBåde du och datorn får ett kort, sedan får du välja om du vill ha ett till." +
                        "\nDu kan dra så många kort du får inte ha mer poäng än 21" +
                        "\nNär du är färdig drar datorn kort till sig själv" +
                        "\nDu vinner om du har mer poäng än datorn eller 21 poäng");
                        break;
                    case 4: Console.WriteLine("Avsluta programmet");
                        break;
                        Console.WriteLine();
                }
            }
        }
    }
}