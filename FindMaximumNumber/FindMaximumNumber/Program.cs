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
            Console.WriteLine("------------------------------");

            //for maximun float value
            Console.WriteLine("Maximun float number");
            double number = CheckMaxNumber.MaximunFloatNumber(11.1, 22.2, 33.3);
            double number1 = CheckMaxNumber.MaximunFloatNumber(33.3, 22.2, 11.1);
            double number2 = CheckMaxNumber.MaximunFloatNumber(11.1, 33.3, 22.2);
            Console.WriteLine(number);
            Console.WriteLine(number1);
            Console.WriteLine(number2);
        }
    }
}