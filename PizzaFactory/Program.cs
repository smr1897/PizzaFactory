using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the PizzaFactory !!");
            bool orderConfirmation = true;

            while(orderConfirmation)
            {
                Console.WriteLine("Which size of a pizza do you want ? (small / medium /large) : ");
                string pizzaSize = Console.ReadLine();
                List<string> toppings = new List<string>();

                Order order = new Order();

                bool addTopping = true;
                while(addTopping)
                {
                    Console.WriteLine("Which topping you want to add ? \n Avaliable Toppings : Cheese/pepperoni/ham :");
                    string topping = Console.ReadLine();
                    toppings.Add(topping);

                    Console.WriteLine("Do you want to add another topping ? : [Y/N]");
                    string extraToppingConfirmation = Console.ReadLine();
                    if(extraToppingConfirmation == "y")
                    {
                        addTopping = true;
                    }
                    else
                    {
                        addTopping= false;
                        break;
                    }

                }

                PizzaToken token = new PizzaToken();
                IPizza pizza = token.createPizza(pizzaSize, toppings);
                
                order.addPizza(pizza);

                Console.WriteLine("Do You want to add another pizza ? [Y/N]");
                string extraOrderConfirmation = Console.ReadLine();

                if(extraOrderConfirmation == "y")
                {
                    orderConfirmation = true;
                }
                else
                {
                    orderConfirmation = false;
                    order.printOrder();
                    break;
                }
            }


        }
    }
}
