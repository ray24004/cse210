using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        Console.WriteLine();

        List<Product> products1 = new List<Product>()
        {
            new Product("001", "Keyboard", 49.99f, 1),
            new Product("002", "Ergonomic Mouse", 34.50f, 1),
            new Product("003", "LED Monitor", 199.00f, 1)
        };
        Address address1 = new Address("Rua Floripa Mullmann 180", "Colombo", "Parana", "Brazil");
        Customer customer1 = new Customer("Wesley Raymundo", address1);
        Order order1 = new Order(customer1, products1);

        List<Product> products2 = new List<Product>()
        {
            new Product("010", "Wireless Controller", 69.99f, 1),
            new Product("023", "2TB SSD", 129.99f, 1),
            new Product("085", "Console Dock", 49.99f, 1)
        };
        Address address2 = new Address("1234 Elmwood Drive", "Springfield", "IL", "USA");
        Customer customer2 = new Customer("Henrique Nascimento", address2);
        Order order2 = new Order(customer2, products2);
        
        List<Order> orders = new List<Order>()
        {
            order1,
            order2
        };

        for (int i = 0; i < orders.Count; i++)
        {
            Order order = orders[i];
            Console.WriteLine($"===== ORDER {i+1:000}");
            Console.WriteLine();
            
            Console.WriteLine($"PRODUCTS:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine($"TO:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();

            Console.WriteLine($"TOTAL: $ {order.GetTotalPrice():.00}");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}