using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personsList = new List<Person>();
            List<Product> productsList = new List<Product>();

            string[] persons = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < persons.Length; i++)
            {
                string[] personInfo = persons[i].Split("=", StringSplitOptions.RemoveEmptyEntries);

                string name = personInfo[0];
                decimal money = decimal.Parse(personInfo[1]);

                Person person = new Person(name, money);

                personsList.Add(person);
            }

            string[] products = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < products.Length; i++)
            {
                string[] productInfo = products[i].Split("=", StringSplitOptions.RemoveEmptyEntries);

                string productName = productInfo[0];
                decimal productPrice = decimal.Parse(productInfo[1]);

                Product currentProduct = new Product(productName, productPrice);

                productsList.Add(currentProduct);
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = command.Split();

                string person = cmdArgs[0];
                string product = cmdArgs[1];

                Person currentPerson = personsList.Find(x => x.Name == person);

                Product currentProduct = productsList.Find(x => x.Name == product);

                if (personsList.Contains(currentPerson))
                {
                    if (productsList.Contains(currentProduct))
                    {
                        currentPerson.AddProduct(currentProduct);
                    }
                }
            }

            foreach (var item in personsList)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Person
    {
        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            BagOfProducts = new List<Product>();
        }

        public string Name { get; set; }

        public decimal Money { get; set; }

        public List<Product> BagOfProducts { get; set; }

        public void AddProduct(Product product)
        {
            if(this.Money >= product.Costs)
            {
                BagOfProducts.Add(product);
                this.Money -= product.Costs;
                Console.WriteLine($"{this.Name} bought {product.Name}");

            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
        }

        public override string ToString()
        {
            if(BagOfProducts.Count > 0)
            {
                return $"{this.Name} - {string.Join(", ", this.BagOfProducts)}";
            }
            else
            {
                return $"{this.Name} - Nothing bought";
            }
            
        }
    }

    class Product
    {
        public Product(string name, decimal costs)
        {
            this.Name = name;
            this.Costs = costs;
        }
        public string Name { get; set; }

        public decimal Costs { get; set; }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
