using System;
using System.Linq;
using System.Text;

namespace Diary
{
    class Functions
    {
        internal static string[] EnterStudentGrades()
        {
            StringBuilder sb = new StringBuilder();
            string text = "@";

            Console.Write("Enter student grades, separated by commas: ");

            while (text != string.Empty)
            {
                text = Console.ReadLine();
                sb.Append(text);
            }

            string[] gradesString = sb.ToString().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            return gradesString;
        }

        internal static float[] TryConvertGradesToFloat(string[] gradesString)
        {
            float[] gradesFloat = new float[gradesString.Length];

            for (int i = 0; i < gradesString.Length; i++)
            {
                try
                {
                    gradesFloat[i] = Convert.ToSingle(gradesString[i]);
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid data entered!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }

            return gradesFloat;
        }

        internal static void DisplayAverage(float[] gradesFloat) => Console.WriteLine($"Average: {gradesFloat.Average()}");
    }
}
