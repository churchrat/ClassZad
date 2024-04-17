namespace FamilyHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Family myFamily = new Family();
            myFamily.FamilyName = "Krustevi";
            Console.Write("How many members: ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.Write($"enter {i + 1} person: ");
                Person current = new Person();
                Console.Write($"enter name of {i + 1} person: ");
                current.Name = Console.ReadLine();
                Console.Write($"enter age of {i + 1} person: ");
                current.Age = int.Parse(Console.ReadLine());
                myFamily.Members.Add(current);
            }
            myFamily.SortAgeAcending();
            Console.WriteLine();
            myFamily.PrintOldest();
            myFamily.PrintYoungest();
            Console.WriteLine();
            myFamily.PrintAll();
            Console.WriteLine();
            int sum = myFamily.SumOfAges();
            Console.WriteLine($"Sum of years: {sum}");
        }
    }
    }
