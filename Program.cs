namespace COMP003A.LectureActivity2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("20");
            double num1 = double.Parse("20");
            Console.Write("40");
            double num2 = double.Parse("40");
            double sum = 20 + 40;
            Console.WriteLine($"sum: {sum}");
            double average = (20 + 40) / 2;
            Console.WriteLine($"average: {average}");
            Console.WriteLine(20 + ">" + 40 +":"+ (20 > 40));
            Console.WriteLine(20 + "==" + 40 + ":" + (20 == 40));
        }
    }
}
