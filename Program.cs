namespace Assignment1._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] monthsOfYear = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            string temp;

            Console.WriteLine("The values stored into the array are:");

            for (int i = 0; i < monthsOfYear.Length; i++)
            {
                Console.WriteLine(monthsOfYear[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < (monthsOfYear.Length / 2); i++)
            {
                temp = monthsOfYear[i];
                monthsOfYear[i] = monthsOfYear[monthsOfYear.Length - i - 1];
                monthsOfYear[monthsOfYear.Length - 1 - i] = temp;
            }

            Console.WriteLine("The values stored into the array in reverse are:");

            for (int i = 0; i < monthsOfYear.Length; i++)
            {
                Console.WriteLine(monthsOfYear[i]);
            }
        }
    }
}
