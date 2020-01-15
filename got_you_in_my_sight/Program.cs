using System;

namespace got_you_in_my_sight
{
    class Program
    {
        static void Main(string[] args)
        {
            Anders.ClassA classA = new Anders.ClassA();
            ClassB classB = new ClassB();

            Console.WriteLine(classA.test1);
            classA.test4();
            Console.WriteLine(classB.test1);
        }
    }
}
