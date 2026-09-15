using System.Diagnostics.Tracing;

namespace Week3Assignment3._4
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Data.coffeeList.Add(new Coffee() { Name = "Latte", Price = 4.50M, Size = "Large", IsHot = true, MilkType = "Whole", Roast = "Medium", HasSugar = true });
            Data.coffeeList.Add(new Coffee() { Name = "Mocha", Price = 5.00M, Size = "Medium", IsHot = true, MilkType = "Oat", Roast = "Dark", HasSugar = false });
            Data.coffeeList.Add(new Coffee() { Name = "Americano", Price = 3.50M, Size = "Medium", IsHot = true, MilkType = "None", Roast = "Medium", HasSugar = false });
            Application.Run(new CoffeeOrders());
        }
    }
}