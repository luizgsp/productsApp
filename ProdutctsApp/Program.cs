using System;
using System.Collections.Generic;
using ProdutctsApp.Entities;

namespace ProdutctsApp
{
    class Program
    {
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

        }
    }
}
