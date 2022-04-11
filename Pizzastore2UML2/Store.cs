using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzastore2UML2
{
    class Store
    {
        public void start()
        {
            MenuCatalog mc1 = new MenuCatalog();

            Pizza p1 = new Pizza() { Number = 1, Name = "Hawaii", Price = 99 };
            Pizza p2 = new Pizza() { Number = 2, Name = "Kebab", Price = 109 };
            Pizza p3 = new Pizza() { Number = 3, Name = "Kylling", Price = 119 };
            Pizza p4 = new Pizza() { Number = 4, Name = "Mixed", Price = 129 };
            Pizza p5 = new Pizza() { Number = 5, Name = "Pep med dress", Price = 139 };

            mc1.CreatePizza(p1);
            mc1.CreatePizza(p2);
            mc1.CreatePizza(p3);
            mc1.CreatePizza(p4);
            mc1.CreatePizza(p5);
            
            Pizza UpdateNewPizza()
            {
                Pizza Updatedpizzaitem = new Pizza();
                Console.Clear();
                Console.WriteLine("--------------");
                Console.WriteLine("Updating pizza");
                Console.WriteLine("--------------");
                Console.WriteLine();
                
                Console.WriteLine("Enter the number of the pizza you want to update");
                    
                int Updatedinputnumber = int.Parse(Console.ReadLine());
                Updatedpizzaitem.Number = Updatedinputnumber;
                
                Console.WriteLine("Enter new name : ");
                Updatedpizzaitem.Name = Console.ReadLine();

                string Updatedinputprice = "";
                Console.WriteLine("Enter updated price: ");
                try
                {
                    Updatedinputprice = Console.ReadLine();
                    Updatedpizzaitem.Price = Int32.Parse(Updatedinputprice);
                }
                catch (FormatException er)
                {
                    Console.WriteLine($"unable to parse {Updatedinputprice} - Message {er.Message}");
                    throw;
                }
                mc1.UpdatePizza(Updatedpizzaitem);
                return Updatedpizzaitem;
            }
            Pizza GetNewPizza()
            {
                Pizza pizzaitem = new Pizza();
                Console.Clear();
                Console.WriteLine("--------------------");
                Console.WriteLine(" Creating new pizza ");
                Console.WriteLine("--------------------");
                Console.WriteLine();

                string InputNumber = "";
                Console.WriteLine("Enter pizza number: ");
                try
                {
                    InputNumber = Console.ReadLine();
                    pizzaitem.Number = Int32.Parse(InputNumber);
                }
                catch(FormatException e)
                {
                    Console.WriteLine($"unable to parse '{InputNumber}' - Message {e.Message}");
                }
                Console.WriteLine("Enter name: ");
                pizzaitem.Name = Console.ReadLine();

                string InputPrice = "";
                Console.Write("Enter Price: ");
                try
                {
                    InputPrice = Console.ReadLine();
                    pizzaitem.Price = Int32.Parse(InputPrice);

                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Unable to parse '{InputPrice}' - Message{e.Message}");
                    throw;
                }
                mc1.CreatePizza(pizzaitem);
                return pizzaitem;
                
            }
            static int MainMenuValg(List<string> menuitems)
            {
                Console.Clear();
                Console.WriteLine("----------------------");
                Console.WriteLine("Rubberboi's pizzastore");
                Console.WriteLine("----------------------");
                Console.WriteLine();
                Console.WriteLine("Options");

                foreach (string choice in menuitems)
                {
                    Console.WriteLine(choice);
                }

                Console.WriteLine("Enter option#: ");
                string input = Console.ReadKey().KeyChar.ToString();

                try
                {
                    int result = Int32.Parse(input);
                    return result;
                }
                catch (FormatException)
                {
                    Console.WriteLine($"unable to parse'{input}'");
                }
                return -1;
            }

            bool proceed = true;
            List<string> mainmenulist = new List<string>()
                {
                    "0. Quit",
                    "1. Lav en ny pizza",
                    "2. Pizza catalog",
                    "3. Søg efter en pizza",
                    "4. Slet en pizza",
                    "5. Opdater en pizza"
                };
            while (proceed)
            {
                int MenuValg = MainMenuValg(mainmenulist);
                Console.WriteLine();
                switch (MenuValg)
                {
                    case 0:
                        proceed = false;
                        Console.WriteLine("Quitting");
                        break;
                    case 1:
                        try
                        {
                            Pizza ff = GetNewPizza();
                            Console.WriteLine($"you created {ff}");
                            Console.WriteLine($"Hit any key to return to dialog");
                            Console.ReadKey();
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"Can't create a pizza that overwrites other pizzas - try to update a pizza instead");
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        Console.WriteLine($"You selected {mainmenulist[MenuValg]}");
                        Console.WriteLine($"Dette er kataloget");
                        mc1.ReadMenu();
                        Console.Write($"hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 3:
 
                        Console.WriteLine($"You selected option 3. to search for a pizza");
                        Console.WriteLine($"Select the pizza number you want to search for");

                        try
                        {
                            int ChosenNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine($"the input you gave was {ChosenNumber}");
                            Console.WriteLine($"the pizza you searched for was: {mc1.ReadPizza(ChosenNumber)}");
                        }
                        catch (Exception ex)
                        {
                            Console.Write(ex.Message);
                            Console.WriteLine();
                            Console.WriteLine($"The pizza doesn't exist");
                        }
                        Console.Write($"hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine($"The selected option 4 to Delete a pizza");
                        Console.WriteLine($"Select the number for the pizza you want to delete");
                        try
                        {
                            int ChosenNumberC4 = int.Parse(Console.ReadLine());
                            Console.WriteLine($"You chose to delete pizza number {ChosenNumberC4}, pizza has been removed)");
                            mc1.DeletePizza(ChosenNumberC4);
                        }
                        
                        catch(Exception c4)
                        {
                            Console.Write(c4.Message);
                            Console.WriteLine();
                            Console.WriteLine($"Can't remove pizza");
                        }
                        Console.Write($"Hit any key to move to start menu");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine($"You've selected option 5 to update a pizza");
                        Console.WriteLine($"Chose the number of the pizza you want to update");
                        try
                        {
                            Pizza ee = UpdateNewPizza();
                            
                            Console.WriteLine($"{ee}");
                            Console.WriteLine("hit any key to return to start menu");
                            Console.ReadKey();
                            break;
                        }
                        catch(Exception)
                        {
                            Console.WriteLine("no pizza was updated");
                        }
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}

