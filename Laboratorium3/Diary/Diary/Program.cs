using System;
using System.Collections.Generic;

namespace Diary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = SampleStudents();

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"\nBest student:\n{Student.WhoHasTheHighestAverage(students)}");

            Console.ReadKey();
        }

        private static List<Student> SampleStudents()
        {
            return new List<Student>()
            {
                new Student(new Name("Robert", "Lewandowski"), new List<Grade>()
                {
                    new Grade(5, 1, SchoolSubject.Biology),
                    new Grade(2, 3, SchoolSubject.Biology),
                    new Grade(3, 2, SchoolSubject.Biology),
                    new Grade(4, 1, SchoolSubject.Biology),

                    new Grade(5, 1, SchoolSubject.English),
                    new Grade(6, 3, SchoolSubject.English),
                    new Grade(5, 2, SchoolSubject.English),

                    new Grade(2, 1, SchoolSubject.IT),
                    new Grade(2, 3, SchoolSubject.IT),
                    new Grade(3, 2, SchoolSubject.IT),

                    new Grade(3, 3, SchoolSubject.Maths),
                    new Grade(3, 2, SchoolSubject.Maths),

                    new Grade(6, 1, SchoolSubject.PE),
                    new Grade(6, 2, SchoolSubject.PE),
                    new Grade(6, 3, SchoolSubject.PE)
                }),

                new Student(new Name("Robert", "Kubica"), new List<Grade>()
                {
                    new Grade(3, 3, SchoolSubject.Biology),
                    new Grade(1, 1, SchoolSubject.Biology),

                    new Grade(4, 1, SchoolSubject.English),
                    new Grade(5, 3, SchoolSubject.English),

                    new Grade(3, 1, SchoolSubject.IT),
                    new Grade(3, 2, SchoolSubject.IT),
                    new Grade(4, 3, SchoolSubject.IT),

                    new Grade(2, 3, SchoolSubject.Maths),
                    new Grade(4, 3, SchoolSubject.Maths),
                    new Grade(1, 2, SchoolSubject.Maths),
                    new Grade(5, 2, SchoolSubject.Maths),
                    new Grade(3, 1, SchoolSubject.Maths),
                    new Grade(3, 1, SchoolSubject.Maths),

                    new Grade(6, 1, SchoolSubject.PE),
                    new Grade(5, 2, SchoolSubject.PE),
                    new Grade(6, 3, SchoolSubject.PE)
                }),

                new Student(new Name("Kamil", "Stoch"), new List<Grade>()
                {
                    new Grade(4, 3, SchoolSubject.Biology),
                    new Grade(5, 2, SchoolSubject.Biology),
                    new Grade(3, 1, SchoolSubject.Biology),

                    new Grade(4, 1, SchoolSubject.English),
                    new Grade(6, 3, SchoolSubject.English),
                    new Grade(6, 2, SchoolSubject.English),

                    new Grade(1, 1, SchoolSubject.IT),
                    new Grade(2, 3, SchoolSubject.IT),
                    new Grade(2, 2, SchoolSubject.IT),

                    new Grade(2, 3, SchoolSubject.Maths),
                    new Grade(4, 2, SchoolSubject.Maths),

                    new Grade(5, 1, SchoolSubject.PE),
                    new Grade(6, 2, SchoolSubject.PE),
                    new Grade(6, 3, SchoolSubject.PE)
                })
            };
        }
    }
}
