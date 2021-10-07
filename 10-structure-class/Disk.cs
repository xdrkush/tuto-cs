
namespace App
{
    public readonly struct Disk
    {
        public readonly string Brand;
        public readonly int Capacity;
        public Disk(string brand, int cap)
        {
            Brand = brand;
            Capacity = cap;
        }
        // Réécriture de la method ToString par défault !
        public override readonly string ToString() => $"Marque: { Brand }, de capacité: { Capacity }Go";
    }
}