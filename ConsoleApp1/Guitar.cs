using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GuitarApp
{
    public enum Builder
    {
        Fender,
        Martin,
        Gibson,
        PRS
    }

    public enum Type
    {
        Acoustic,
        Electric
    }

    public enum Wood
    {
        Indian_RoseWood,
        Brazilian_RoseWood,
        Cedar,
        Alder,
        Sitka
    }
    public class Guitar
    {
        public string SerialNumber { get; set; }
        public double Price { get; set; }
        GuitarSpec spec;
        public Guitar(string number, double price, GuitarSpec guitarSpec)
        {
            SerialNumber = number;
            Price = price;
            spec = guitarSpec;
        }

        public GuitarSpec GetGuitarSpec()
        {
            return spec;
        }

    }




}

