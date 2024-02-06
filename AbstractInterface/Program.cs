using System;

namespace AbstractInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            Console.Write("Enter Dog Name: ");
            string dogName = Console.ReadLine();
            dog.Name = dogName;

            Console.Write("Enter Dog Colour: ");
            string dogColour = Console.ReadLine();
            dog.Colour = dogColour;

            Console.Write("Enter Dog Height: ");
            int dogHeight = Convert.ToInt32(Console.ReadLine());
            dog.Height = dogHeight;

            Console.Write("Enter Dog Age: ");
            int dogAge = Convert.ToInt32(Console.ReadLine());
            dog.Age = dogAge;

            Console.WriteLine("Name of the Dog: "+dog.Name);
            Console.WriteLine("Colour of the Dog: "+dog.Colour);
            Console.WriteLine("Height of the Dog: "+dog.Height);
            Console.WriteLine("Age of the Dog: "+dog.Age);
            dog.Eat();
            dog.Cry();



            Cat cat = new Cat();

            Console.Write("Enter Cat Name: ");
            string catName=Console.ReadLine();
            cat.Name = catName;

            Console.Write("Enter Cat Colour: ");
            string catColour = Console.ReadLine();
            cat.Colour = catColour;

            Console.Write("Enter Cat Height: ");
            int catHeight= Convert.ToInt32(Console.ReadLine());
            cat.Height = catHeight;

            Console.Write("Enter Cat Age: ");
            int catAge= Convert.ToInt32(Console.ReadLine());
            cat.Age = catAge;

            Console.WriteLine("Name of the Cat: " + cat.Name);
            Console.WriteLine("Colour of the Cat: " + cat.Colour);
            Console.WriteLine("Height of the Cat: " + cat.Height);
            Console.WriteLine("Age of the Cat: " + cat.Age);
            cat.Eat();
            cat.Cry();

        }
    }

    public interface IAnimal
    {
        public string Name { get; set; }

        public string Colour { get; set; }

        public int Height { get; set; }

        public int Age { get; set; }

        public abstract void Eat();
        public abstract string Cry();

    }
    public class Dog:IAnimal
    {
        private string name;
        public string Name { get { return name; } set{ name = value; } }


        private string colour;
        public string Colour { get { return colour; } set { colour = value; } }

        private int height;
        public int Height { get { return height; } set { height = value; } }

        private int age;
        public int Age { get { return age; } set { age = value; } }

        public void Eat()
        {
            Console.WriteLine("Dogs eat meat");
        }

        public string Cry()
        {
            return "Woof!";
        }
    }
    public class Cat:IAnimal
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }


        private string colour;
        public string Colour { get { return colour; } set { colour = value; } }

        private int height;
        public int Height { get { return height; } set { height = value; } }

        private int age;
        public int Age { get { return age; } set { age = value; } }


        public void Eat() {
            Console.WriteLine("Cats eat mice");
        }

        public string Cry()
        {
            return "Meow!";
        }

    }
}