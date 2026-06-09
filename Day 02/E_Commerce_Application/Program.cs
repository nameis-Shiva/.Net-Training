using System;
using System.Collections.Generic;

abstract class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    private double price;

    public double Price
    {
        get { return price; }
        set
        {
            if (value > 0)
            {
                price = value;
            }
        }
    }

    public Product(int id, string name, double price)
    {
        ProductId = id;
        ProductName = name;
        Price = price;
    }

    public abstract double CalculateDiscount();

    public void DisplayProduct()
    {
        double discount = CalculateDiscount();
        double finalPrice = Price - discount;
        Console.WriteLine($"Product: {ProductName}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Discount: {discount}");
        Console.WriteLine($"Final Price: {finalPrice}");
        Console.WriteLine();
    }


}

class Electronics : Product
{
    public Electronics(int id, string name, double price) : base(id, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.10;
    }
}

class Clothing : Product
{
    public Clothing(int id, string name, double price) : base(id, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.20;
    }
}

class Grocery : Product
{
    public Grocery(int id, string name, double price) : base(id, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.05;
    }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>();

        products.Add(new Electronics(1, "Laptop", 50000));
        products.Add(new Clothing(2, "T-Shirt", 1000));
        products.Add(new Grocery(3, "Rice bag 20kg", 2000));

        foreach (Product p in products)
        {
            p.DisplayProduct();
        }
    }
}