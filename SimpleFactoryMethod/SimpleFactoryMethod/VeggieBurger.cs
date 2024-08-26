using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryMethod
{
    public class VeggieBurger : Burger
    {
        public override void Prepare()
        {
            Console.WriteLine("I am Prepare in veggieBurger");
        }
    }
}
