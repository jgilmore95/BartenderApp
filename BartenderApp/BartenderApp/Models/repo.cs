using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderApp.Models
{
    public class repo
    {
        

            private static List<CocktailMenu> order = new List<CocktailMenu>();
            public static IEnumerable<CocktailMenu> Orders
            {
                get
                {
                    return order;
                }
            }
            public static void AddOrder(CocktailMenu o)
            {
            order.Add(o);
            }
    }
}
