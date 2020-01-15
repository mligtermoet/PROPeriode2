using System;



namespace package_it
{
    class Program
    {
        static void Main(string[] args)
        {
            drinken.alcoholisch.bier Bier = new drinken.alcoholisch.bier();
            drinken.frisdranken.fanta Fanta = new drinken.frisdranken.fanta();
            gezond.fruit.banaan Banaan = new gezond.fruit.banaan();
            gezond.groente.sla Sla = new gezond.groente.sla();
            zoetigheid.koekjes.stroopwafels Stroopwafels = new zoetigheid.koekjes.stroopwafels();
            zoetigheid.snoepjes.winegums Winegums = new zoetigheid.snoepjes.winegums();
            zuivel.drinkzuivel.melk Melk = new zuivel.drinkzuivel.melk();
            zuivel.eetzuivel.yoghurt Yoghurt = new zuivel.eetzuivel.yoghurt();

            Console.WriteLine("Bier:");
            Console.WriteLine(" Prijs: " + Bier.prijs);
            Console.WriteLine(" Aantal: " + Bier.aantal);
            Console.WriteLine(" ");
            Console.WriteLine("Fanta:");
            Console.WriteLine(" Prijs: " + Fanta.prijs);
            Console.WriteLine(" Aantal: " + Fanta.aantal);
            
            
        }
    }
}
