using System;
using System.Collections.Generic;
using System.Text;

namespace PlikiTekstowe
{
    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public Person(int id, string name, string lastName, string phone)
        {
            ID = id;
            Name = name;
            LastName = lastName;
            Phone = phone;
        }
    }
}
