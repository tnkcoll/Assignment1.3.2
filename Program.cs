namespace Assignment1._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] monthsOfYear = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            int length = 12;
            string temp;

            for (int i = 0; i < (length / 2); i++)
            {
                temp = monthsOfYear[i];
                monthsOfYear[i] = monthsOfYear[length - i - 1];
                monthsOfYear[length - 1 - i] = temp;
            }

            for (int i = 0; i < monthsOfYear.Length; i++)
            {
                Console.WriteLine(monthsOfYear[i]);
            }
        }
    }
}
