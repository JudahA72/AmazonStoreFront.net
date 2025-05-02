using System;
using System.Xml.Serialization;
using Library.eCommerce.Models;
using Library.eCommerce.Services;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome To Amazon Simulator!");

            Console.WriteLine("C. Create a new inventory item");
            Console.WriteLine("R. Read all the inventory items");
            Console.WriteLine("U. Update an inventory item");
            Console.WriteLine("D. Delete an inventory item");
            Console.WriteLine("Q. to exit the menu");

            List<Product?> list = ProductServiceProxy.Current.Products;

            char choice;
            do{
                string? input = Console.ReadLine();
                 choice = input[0];
                    switch(choice)
                    {
                        case 'C'://adding to a list
                        case 'c':
                        ProductServiceProxy.Current.AddorUpdate(new Product
                        {
                            Name = Console.ReadLine() ?? "ERROR"
                        });
                            
                            break;
                        case 'R':
                        case 'r'://print out all items on the list
                           list.ForEach(Console.WriteLine);

                            break;
                        case 'U':
                        case 'u'://selecting item and updating new item to the list
                                Console.WriteLine("Which product would you like to update?");
                                int selection = int.Parse(Console.ReadLine()?? "-1");
                                var selectedProd = list.FirstOrDefault(p => p.Id == selection);
                                if(selectedProd != null)
                                {
                                    selectedProd.Name = Console.ReadLine()?? "ERROR";
                                    ProductServiceProxy.Current.AddorUpdate(selectedProd);
                                }
                                
                            break;
                        case 'D'://select item and deleting item from the list
                        case 'd':
                            Console.WriteLine("Which product would you like to delete?");
                             selection = int.Parse(Console.ReadLine()?? "-1");
                             selectedProd = list.FirstOrDefault(p => p.Id == selection);
                             ProductServiceProxy.Current.Delete(selection);
                            break;
                        case 'Q':
                        case 'q':

                        break;

                        default:
                            Console.WriteLine("Error Unknown Input");
                            break;
                    }
            } while(choice != 'Q' && choice != 'q');
            Console.ReadLine();
        }
    }
}















