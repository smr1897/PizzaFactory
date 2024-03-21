using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    public class CheeseTopping : IToppingName
    {
        public string Name => "Cheese";
    }
}
