namespace ConcreteClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new();
            human.Talk();
            human.Move();
            Dog dog = new();
            dog.Talk();
            dog.Move();
        }
    }

    public abstract class Animal
    {
        public abstract void Talk();
        public abstract void Move();
    }

    // Concrete Class 
    public class Human : Animal
    {
        public override void Talk()
        {
            Console.WriteLine("This blog post is awesome! :)");
        }

        public override void Move()
        {
            Console.WriteLine("I'm walking on 2 feet.");
        }
    }

    // Concrete Class 
    public class Dog : Animal
    {
        public override void Talk()
        {
            Console.WriteLine("Woof! WOOF!");
        }

        public override void Move()
        {
            Console.WriteLine("I'm walking on 4 feet.");
        }

    }
}