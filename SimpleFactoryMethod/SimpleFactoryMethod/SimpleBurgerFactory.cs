using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryMethod
{
    public class SimpleBurgerFactory
    {
        public Burger CreateBurger(String type)
        {
            Burger burger = null;
            if (type == "Beef")
            {
                burger = new BeefBurger();
            }
            else if (type == "Veggie")
            {
                burger = new VeggieBurger();
            }
            return burger;
        }
    }
}
