using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Address[] addresses =  new Address[2];
        Customer[] customers =  new Customer[2];
        List<Product>[] productsLists = new List<Product>[2];
        Order[] orders = new Order[2];

        //ORDER 1 (USA)
        addresses[0] = new Address("6306 Pago Street", "Andre", "American Samoa", "USA");
        customers[0] =  new Customer("Mr. Ian Milford",addresses[0]);
        productsLists[0] = new List<Product>();
        productsLists[0].Add(new Product("Pisupo Povi","P0123",26.07f,4));
        productsLists[0].Add(new Product("12oz 4in1 Stainless Steel clear paint can","A001",33.08f,1));
        orders[0] = new Order(customers[0],productsLists[0]);

        //ORDER 2 (NOT USA)
        addresses[1] = new Address("123 Place South Park", "Patrick", "Auckland", "New Zealand");
        customers[1] =  new Customer("Joseph Parker",addresses[1]);
        productsLists[1] = new List<Product>();
        productsLists[1].Add(new Product("Acer Laptop 14inch i7 12gb ram", "P0124",281.09f,1));
        productsLists[1].Add(new Product("Dell 15.6 inch laptop","A012",212.23f,3));
        productsLists[1].Add(new Product("Hair trimmer, professional grade","A025",52.13f,6));
        orders[1] = new Order(customers[1],productsLists[1]);

        for(int i = 0; i < 2; i++)
        {
            Console.WriteLine($"\n-----CUSTOMER N°{i+1} ORDER-----");
            Console.WriteLine($"PACKING LABEL:\n{orders[i].GetPackingLabel()}"); 
            Console.WriteLine($"SHIPPING LABEL\n{orders[i].GetShippingLabel()}");
            Console.WriteLine($"TOTAL COST: ${orders[i].GetTotalCost()}");
        }
    }
}