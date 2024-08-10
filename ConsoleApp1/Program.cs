
using GuitarApp;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guitar App");
        Inventory inventory = new Inventory();
        inventory.AddGuitar("fd567", 1400, new GuitarSpec(Builder.Fender, "stratocastor", GuitarApp.Type.Electric, 6, Wood.Alder, Wood.Alder));
        inventory.AddGuitar("fd577", 1500, new GuitarSpec(Builder.Martin, "stratocastor", GuitarApp.Type.Acoustic, 6, Wood.Indian_RoseWood, Wood.Cedar));
        //Inventory.GetGuitar();

        GuitarSpec WhatErinLikes = new GuitarSpec(Builder.Fender, "stratocastor", GuitarApp.Type.Electric, 6, Wood.Alder, Wood.Alder);
        List<Guitar> matchingGuitars = inventory.SearchGuitar(WhatErinLikes);


        if (matchingGuitars != null)
        {
            Console.WriteLine("Erin you might like this");
            foreach (Guitar guitar in matchingGuitars)
            {
                Inventory.PrintGuitar(guitar);
            }
        }
        else
        {
            Console.WriteLine("Sorry Erin We Have Nothing For You");
        }

    }


}



