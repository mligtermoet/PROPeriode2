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
        }
    }
}
