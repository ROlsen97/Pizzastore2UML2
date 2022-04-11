using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzastore2UML2
{
    public class MenuCatalog
    {
        Dictionary<int, Pizza> pizzas;

        public MenuCatalog()
        {
            pizzas = new Dictionary<int, Pizza>();
        }
        public void CreatePizza(Pizza pizza)
        {
            pizzas.Add(pizza.Number, pizza);
        }

        public void UpdatePizza(Pizza pizza)
        {
            pizzas[pizza.Number] = pizza;
        }
        public void DeletePizza(int NumberToRemove)
        {

            if (pizzas.ContainsKey(NumberToRemove))
            {
                pizzas.Remove(NumberToRemove);
            }
        }
        public Pizza ReadPizza(int Number)
        {
            return pizzas[Number];
        }
        public void ReadMenu()
        {
            foreach (var item in pizzas)
            {
                Console.WriteLine(item);
            }


        }
        
    }
}
