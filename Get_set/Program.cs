using System;
using System.Collections.Generic;

namespace Get_set
{
    class Program
    {
        public static List<Player> players = new List<Player>();          
        static void Main(string[] args)
        {
        bool playing = true;  

        players.Add(new Player("Bert"));   
        players.Add(new Player("JOB"));   
        players.Add(new Player("ROB"));   
        players.Add(new Player("hoop"));   
        players.Add(new Player("rim"));   

        void writeNaamEnHp() {
        foreach (Player p in players) {
            if (p.dood == false) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(p.name + "  " + p.hp);
            } else {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(p.name + "  " + p.hp);
            }
        }
        }
        while (playing) {
            bool victor = true;
        
        Console.Clear();
        Console.WriteLine("type een naam");
        writeNaamEnHp();

        foreach(Player p in players) {
    if (p.hp > 0) {
        victor = false;
    }
}
if (victor == true) {
    // je wint
    Console.BackgroundColor = ConsoleColor.Green;
    Console.WriteLine("Wouw legend");
    playing = false;
}


        string Input = Console.ReadLine();
        bool succes = false;
        foreach(Player p in players) {
            if (Input.ToLower() == "attack " + p.name.ToLower()) {
                p.hp -= 25;
                succes = true;
                }
            }
            if (succes == false) {
                Console.WriteLine("Geen juiste naam opgegeven");
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
}