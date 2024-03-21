using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    public class PizzaToken 
    {
        public IPizza createPizza(string size , List<string> toppings)
        {
            return new Pizza(size, toppings);
        }
    }
}
