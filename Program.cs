﻿using System;
using System.Globalization;
using ExercicioFixacao.Entities;
using ExercicioFixacao.Entities.Enums;
namespace ExercicioFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);            

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus orderData = Enum.Parse<OrderStatus>(Console.ReadLine());

            //OrderItem oI = new OrderItem();
            Order order = new Order(orderData);
            order.Moment = DateTime.Now;

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(quantity, productPrice, product);                
                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine("Order momente: " + order.Moment);
            Console.WriteLine("Order status: " + order.Status);
            Console.WriteLine("Client: " + client.ToString());
            Console.WriteLine("Order items: ");            
        }
    }
}