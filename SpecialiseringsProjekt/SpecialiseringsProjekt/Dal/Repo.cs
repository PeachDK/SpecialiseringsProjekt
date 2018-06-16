using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace SpecialiseringsProjekt.Dal
{
    public class Repo
    {
        private static readonly Repo _staticinstance = new Repo();
        public static Repo StaticInstance
        {
            get
            {
                return _staticinstance;
            }
        }
        
        private ObservableCollection<Forsoeg> forsoegs = new ObservableCollection<Forsoeg>();

        public ObservableCollection<Forsoeg> GetForsoeg()
        {

            return forsoegs;

        }

        private Repo()
        {
            forsoegs.Add(new Forsoeg(0001, "Korn-Pesticide"));
            forsoegs.Add(new Forsoeg(0002, "Tulipaner"));
            forsoegs.Add(new Forsoeg(0003, "Hvede-Gødning"));
            forsoegs.Add(new Forsoeg(0004, "Afgrøde"));

        }








    }
}
