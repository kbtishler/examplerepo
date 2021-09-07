using System;

namespace exapmlerepo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter views:");
            int views = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ad rate:");
            double adRate = double.Parse(Console.ReadLine());
            adRate = adRate / 100;
            double adViews = views * adRate;
            double revenue = (.18 * adViews) * .68;
            Console.WriteLine("Your total revenue is: " + revenue);
            Console.ReadLine();
        }
    }
}
