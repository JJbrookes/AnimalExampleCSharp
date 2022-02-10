namespace AnimalExampleCSharp;
public class program
{
    public static void Main(string[] args)
    {
        bool done = false;
        do
        {

            List<Animal> Pets = new List<Animal>();

            GetPetInfo(Pets);

            static void GetPetInfo(List<Animal> Pets)
            {
                Console.WriteLine("What Kind of Animal do you have: ");
                Console.WriteLine("Dog - Enter 1");
                Console.WriteLine("Bat - Enter 2");
                Console.WriteLine("Penguin - Enter 3");
                Console.WriteLine("Goat - Enter 4");
                Console.WriteLine(" - Enter 5");
                Console.Write(":");

                string petType = Console.ReadLine();
                switch (petType)
                {
                    case "1":
                        Dog dog = new Dog(2, "Test");
                        Pets.Add(dog);
                        CreateAnimal(dog);
                        break;
                    case "2":
                        Bat bat = new Bat();
                        Pets.Add(bat);
                        CreateAnimal(bat);
                        break;
                    case "3":
                        Penguin penquin = new Penguin();
                        Pets.Add(penquin);
                        CreateAnimal(penquin);
                        break;
                    case "4":
                        //  Goat goat = new Goat();
                        // CreateAnimal(goat);
                        break;
                    case "5":
                        //  Angelfish angelfish = new Angelfish();
                        // CreateAnimal(angelfish);
                        break;
                    default:
                        GetPetInfo(Pets);
                        break;
                }
            }

            foreach (Animal pet in Pets)
            {
                Console.WriteLine(pet.Name);
            }

            Console.WriteLine("Do you want to add another Animal");

        } while (!done);

    }

    private static void CreateAnimal(Animal pet)
    {
        Console.Write("What is your animals name: ");
        pet.Name = Console.ReadLine();
        int age;
        Console.Write("What is your animals age in years: ");
        while (!int.TryParse(Console.ReadLine(), out age))
        {
            Console.WriteLine("Not a valid number");
            Console.Write("What is your animals age in years: ");
        }
        pet.Age = age;
        Console.Write("What is the sex of your animal(M/F): ");
        pet.Sex = Console.ReadLine();



    }
}