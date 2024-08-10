using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp
{
    public class GuitarSpec
    {
        public Builder Builder { get; set; }
        public string Model { get; set; }
        public Type Type { get; set; }
        public Wood BackWood { get; set; }
        public Wood TopWood { get; set; }
        public int NumString { get; set; }

        public GuitarSpec(Builder builder, string model, Type type, int numstring, Wood backwood, Wood topwood)
        {
            Builder = builder;
            Model = model;
            Type = type;
            NumString = numstring;
            BackWood = backwood;
            TopWood = topwood;
        }


        public bool Matches(GuitarSpec guitarSpec)
        {
            if (Builder != guitarSpec.Builder)
                return false;
            if ((Model != null) && (!Model.Equals("")) && (!Model.ToLower().Equals(guitarSpec.Model.ToLower())))
                return false;
            if (Type != guitarSpec.Type)
                return false;
            if (BackWood != guitarSpec.BackWood)
                return false;
            if (TopWood != guitarSpec.TopWood)
                return false;
            return true;
        }
    }
}
