namespace Day13Generics
{
    public class Program
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Find Maximum of given 3");
            int[] intArray = { 100, 321, 900, 200, 250 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMaxValue();
            double[] doubleArray = { 10.2, 30.4, 4.42, 55.5, 6.87 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            genericDouble.PrintMaxValue();
            string[] stringArray = { "Apple", "Peach", "Banana", "Watermelon", "Guava" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            genericString.PrintMaxValue();
            Console.ReadLine();
        }
    }

}
