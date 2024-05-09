namespace Assignment1._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] monthsOfYear = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            int lengthOfArray = 12;
            string temp;

            Console.WriteLine("The values stored into the array are:");

            for (int i = 0; i < monthsOfYear.Length; i++)
            {
                Console.WriteLine(monthsOfYear[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < (lengthOfArray / 2); i++)
            {
                temp = monthsOfYear[i];
                monthsOfYear[i] = monthsOfYear[lengthOfArray - i - 1];
                monthsOfYear[lengthOfArray - 1 - i] = temp;
            }

            Console.WriteLine("The values stored into the array in reverse are:");

            for (int i = 0; i < monthsOfYear.Length; i++)
            {
                Console.WriteLine(monthsOfYear[i]);
            }
        }
    }
}
