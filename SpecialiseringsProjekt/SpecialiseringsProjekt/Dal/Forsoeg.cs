using System;
using System.Collections.Generic;
using System.Text;

namespace SpecialiseringsProjekt.Dal
{
    public class Forsoeg
    {
        public int Id { get; set; }
        public string Label { get; set; }

        public Forsoeg(int id, string label)
        {
            this.Id = id;
            this.Label = label;

        }




    }
}
