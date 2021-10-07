using System;

/*
    Accès: public, protected, private, internal
*/

namespace App
{
    // // First Structure
    // public readonly struct Disk
    // {
    //     public readonly string Brand;
    //     public readonly int Capacity;
    //     public Disk(string brand, int cap)
    //     {
    //         Brand = brand;
    //         Capacity = cap;
    //     }
    //     // Réécriture de la method ToString par défault !
    //     public override readonly string ToString() => $"Marque: { Brand }, de capacité: { Capacity }Go";
    // }

    // // Déplacer dans le fichier Stock.cs
    // public static class Stock
    // {
    //     private int Capacity;
    //     public Stock()
    //     {
    //         Capacity = 100;
    //     }
    //     public Stock(int capacity)
    //     {
    //         Capacity = capacity;
    //     }
    //     public override string ToString() => $"Capacité du stock: { Capacity }";

    // }

    class Program
    {
        static void Main(string[] args)
        {
            // Appel de notre constructeur
            Disk d = new Disk("toshiba", 1000);
            Disk d2 = new Disk("Seagate", 2000);

            // d.Brand = "Verbatim";
            // d.Capacity = 500;

            Console.WriteLine($"name: { d.Brand }, capacity: { d.Capacity } ");
            Console.WriteLine($"name: { d2.Brand }, capacity: { d2.Capacity } ");
            Console.WriteLine(d);
            Console.WriteLine(d2);

            Stock stocks_disk = new Stock();
            Stock stocks_mouse = new Stock(25);

            Console.WriteLine(stocks_disk);
        }
    }
}
