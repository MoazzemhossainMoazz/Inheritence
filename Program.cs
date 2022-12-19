using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Animal
    {
        public string name;
        public int age;
        public string color;
        public void PrintDetails()
        {
            Console.WriteLine("Name: " + name + ", " + "Age: " + age + " Color: " + color);
        }
    }

    class Dog: Animal
    {
        public string bred;
        public void Sound()
        {
            Console.WriteLine("Dog sound: Ghew Ghew");
        }
        public Dog(string _name, int _age, string _color, string _bred)
        {
            name = _name;
            age = _age;
            color = _color;
            bred = _bred;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Audi", 5, "Grey", "Siberian Huskey");
            dog.PrintDetails();
            Console.WriteLine(dog.bred);
            dog.Sound();
            Console.ReadLine();
        }
    }
}
