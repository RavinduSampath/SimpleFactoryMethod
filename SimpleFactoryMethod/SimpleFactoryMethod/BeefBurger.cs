using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryMethod
{
    public class BeefBurger : Burger
    {
        public override void Prepare()
        {
            Console.WriteLine("I am prepearing BeefBurger");
        }
    }
}
