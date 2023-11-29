using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrameringUke2
{
    public class Studenter
    {
        public string name;
        public int age;
        public string hair;

        public Studenter(string Name, string Hair, int Age)
        {
            name = Name;
            age = Age;
            hair = Hair;
        }


       public void introduction()
        {
            Console.WriteLine($"Hei jeg heter {name}! Jeg er {age} år og har {hair} hår. ");
        }

        public void Hobby()
        {
            Console.WriteLine("nå gamer jeg :D");
        }

        public void Hobby2()
        {
            Console.WriteLine("nå baker jeg og skal lage mat :D");
        }
    };
}
