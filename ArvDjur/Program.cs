namespace ArvDjur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal();   
            Dog dog = new Dog();
            Cat cat = new Cat();
            Horse horse = new Horse();

            dog.name = "Bengt";
            dog.age = 7;
            cat.name = "Göran";
            cat.age = 5;
            horse.name = "Karl";
            horse.age = 12;


            Console.WriteLine($"The cats name is {cat.name}, Dog is named {dog.name} and the Horse is named {horse.name} ");
            Console.WriteLine($"The dog is a {dog.breed} and is {dog.age} years old ");
            dog.Sound();
            Console.WriteLine($"The cat is the colour {cat.colour} and is {cat.age} years old");
            cat.Sound();
            Console.WriteLine($"The horse have {horse.legs} legs and is  {horse.age} years old");
            horse.Sound();
        }
    }
    public class Animal
    {
        public string name;
        public int age;
    }
    public class  Dog : Animal
    {
        public string breed = "Bordercollie";
        public void Sound()
        {
            Console.WriteLine("Woof Woof");
        }       
    }
    public class Cat : Animal
    {
        public string colour = "red";
        public void Sound()
        {
            Console.WriteLine("Mjau Maju");
        }
    }
    public class Horse : Animal
    {
        public int legs = 4;
        public void Sound()
        {
            Console.WriteLine("Neigh Neigh");
        }
    }   
}