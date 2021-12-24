using System;
namespace SantaClauseConsoleApp
{
    public class Item
    {
        public int ID;
        public string Name;
        public Item(string Name)
        {
            
            this.Name = Name;
        }
        public override string ToString()
        {
            return  Name.ToString();
        }
    }
}
