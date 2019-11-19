using System.Collections.Generic;
using System.Linq;

namespace Diary
{
    class Student
    {
        public const sbyte numberOfSubjects = 5;

        public Name Name { get; private set; }

        public List<Grade> Grades { get; }

        public Student(Name name)
        {
            Name = name;
        }

        public Student(Name name, List<Grade> grades)
        {
            Name = name;
            Grades = grades;
        }

        public void AddGrades(params Grade[] newGrades)
        {
            for (int i = 0; i < newGrades.Length; i++)
            {
                Grades.Add(newGrades[i]);
            }
        }

        public float GetWeightedAverage(SchoolSubject subject)
        {
            List<Grade> tempList = Grades.Where(x => x.Subject == subject).ToList();

            if (tempList == null)
            {
                return 1;
            }

            else
            {
                float sum = 0;
                float totalWeight = 0;

                for (int i = 0; i < tempList.Count; i++)
                {
                    sum += tempList[i].Value * tempList[i].Weight;
                    totalWeight += tempList[i].Weight;
                }

                return sum / totalWeight;
            }
        }

        public float SemesterAverage()
        {
            float avg = 0;

            for (int i = 0; i < numberOfSubjects; i++)
            {
                avg += GetWeightedAverage((SchoolSubject)i);
            }

            return avg / numberOfSubjects;
        }

        public static Student WhoHasTheHighestAverage(IEnumerable<Student> students)
        {
            return students.OrderByDescending(x => x.SemesterAverage()).FirstOrDefault();
        }

        public override string ToString()
        {
            return $"Name: {Name.FirstName} {Name.Surname}\nSemester average: {SemesterAverage()}";
        }
    }

    public class Name
    {
        public string FirstName;
        public string SecondName;
        public string Surname;

        public Name(string firstName, string surname)
        {
            FirstName = firstName;
            SecondName = null;
            Surname = surname;
        }
        public Name(string firstName, string secondName, string surname)
        {
            FirstName = firstName;
            SecondName = secondName;
            Surname = surname;
        }
    }       
}