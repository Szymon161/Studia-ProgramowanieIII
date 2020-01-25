using System;
using System.IO;
using System.Linq;

namespace PlikiTekstowe
{
    class Program
    {
        static void Main()
        {
            var lines = File.ReadAllLines("data.txt");

            var people = lines.Select(x => 
            {
                string[] data = x.Split(',');
                return new Person
                (      
                    Convert.ToInt32(data[3]),
                    data[0],
                    data[1],
                    data[2]
                );

            }).ToList();

            var sortedPeople = people.OrderBy(x => x.LastName).ThenBy(x => x.Name);

            using (StreamWriter writer = new StreamWriter("result.txt"))
            {
                foreach (var item in sortedPeople)
                {
                    writer.WriteLine($"[{item.ID}] {item.Name} {item.LastName}, {item.Phone}");
                }
            }

            Console.ReadKey();
        }
    }
}
