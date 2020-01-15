using System;

namespace YouDontOwnMe
{
    class Program
    {
        static void Main(string[] args)
        {
            Character newCharacter = new Character();
            Console.WriteLine("Character lives: " + newCharacter.lives);
            Steve newSteve = new Steve();
            Console.WriteLine("Steve's lives: " + newSteve.lives);
        }
    }
}
