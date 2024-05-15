using System;
using System.Collections.Generic;

// Define enums for classifying information
enum AnimalType
{
    Mammal,
    Bird,
    Reptile,
    // Add more types as needed
}

enum FoodType
{
    Meat,
    Vegetation,
    Mixed,
    // Add more types as needed
}

enum HabitatType
{
    Desert,
    Forest,
    Aquatic,
    // Add more types as needed
}

// Define struct for lightweight data structure
struct DietInfo
{
    public string DietaryRequirements;
    public string FeedingSchedule;
}

// Define abstract class to represent general animal behaviors
abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public abstract void Eat();
    public abstract void Move();
    public abstract void Speak();
}

// Define interfaces to represent cross-category capabilities
interface IClimbable
{
    void Climb();
}

interface ISwimmable
{
    void Swim();
}

interface IFlyable
{
    void Fly();
}

// Define specific animal classes inheriting from Animal and implementing interfaces
class Lion : Animal, IClimbable
{
    public Lion(string name, int age) { Name = name; Age = age; }
    public override void Eat() { Console.WriteLine("Lion is devouring meat..."); }
    public override void Move() { Console.WriteLine("Lion is striding..."); }
    public override void Speak() { Console.WriteLine("Lion lets out a mighty roar..."); }
    public void Climb() { Console.WriteLine("Lion ascends..."); }
}

class Parrot : Animal, IFlyable
{
    public Parrot(string name, int age) { Name = name; Age = age; }
    public override void Eat() { Console.WriteLine("Parrot is munching on seeds..."); }
    public override void Move() { Console.WriteLine("Parrot is gliding through the air..."); }
    public override void Speak() { Console.WriteLine("Parrot chirps cheerfully..."); }
    public void Fly() { Console.WriteLine("Parrot soars gracefully..."); }
}

class Elephant : Animal
{
    public Elephant(string name, int age) { Name = name; Age = age; }
    public override void Eat() { Console.WriteLine("Elephant is grazing on vegetation..."); }
    public override void Move() { Console.WriteLine("Elephant is lumbering..."); }
    public override void Speak() { Console.WriteLine("Elephant emits a deep trumpet..."); }
}

class Crocodile : Animal, ISwimmable
{
    public Crocodile(string name, int age) { Name = name; Age = age; }
    public override void Eat() { Console.WriteLine("Crocodile is devouring meat..."); }
    public override void Move() { Console.WriteLine("Crocodile is gliding through water..."); }
    public override void Speak() { Console.WriteLine("Crocodile hisses menacingly..."); }
    public void Swim() { Console.WriteLine("Crocodile stealthily swims..."); }
}

class Eagle : Animal, IFlyable
{
    public Eagle(string name, int age) { Name = name; Age = age; }
    public override void Eat() { Console.WriteLine("Eagle is feasting on meat..."); }
    public override void Move() { Console.WriteLine("Eagle is soaring through the skies..."); }
    public override void Speak() { Console.WriteLine("Eagle lets out a piercing screech..."); }
    public void Fly() { Console.WriteLine("Eagle glides majestically..."); }
}

class Tiger : Animal, IClimbable
{
    public Tiger(string name, int age) { Name = name; Age = age; }
    public override void Eat() { Console.WriteLine("Tiger is devouring meat..."); }
    public override void Move() { Console.WriteLine("Tiger is prowling..."); }
    public override void Speak() { Console.WriteLine("Tiger emits a thunderous roar..."); }
    public void Climb() { Console.WriteLine("Tiger ascends effortlessly..."); }
}

class Giraffe : Animal
{
    public Giraffe(string name, int age) { Name = name; Age = age; }
    public override void Eat() { Console.WriteLine("Giraffe is munching on leaves..."); }
    public override void Move() { Console.WriteLine("Giraffe is striding..."); }
    public override void Speak() { Console.WriteLine("Giraffe lets out a gentle bleat..."); }
}

class Snake : Animal
{
    public Snake(string name, int age) { Name = name; Age = age; }
    public override void Eat() { Console.WriteLine("Snake is gobbling rodents..."); }
    public override void Move() { Console.WriteLine("Snake is slithering..."); }
    public override void Speak() { Console.WriteLine("Snake hisses menacingly..."); }
}

// Define Zoo class to manage animals
class Zoo
{
    private List<Animal> animals = new List<Animal>();

    public Zoo()
    {
        // Add default animals
        animals.Add(new Lion("Maximus", 4));
        animals.Add(new Parrot("Sunny", 6));
        animals.Add(new Elephant("Trunkster", 15));
        animals.Add(new Tiger("Stripes", 10));
        animals.Add(new Giraffe("Longneck", 8));
        animals.Add(new Snake("Slithers", 5));
    }

    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }

    public void DisplayAnimals()
    {
        Console.WriteLine("List of animals in the zoo:");
        foreach (Animal animal in animals)
        {
            Console.WriteLine($"Name: {animal.Name}, Type: {animal.GetType().Name}, Age: {animal.Age}");
        }
    }

    public void FeedAnimal(int index)
    {
        if (index >= 0 && index < animals.Count)
        {
            animals[index].Eat();
        }
        else
        {
            Console.WriteLine("Invalid animal index!");
        }
    }

    public void MakeAnimalSleep(int index)
    {
        if (index >= 0 && index < animals.Count)
        {
            Console.WriteLine($"{animals[index].Name} is now asleep...");
        }
        else
        {
            Console.WriteLine("Invalid animal index!");
        }
    }
}

// Main program entry point
class Program
{
    static void Main()
    {
        Zoo zoo = new Zoo();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Zoo Management System");
            Console.WriteLine("1. Add Animal");
            Console.WriteLine("2. Display Animals");
            Console.WriteLine("3. Feed Animal");
            Console.WriteLine("4. Make Animal Sleep");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter animal name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter animal age: ");
                        int age;
                        if (int.TryParse(Console.ReadLine(), out age))
                        {
                            Console.WriteLine("Select animal type:");
                            Console.WriteLine("1. Lion");
                            Console.WriteLine("2. Parrot");
                            Console.WriteLine("3. Elephant");
                            Console.WriteLine("4. Crocodile");
                            Console.WriteLine("5. Eagle");
                            Console.WriteLine("6. Tiger");
                            Console.WriteLine("7. Giraffe");
                            Console.WriteLine("8. Snake");
                            Console.Write("Enter choice: ");
                            int typeChoice;
                            if (int.TryParse(Console.ReadLine(), out typeChoice))
                            {
                                Animal animal;
                                switch (typeChoice)
                                {
                                    case 1:
                                        animal = new Lion(name, age);
                                        break;
                                    case 2:
                                        animal = new Parrot(name, age);
                                        break;
                                    case 3:
                                        animal = new Elephant(name, age);
                                        break;
                                    case 4:
                                        animal = new Crocodile(name, age);
                                        break;
                                    case 5:
                                        animal = new Eagle(name, age);
                                        break;
                                    case 6:
                                        animal = new Tiger(name, age);
                                        break;
                                    case 7:
                                        animal = new Giraffe(name, age);
                                        break;
                                    case 8:
                                        animal = new Snake(name, age);
                                        break;
                                    default:
                                        Console.WriteLine("Invalid choice!");
                                        continue;
                                }
                                zoo.AddAnimal(animal);
                                Console.WriteLine("Animal added successfully!");
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid age!");
                        }
                        break;
                    case 2:
                        zoo.DisplayAnimals();
                        break;
                    case 3:
                        Console.Write("Enter index of the animal to feed: ");
                        int feedIndex;
                        if (int.TryParse(Console.ReadLine(), out feedIndex))
                        {
                            zoo.FeedAnimal(feedIndex);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index!");
                        }
                        break;
                    case 4:
                        Console.Write("Enter index of the animal to make sleep: ");
                        int sleepIndex;
                        if (int.TryParse(Console.ReadLine(), out sleepIndex))
                        {
                            zoo.MakeAnimalSleep(sleepIndex);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index!");
                        }
                        break;
                    case 5:
                        exit = true;
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a number.");
            }

            Console.WriteLine();
        }
    }
}
