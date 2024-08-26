using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryMethod
{
    public class Restaurant
    {
        public Burger OrderBurger(String type)
        {

            SimpleBurgerFactory factory = new SimpleBurgerFactory();
            Burger burger = factory.CreateBurger(type);
            burger.Prepare();
            return burger;

        }

    }
}
