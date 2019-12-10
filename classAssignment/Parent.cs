using System;
namespace classAssignment
{
    public class Parent:Person
    {
        private string course;
        public Parent(string name, string course):base(name){
            this.course = course;
            Console.WriteLine("you teach " + course);
            Console.WriteLine("");
        }
    }
}