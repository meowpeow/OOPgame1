using System.Collections.Generic;

namespace OOPgame1.Actors
{
    internal class Inventory
    {

        private static Inventory instance;
        public static Inventory getInstance()
        {
            if (instance == null)
            {
                instance = new Inventory();
            }
            return instance;
        }

        public List<string> ItemList { get; set; }
    }
}