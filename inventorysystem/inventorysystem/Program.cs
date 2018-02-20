using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorysystem
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


            foreach (Product item in prod)
            {
                Console.WriteLine(item);

            }
            //1.length of the list

            Console.WriteLine("The length of the array is " + prod.Count);

            // 2.add new product potato 

            prod.Insert(prod.Count, new Product() { Name = "Potato", Price = 10, Quantity = 50, Type = "root" });
            Console.WriteLine("The new list of products: ");
            foreach (Product item in prod)
            {
                Console.WriteLine(item);

            }
            //2.count the length
            Console.WriteLine("The length of the array is " + prod.Count);
            
            

            //3.list of products with type leafygreeN

            Console.WriteLine("the name of the product with leafygreen type");

            foreach (Product item in prod)
            {
                if (item.Type == "leafygreen")
                {

                    Console.WriteLine(item.Name);
                }
            }
            // 4.delete garlic product
            Console.WriteLine("As all the garlic are sold out we need to remove them from the list");
            prod.RemoveAt(8);
            foreach (Product item in prod)
            {
                Console.WriteLine(item);

            }
            //4. PRINT THE LENGTH

            Console.WriteLine("The length of the array is " + prod.Count);

            //5.add 50 cabages
            Console.WriteLine("After adding 50 more cabbages in the inventory");
            
            var cab = prod.Where(w => w.Name == "cabbage").Select(s => { s.Quantity = s.Quantity + 50; return s; }).ToList();
            foreach (Product item in cab)
            {
                Console.WriteLine(item);

            }

            //6. calculate the total price
            double PriceSum = 0;
            Console.WriteLine("the total price of the item is");
            foreach (Product item in prod)
            {
                if (item.Name == "lettuce")
                {
                   
                    PriceSum = PriceSum + (item.Price * 1);
                }
                if (item.Name == "zucchini")
                {
                    PriceSum = PriceSum + item.Price * 2;
                }
                if (item.Name == "broccoli")
                {
                    PriceSum = PriceSum + item.Price * 1;
                }

            }

            Console.WriteLine(Math.Round(PriceSum));


        }//main
    }//class
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }
        public override string ToString()
        {
            return string.Format("Name={0}, price=Rs{1}, quantity={2}, Type={3} ", Name, Price, Quantity, Type);
        }
    }//classperson
}//namespace
