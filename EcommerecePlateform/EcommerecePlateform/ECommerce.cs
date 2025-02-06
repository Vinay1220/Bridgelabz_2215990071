using System;
using System.Collections.Generic;
using System.Linq;

namespace ECommercePlatform
{
    public class ECommerce
    {
        public string StoreName { get; set; }
        private List<Customer> customers = new List<Customer>();
        private List<Product> products = new List<Product>();
        private List<Order> orders = new List<Order>();

        public ECommerce(string storeName)
        {
            StoreName = storeName;
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public void ViewCustomers()
        {
            Console.WriteLine("\nCustomers in the Store:");
            if (customers.Count == 0)
            {
                Console.WriteLine("  No Customers Available.");
                return;
            }

            foreach (var customer in customers)
            {
                Console.WriteLine($"  - {customer.CustomerName} (ID: {customer.CustomerId})");
            }
        }

        public void ViewProducts()
        {
            Console.WriteLine("\nProducts in the Store:");
            if (products.Count == 0)
            {
                Console.WriteLine("  No Products Available.");
                return;
            }

            foreach (var product in products)
            {
                Console.WriteLine($"  - {product.ProductName} (ID: {product.ProductId}) - ${product.ProductPrice}");
            }
        }

        public void ViewOrders()
        {
            Console.WriteLine("\nOrders in the Store:");
            if (orders.Count == 0)
            {
                Console.WriteLine("  No Orders Available.");
                return;
            }

            foreach (var order in orders)
            {
                Console.WriteLine($"  - Order ID: {order.OrderId} (Customer ID: {order.CustomerId})");
            }
        }

        public void RemoveCustomer(int customerId)
        {
            var customer = customers.FirstOrDefault(c => c.CustomerId == customerId);
            if (customer != null)
            {
                customers.Remove(customer);
                Console.WriteLine("Customer Removed Successfully.");
            }
            else
            {
                Console.WriteLine("Customer Not Found.");
            }
        }

        public void RemoveProduct(int productId)
        {
            var product = products.FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                products.Remove(product);
                Console.WriteLine("Product Removed Successfully.");
            }
            else
            {
                Console.WriteLine("Product Not Found.");
            }
        }

        public void RemoveOrder(int orderId)
        {
            var order = orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order != null)
            {
                orders.Remove(order);
                Console.WriteLine("Order Removed Successfully.");
            }
            else
            {
                Console.WriteLine("Order Not Found.");
            }
        }
    }
}
