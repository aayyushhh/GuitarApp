using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp
{
    public class Inventory
    {
        public static List<Guitar> guitars = new List<Guitar>();

        public static void PrintGuitar(Guitar guitar)
        {
            GuitarSpec guitarSpec = guitar.GetGuitarSpec();
            Console.WriteLine($"Serial Number : {guitar.SerialNumber}\n" +
                $"Price : {guitar.Price}\n" +
                $"Builder : {guitarSpec.Builder}\n" +
                $"Model : {guitarSpec.Model}\n" +
                $"Type : {guitarSpec.Type}\n" +
                $"String : {guitarSpec.NumString}\n" +
                $"Back Wood : {guitarSpec.BackWood}\n" +
                $"Top Wood : {guitarSpec.TopWood}\n");
        }

        public void AddGuitar(string serialNumber, double price, GuitarSpec guitarSpec)
        {
            Guitar guitar = new Guitar(serialNumber, price, guitarSpec);
            guitars.Add(guitar);
        }

        public static void GetGuitar()
        {
            Console.WriteLine("Enter Guitar's Serial Number : ");
            string serialNumber = Console.ReadLine();
            foreach (Guitar guitar in guitars)
            {
                if (guitar.SerialNumber == serialNumber)
                {
                    PrintGuitar(guitar);
                }
            }
        }

        public List<Guitar> SearchGuitar(GuitarSpec guitarSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            foreach (Guitar guitar in guitars)
            {
                if (guitar.GetGuitarSpec().Matches(guitarSpec))
                {
                    matchingGuitars.Add(guitar);
                }
            }
            return matchingGuitars;
        }

    }
}
