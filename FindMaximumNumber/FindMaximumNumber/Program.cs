namespace FindMaximumNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int check = CheckMaxNumber.MaximumNumber(10, 20, 30);
            int check1 = CheckMaxNumber.MaximumNumber(30, 20, 10);
            int check2 = CheckMaxNumber.MaximumNumber(20,30, 10);
            Console.WriteLine(check);
            Console.WriteLine(check1);
            Console.WriteLine(check2);
        }
    }
}