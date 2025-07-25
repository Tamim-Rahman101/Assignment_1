using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Animal
    {
        public Animal()
        {
            Console.WriteLine("New animal created.");
        }
        public virtual void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }
    internal class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("New dog created.");
        }
        public void Speak()
        {
            Console.WriteLine("Dog speaks bow bow.");
        }
    }
    internal class Cat : Animal
    {
        public Cat()
        {
            Console.WriteLine("New cat created.");
        }
        public override void Eat()
        {
            Console.WriteLine("Cat is eating.");
        }
    }
}
