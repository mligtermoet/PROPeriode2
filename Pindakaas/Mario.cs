using System;
public class Mario : Character
{

    public bool isRunning = false;
    public string item ="";

    public Mario()
    {
        Console.WriteLine("Mario Constructor");

        id = "Mario";
        Console.WriteLine("ID is nu: " + id);
    }

    public void Shoot()
    {
        Console.WriteLine("School Shooting");
    }

    public void Shoot(int amount)
    {
        Console.WriteLine("Mario shoots " + amount + " times.");
    }

    public void Jump()
    {
        Console.WriteLine("JUMP");
    }

    public override void Walk()
    {
        base.Walk();
        Console.WriteLine("Mario is aan het lopen");
    }
}
