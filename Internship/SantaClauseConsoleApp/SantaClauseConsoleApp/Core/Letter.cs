using System;
using System.Collections.Generic;
namespace SantaClauseConsoleApp
{
    public class Letter
    {
        public DateTime DataScrierii;
        public LinkedList<Item> Jucarii;


        public Letter(DateTime DataScrierii, LinkedList<Item> Jucarii)
        {
            this.DataScrierii = DataScrierii;
            this.Jucarii = Jucarii;
        }
        public override string ToString()
        {
            return    DataScrierii.ToString()+ " , " + Jucarii.First.Value + " , "  + Jucarii.Last.Value;
        }
    }
}

