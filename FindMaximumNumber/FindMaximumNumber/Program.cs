namespace FindMaximumNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int[] intArray = { 120, 111, 235, 142, 234, 112 };
            GenericsMaximum<int> generic = new GenericsMaximum<int>(intArray);
            generic.PrintValue();
            double[] doubleArray = { 11.2, 11.3, 55.5, 22.2, 33.3 };
            GenericsMaximum<double> genericsDouble = new GenericsMaximum<double>(doubleArray);
            genericsDouble.PrintValue();
            string[] stringArray = { "111", "222", "333", "444", "555" };
            GenericsMaximum<string> genericString = new GenericsMaximum<string>(stringArray);
            genericString.PrintValue();
        }

    }
}