using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FamilyHome
{
    public class Family
    {
        private string familyName;
        public string FamilyName
        {
            get
            {
                return familyName;
            }
            set
            {
                familyName = value;
            }
        }

        private List<Person> members = new List<Person>();
        public List<Person> Members
        {
            get
            {
                return members;
            }
            set
            {
                members = value;
            }
        }
        public void SortAgeAcending()
        {

            for (int i = 0; i < this.Members.Count; i++)
            {
                for (int j = 0; j < this.Members.Count - 1; j++)
                {
                    if (this.Members[j].Age > this.Members[j + 1].Age)
                    {
                        Person temp = this.Members[j];
                        this.Members[j] = this.Members[j + 1];
                        this.Members[j + 1] = temp;
                    }
                }
            }
        }

        public void PrintAll()
        {
            Console.WriteLine($"Family: {this.FamilyName}");
            foreach (Person item in this.Members)
            {
                item.Intruduce();
            }
        }
        public void PrintOldest()
        {
            Console.Write("Oldest: ");
            Console.WriteLine($"Name: {this.Members[members.Count - 1].Name}, Age: {this.Members[members.Count - 1].Age}");
        }
        public void PrintYoungest()
        {
            Console.Write("Youngest: ");
            Console.WriteLine($"Name: {this.Members[0].Name}, Age: {this.Members[0].Age}");
        }
        public int SumOfAges()
        {
            int sum = 0;
            foreach (Person member in this.Members)
            {
                sum += member.Age;
            }
            return sum;
        }
    }
}
