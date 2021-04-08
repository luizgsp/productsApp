using System;
using System.Collections.Generic;
using System.Linq;
using ProdutctsApp.Entities;

namespace ProdutctsApp
{
    class Program
    {

        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach(T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };
            Category c4 = new Category() { Id = 4, Name = "Mobiles", Tier = 1 };
            Category c5 = new Category() { Id = 5, Name = "TVs", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product() {Id = 1, Name = "Computer", Price = 1100.0, Category = c2},
                new Product() {Id = 2, Name = "Hamme", Price = 20.0, Category = c1},
                new Product() {Id = 3, Name = "TV LED", Price = 700.0, Category = c5},
                new Product() {Id = 4, Name = "SmartTV", Price = 1700.0, Category = c5},
                new Product() {Id = 5, Name = "Laptop", Price = 1300.0, Category = c2},
                new Product() {Id = 6, Name = "Saw", Price = 40.0, Category = c1},
                new Product() {Id = 7, Name = "Tablet", Price = 700.0, Category = c4},
                new Product() {Id = 8, Name = "Camera", Price = 700.0, Category = c3},
                new Product() {Id = 9, Name = "Printer", Price = 350.0, Category = c3},
                new Product() {Id = 10, Name = "MacBook", Price = 1800.0, Category = c2},
                new Product() {Id = 11, Name = "Sound Bar", Price = 700.0, Category = c3},
                new Product() {Id = 12, Name = "Pendrive 64GB", Price = 10.0, Category = c3},
                new Product() {Id = 13, Name = "Level", Price = 30.0, Category = c1},
                new Product() {Id = 14, Name = "Samsung S10", Price = 800.0, Category = c4},
                new Product() {Id = 15, Name = "Samsung S20", Price = 1400.0, Category = c4},
                new Product() {Id = 16, Name = "Iphone 8", Price = 350.0, Category = c4},
                new Product() {Id = 17, Name = "Iphone X", Price = 550.0, Category = c4},
                new Product() {Id = 18, Name = "Iphone 11", Price = 780.0, Category = c4},
                new Product() {Id = 19, Name = "Iphone 12", Price = 1300.0, Category = c4},
                new Product() {Id = 20, Name = "SmartWatch", Price = 120.0, Category = c3},
            };


            Console.WriteLine();

            //var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900);
            var r1 = from p in products
                     where p.Category.Tier == 1 && p.Price < 900
                     select p;
            Print("TIER: 1 e Preco < 900", r1);

            var r2 = products
                .Where(p => p.Category.Name == "Tools")
                .Select(p => p.Name);
            Print("Somente produtos da Categoria TOOLS",r2);

            //Console.Write("Pesquisa:");
            //var name = Console.ReadLine();

            //var r3 = products
            //    .Where(p => p.Name.StartsWith('C'))
            //    .Select(p => new {p.Name, p.Price, CategoryName = p.Category.Name  });
            var r3 = from p in products
                     where p.Name.StartsWith('C')
                     select new
                     {
                         p.Name,
                         p.Price,
                         CategoryName = p.Category.Name
                     };
            Print("Produtos da pesquisa:", r3);

            var r4 = products
                    .Where(p => p.Category.Tier == 1)
                    .OrderBy(p => p.Price)
                    .ThenBy(p => p.Name);
            Print("Produtos ordenados por Preco e Nome:", r4);

            var r5 = (from p in products select p)
                .Skip(2)
                .Take(4);
            Print("Produtos paginados:", r5);

            var r6 = (from p in products select p)
                .FirstOrDefault();
            Console.WriteLine ("Primeiro Produto:{0}", r6);

            var r8 = products
                    .Where(p => p.Id == 1)
                    .SingleOrDefault();
            Console.WriteLine("Um unico resultado:{0}", r8);

            var r10 = products
                    .Max(p => p.Price);
            Console.WriteLine("Maior preco:{0}", r10);

            var r12 = products
                    .Where(p => p.Category.Id == 2)
                    .Sum(p => p.Price);
            Console.WriteLine("Produtos da categoria 2 soma:{0}", r12);

            var r15 = products
                    .Where(p => p.Category.Id == 2)
                    .Select(p => p.Price)
                    .Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Produtos da categoria 2 e aggregate soma:{0}", r15);
            Console.WriteLine();


            //var r16 = products
            //        .GroupBy(p => p.Category);
            var r16 = (from p in products
                       group p by p.Category);
            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Categoria:{0}", group.Key.Name);
                foreach(Product product in group)
                {
                    Console.WriteLine(product);
                }
                Console.WriteLine();
            }
        }
    }
}
