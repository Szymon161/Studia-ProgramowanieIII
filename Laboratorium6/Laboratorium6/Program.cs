using System;
using System.Linq;
using RandomDataGenerator.Randomizers;
using RandomDataGenerator.FieldOptions;

namespace Laboratorium6
{
    class Person
    {
        public int Id { get; }
        public string FirstName { get; }
        public string Surname { get; }

        public Person(int id, string imie, string nazwisko)
        {
            Id = id;
            FirstName = imie;
            Surname = nazwisko;
        }

        public override string ToString()
        {
            return $"{FirstName} {Surname}, {Id}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var idGenerator = RandomizerFactory.GetRandomizer(new FieldOptionsInteger());
            var firstNameGenerator = RandomizerFactory.GetRandomizer(new FieldOptionsFirstName());
            var lastNameGenerator = RandomizerFactory.GetRandomizer(new FieldOptionsLastName());

            var people = Enumerable.Range(1, 30)
                .Select(x => new Person(idGenerator.Generate().Value, firstNameGenerator.Generate(), lastNameGenerator.Generate()))
                .ToList();
            
            Console.WriteLine($"Number of people: {people.Count()}\nID's average: {people.Select(x => x.Id).Average()}\n");

            people.OrderBy(x => x.Surname).ThenBy(x => x.FirstName).ToList().ForEach(Console.WriteLine);

            Console.ReadKey();
        }
    }
}
