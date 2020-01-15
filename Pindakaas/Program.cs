using System;

namespace Pindakaas
{
    class Program
    {
        static void Main(string[] args)
        {
            Character myBaseClass = new Character();
            myBaseClass.Walk();

            Mario myMario = new Mario();

            myMario.Walk();
            myMario.Shoot();
            myMario.Shoot(6);
            
            
        }
    }
}
