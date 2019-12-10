using System;
namespace classAssignment
{
    public class Parent:Person
    {
        private string job;
        public Parent(string name, string job):base(name){
            this.job = job;
            Console.WriteLine("You are a " + job);
            Console.WriteLine("");
        }
    }
}