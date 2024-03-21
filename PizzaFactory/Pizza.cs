using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    public class Pizza : IPizza
    {
        public string size { get; }
        public List<string> toppings { get; }

        public Pizza(string size, List<string> toppings)
        {
            this.size = size;
            this.toppings = toppings;
        }

        public string getDescription()
        {
            return $"Size : {size} \n Toppings : {string.Join(" , ",toppings)}";
        }

        public int getCost()
        {
            int crustCost = 0;

            switch (size)
            {
                case ("small"):
                    crustCost = 10;
                    break;

                case ("medium"):
                    crustCost = 12;
                    break;

                case ("large"):
                    crustCost = 14;
                    break;

                default:
                    return crustCost;
            }

            return crustCost + toppings.Count * 2;

        }
    }
}
