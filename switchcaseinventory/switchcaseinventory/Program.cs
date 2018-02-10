using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseInventory
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Product> prod = new List<Product>();

            prod.Add(new Product() { Name = "lettuce", Price = 10, Quantity = 50, Type = "leafygreen" });
            prod.Add(new Product() { Name = "cabbage", Price = 20, Quantity = 100, Type = "cruciferous" });
            prod.Add(new Product() { Name = "pumpkin", Price = 30, Quantity = 30, Type = "marrow" });
            prod.Add(new Product() { Name = "cauliflower", Price = 10, Quantity = 25, Type = "cruciferous" });
            prod.Add(new Product() { Name = "zucchini", Price = 20.5, Quantity = 50, Type = "marrow" });
            prod.Add(new Product() { Name = "yam", Price = 30, Quantity = 50, Type = "root" });
            prod.Add(new Product() { Name = "spinach", Price = 10, Quantity = 100, Type = "leafygreen" });
            prod.Add(new Product() { Name = "broccoli", Price = 20.2, Quantity = 75, Type = "cruciferous" });
            prod.Add(new Product() { Name = "garlic", Price = 30, Quantity = 20, Type = "leafygreen" });
            prod.Add(new Product() { Name = "silverbeet", Price = 10, Quantity = 50, Type = "marrow" });
           /* Console.WriteLine("which function do you want to perform?");
            Console.WriteLine("Case1: print the list of products according to their types.");
            Console.WriteLine("case2: print the the total price of the products in the list");
            Console.WriteLine("case3: print the average price of the products in the list");
            Console.WriteLine("case4: print the cheap and costly products in the list");*/
            
           
            int x = 0;
            do
            {
                Console.WriteLine("which function do you want to perform?");
                Console.WriteLine("Case1: print the list of products according to their types.");
                Console.WriteLine("case2: print the the total price of the products in the list");
                Console.WriteLine("case3: print the average price of the products in the list");
                Console.WriteLine("case4: print the cheap and costly products in the list");
                Console.WriteLine("case5: exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)

                {
                    case 1:

                        foreach (Product item in prod)
                        {
                            switch (item.Type)
                            {
                                case "leafygreen":
                                    Console.WriteLine("product under leafygreen:");

                                    Console.WriteLine(item.Name);
                                    Console.WriteLine();
                                    break;
                                case "cruciferous":
                                    Console.WriteLine("product under cruciferous:");

                                    Console.WriteLine(item.Name);
                                    Console.WriteLine();
                                    break;
                                case "marrow":
                                    Console.WriteLine("product under marrow:");

                                    Console.WriteLine(item.Name);
                                    Console.WriteLine();
                                    break;
                            }//switch1
                        }
                        break;
                    case 2:
                        double pricesum = 0;
                        double totalprice = 0;
                        foreach (Product item in prod)
                        {
                            pricesum = item.Price * item.Quantity;
                            totalprice = totalprice + pricesum;
                        }
                        Console.WriteLine("the total price of the products in the list:    " + totalprice);
                        break;

                    case 3:
                        double average = 0;
                        double sum = 0;
                        foreach (Product item in prod)
                        {
                            sum = sum + item.Price;
                            average = sum / prod.Count;
                        }
                        Console.WriteLine("the average price of the products in the list:    " + average);
                        break;
                    case 4:
                        Console.WriteLine("if you want to print list of cheap products choose case1 or else if you want to print list of costly products choose case 2");
                        int opt = Convert.ToInt32(Console.ReadLine());
                        switch (opt)

                        {
                            case 1:
                                List<string> mylist = new List<string>();
                                foreach (Product item in prod)
                                {
                                    if (item.Price > 50)
                                    {
                                        mylist.Add(item.Name);
                                    }

                                }
                                if (mylist.Count > 0)
                                {
                                    Console.WriteLine("print list of costly products");
                                    foreach (var item in mylist)
                                    {
                                        Console.Write(item + ",");
                                    }
                                }

                                else
                                {
                                    Console.WriteLine("There is no costly products in the list");
                                }

                                break;
                            case 2:
                                List<string> list = new List<string>();
                                foreach (Product item in prod)
                                {
                                    if (item.Price < 50)
                                    {
                                        list.Add(item.Name);
                                    }
                                }
                                if (list.Count > 0)
                                {
                                    Console.WriteLine("The cheap products in the list are:");
                                    foreach (var item in list)
                                    {
                                        Console.Write(item + ",");
                                    }
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine("There is no cheap products in the list");
                                }
                                break;
                            default:
                                Console.WriteLine("invalid option. Please choose a valid option");
                                break;
                        }// switch2
                        break;
                    case 5:
                        x = 1;
                        break;
                    default:
                        x = 1;
                        Console.WriteLine("invalid option. Please choose a valid option");
                        break;


                }// main switch
            } //while
            while (x < 1);
           


        }// main

    }// program



    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }
        public override string ToString()
        {
            return string.Format("Name={0}, price={1}, quantity={2}, Type={3} ", Name, Price, Quantity, Type);
        }
    }//classproduct
}

