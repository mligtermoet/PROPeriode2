using System;

namespace As_You_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Hoe groot moet de lijst zijn?");
            int lijstLengte;
            lijstLengte = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Tot welk getal mogen de willekeurige getallen gaan?");
            int totGetal;
            totGetal = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            lijst(lijstLengte, totGetal);

            void lijst(int aantal, int tot)
            {
                for (int i = 0; i < aantal; i++)
                {
                    Random randm = new Random();
                    int RandomNumber = randm.Next(tot);
                    string nummer = RandomNumber.ToString();
                    Console.WriteLine(nummer);
                }
                
            }

            //int randomAantal = aantal();
            //int randomTot = totGetal();
            //aantal();
            //totGetal();
            //int RandomLijst = lijst();
            //for (int i = 0; i < randomAantal; i++)
            //{

            //    Console.WriteLine(randomAantal);
            //}



            //int lijst()
            //{
            //    Random randm = new Random();
            //    int rnummers = randm.Next(randomTot);
            //    rnummers.ToString();
            //    return rnummers;
            //}

            //int totGetal()
            //{
            //    Console.WriteLine("Tot welk getal mogen de willekeurige getallen gaan?");
            //    int tot;
            //    tot = Convert.ToInt32(Console.ReadLine());
            //    Console.Clear();
            //    return tot;
            //}

            //int aantal()
            //{
            //    Console.WriteLine("Hoe groot moet de lijst zijn?");
            //    int hoeveel;
            //    hoeveel = Convert.ToInt32(Console.ReadLine());
            //    Console.Clear();
            //    return hoeveel;
            //}

        }
    }
}
