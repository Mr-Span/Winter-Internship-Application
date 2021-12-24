using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaClauseConsoleApp
{
    public class Adress
    {
        public string City;
        public string Street;
        public Adress   (string City, string Street)
        {
            this.City = City;
            this.Street = Street;
        }
        public override string ToString()
        {
            return City.ToString() + " , " + Street.ToString();




        }
    }
}
