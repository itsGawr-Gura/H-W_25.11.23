using System;
using System.Linq;
namespace H_W_25._11._23

{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //H-W 13.1-13.2
            Console.WriteLine("H-W 13.1-13.2 Building");
            Building b1 = new Building();
            b1.Height = 50;
            b1.Floors = 10;
            b1.Apartments = 100;
            b1.Entrances = 5;
            Console.WriteLine($"Height - {b1.Height}");
            Console.WriteLine($"Floor Height - {b1.FloorHeight()}");
            Console.WriteLine($"Apartments Per Floor = {b1.ApartmentsPerFloor()}");
            Buildings buildings = new Buildings();
            buildings[0] = b1;
            buildings[1] = new Building();
            buildings[1].Height = 40;
            Building firstBuilding = buildings[0];
            Console.WriteLine($"First Building Number - {firstBuilding.Number}");
            Console.WriteLine("-------------------");
            // H-W 14.1 Bank with atribut
            Console.WriteLine("H-W 14.1 Bank with atribut");
            var attrs = typeof(BankAccount).GetCustomAttributes(typeof(DeveloperInfoAttribute), false);
            var attr = attrs.FirstOrDefault() as DeveloperInfoAttribute;
            Console.WriteLine($"Developer name - {attr.DeveloperName}"); 
            Console.WriteLine($"Company - {attr.Company}");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
    
    

