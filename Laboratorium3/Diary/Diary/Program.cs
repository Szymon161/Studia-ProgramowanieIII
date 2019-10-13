namespace Diary
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            string[] gradesString = Functions.EnterStudentGrades();

            float[] gradesFloat = Functions.TryConvertGradesToFloat(gradesString);

            Functions.DisplayAverage(gradesFloat);

            System.Console.ReadKey();
        }
    }
}
