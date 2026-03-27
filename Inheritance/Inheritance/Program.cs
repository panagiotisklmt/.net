namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog rex = new Dog();
            rex.MakeSound();

            Cat roza = new Cat();
            roza.MakeSound();

            Console.ReadKey();
        }
    }

    //Base class (parent or super class)
    class Animal 
    {
        //Access modifiers

        //public fields are accessible globally 
        public int publicField;
        //protected fields are accessible from the subclasses of the parent class
        protected int protectedField;
        //private fields are accessible only in the class they are declared
        private int privateField;

        public void eat() 
        {
            Console.WriteLine("Eating...");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a generic sound");
        }
    }

    //Derived class (child or sub class)
    class Dog : Animal 
    {
        public sealed override void MakeSound()
        {
            Console.WriteLine("WOOF WOOF");
        }
    }

    //Multi inheritance level
    class Collie : Dog
    {
        public void GoingNuts()
        {
            Console.WriteLine("Collie going nuts");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound() 
        {
            Console.WriteLine("Meow Meow");
        }
    }
}
