using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    public class Order
    {
        public List<IPizza> pizzaOrders = new List<IPizza>();

        public void addPizza(IPizza pizza)
        {
            pizzaOrders.Add(pizza);
        }

        public void printOrder()
        {
            Console.WriteLine("Your Order");
            foreach(var pizza in  pizzaOrders)
            {
                Console.WriteLine(pizza.getDescription());
                Console.WriteLine($"Cost for Pizza : {pizza.getCost()}");
            }

            Console.WriteLine($"Total Cost : {getTotalCost()}");
            
        }

        private int getTotalCost()
        {
            return pizzaOrders.Sum(pizza => pizza.getCost());
        }
    }
}
