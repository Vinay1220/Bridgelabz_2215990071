using System;

namespace ECommercePlatform
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            ECommerce eCommerce = new ECommerce("Online Shop");

            while (true)
            {
                Console.WriteLine("\nE-Commerce Platform:");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Add Product");
                Console.WriteLine("3. Add Order");
                Console.WriteLine("4. View Customers");
                Console.WriteLine("5. View Products");
                Console.WriteLine("6. View Orders");
                Console.WriteLine("7. Remove Customer");
                Console.WriteLine("8. Remove Product");
                Console.WriteLine("9. Remove Order");
                Console.WriteLine("10. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Customer ID: ");
                        int custId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Customer Name: ");
                        string custName = Console.ReadLine();
                        eCommerce.AddCustomer(new Customer(custId, custName));
                        Console.WriteLine("Customer Added Successfully.");
                        break;

                    case 2:
                        Console.Write("Enter Product ID: ");
                        int prodId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Product Name: ");
                        string prodName = Console.ReadLine();
                        Console.Write("Enter Product Price: ");
                        decimal prodPrice = decimal.Parse(Console.ReadLine());
                        eCommerce.AddProduct(new Product(prodId, prodName, prodPrice));
                        Console.WriteLine("Product Added Successfully.");
                        break;

                    case 3:
                        Console.Write("Enter Order ID: ");
                        int orderId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Customer ID for Order: ");
                        int customerId = int.Parse(Console.ReadLine());
                        eCommerce.AddOrder(new Order(orderId, customerId));
                        Console.WriteLine("Order Added Successfully.");
                        break;

                    case 4:
                        eCommerce.ViewCustomers();
                        break;

                    case 5:
                        eCommerce.ViewProducts();
                        break;

                    case 6:
                        eCommerce.ViewOrders();
                        break;

                    case 7:
                        Console.Write("Enter Customer ID to remove: ");
                        int removeCustomerId = int.Parse(Console.ReadLine());
                        eCommerce.RemoveCustomer(removeCustomerId);
                        break;

                    case 8:
                        Console.Write("Enter Product ID to remove: ");
                        int removeProductId = int.Parse(Console.ReadLine());
                        eCommerce.RemoveProduct(removeProductId);
                        break;

                    case 9:
                        Console.Write("Enter Order ID to remove: ");
                        int removeOrderId = int.Parse(Console.ReadLine());
                        eCommerce.RemoveOrder(removeOrderId);
                        break;

                    case 10:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice. Try Again.");
                        break;
                }
            }
        }
    }
}
