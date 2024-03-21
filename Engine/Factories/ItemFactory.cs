using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Engine.Models
{
    internal static class ItemFactory
    {
        private static List<GameItem> _standardGameItems;
        static ItemFactory()
        {

            _standardGameItems = new List<GameItem>();
            _standardGameItems.Add(new Weapon(100, "Sword", 2, "Long Sword", 1, 3));
            _standardGameItems.Add(new Weapon(101, "Sword", 6, "Katana", 1, 5));
            _standardGameItems.Add(new Weapon(102, "Sword", 5, "Machete", 1, 3));
            _standardGameItems.Add(new Weapon(103, "Sword", 10, "Claymore", 1, 6));




        }

        public static GameItem CreateGameItem()
        {


            if (_standardGameItems.Count > 0)
            {

                return _standardGameItems[0].Clone();


            }

            else
            {

                return null;
            }


















        }


    }
}