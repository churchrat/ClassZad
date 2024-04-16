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
            int total = 0;
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
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - 1; j++)
                {
                    if (myFamily.Members[j].Age > myFamily.Members[j + 1].Age)
                    {
                        Person temp = myFamily.Members[j];
                        myFamily.Members[j] = myFamily.Members[j + 1];
                        myFamily.Members[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine();
            Person oldest = myFamily.Members[count - 1];
            Person youngest = myFamily.Members[0];
            Console.Write("Oldest: ");
            oldest.PrintOldestAndYoungest();
            Console.Write("Youngest: ");
            youngest.PrintOldestAndYoungest();
            foreach (Person member in myFamily.Members)
            {
                total += member.Age;
            }
            Console.WriteLine();
            myFamily.PrintAll();
            Console.WriteLine();
            Console.WriteLine($"Sum of years: {total}");
        }
    }
    }
