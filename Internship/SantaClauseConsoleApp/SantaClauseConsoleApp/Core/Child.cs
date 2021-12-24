using System;
using System.Diagnostics;

namespace SantaClauseConsoleApp
{

    public class Child
    {
        public string Name;
        public DateTime DataNastere;
        public string Adresa;
        public BehaviorEnum Comportament;
        public Letter Scrisoare;
        public Child(string Name, DateTime DataNastere, string Adresa, BehaviorEnum Comportament, Letter Scrisoare)
        {
            this.Name = Name;
            this.DataNastere = DataNastere;
            this.Adresa = Adresa;
            this.Comportament = Comportament;
            this.Scrisoare = Scrisoare;

        }

        public override string ToString()
        {
            return Name.ToString() + " , " + DataNastere.ToString() + " , " + Adresa.ToString() + " , " + Comportament.ToString() + " , " + Scrisoare.ToString();




        }
    }
    
}
