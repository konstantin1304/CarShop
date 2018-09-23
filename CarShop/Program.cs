using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            shop.AddCar(new Car("Mazda", "6", BodyType.Sedan, 1.6, 220, "Black", 25000));
            shop.AddCar(new Car("VAZ", "21083", BodyType.Hatchback, 1.5, 250, "Blue", 5000));
            shop.AddCar(new Car("TOYOTA", "RAV4", BodyType.Offroad, 2.0, 210, "Grey", 30000));

            shop.AddOwner(new Person("Ivanov", "Ivan", "Petrovich", new DateTime(1988,10,6), "iva@gmail.com", 0933530487));
            shop.AddOwner(new Person("Sidorov", "Andrey", "Semenovich", new DateTime(1975, 08, 3), "sid@gmail.com", 0660856193));
            shop.SellCar(0, 1);
            shop.SellCar(1, 0);
            shop.ShowCars();
            shop.ShowOwners();
            shop.ShowSoldCars();
            Console.ReadLine();
        }
    }
}
