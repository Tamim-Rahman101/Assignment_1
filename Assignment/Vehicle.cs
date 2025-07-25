using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal abstract class Vehicle
    {
        public int Milage;
        public abstract void SetMilage(int milage);
        public void GetMilage()
        {
            Console.WriteLine($"The milage of the vehicle is {Milage} kmpl.");
        }
    }
    internal class Bike : Vehicle
    {
        public Bike()
        {
            Console.WriteLine("New bike created.");
        }
        public override void SetMilage(int milage)
        {
            Milage = milage;
        }
    }
    internal class Car : Vehicle
    {
        public Car()
        {
            Console.WriteLine("New car created.");
        }
        public override void SetMilage(int milage)
        {
            this.Milage = milage;
        }
    }
}
