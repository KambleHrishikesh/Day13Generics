namespace Day13Generics
{
    public class Program
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Find Maximum of given 3 Integers");
            
            Console.WriteLine("enter first value");
            int firstvalue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second value");
            int secondvalue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third value");
            int thirdvalue = Convert.ToInt32(Console.ReadLine());

            if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0 ||
                firstvalue.CompareTo(secondvalue) >= 0 && firstvalue.CompareTo(thirdvalue) > 0 ||
                firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) >= 0)
            {
                Console.WriteLine("First value is greater");
            }

            if (secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0 ||
                secondvalue.CompareTo(firstvalue) >= 0 && secondvalue.CompareTo(thirdvalue) > 0 ||
                secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) >= 0)
            {
                Console.WriteLine("second value is greater");
            }

            if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0 ||
                thirdvalue.CompareTo(firstvalue) >= 0 && thirdvalue.CompareTo(secondvalue) > 0 ||
                thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) >= 0)
            {
                Console.WriteLine("third value is greater");
            }

        }
    }

}
