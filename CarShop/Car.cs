using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    enum BodyType {Sedan, Hatchback, Offroad, Coupe}
    /// <summary>
    ///  Car specifications
    /// </summary>
    class Car
    {

        public string Brand { get; private set; }
        public string Model { get; private set; }
        public BodyType BodyType { get; private set; }
        public double EngineVolume { get; private set; }
        public ushort MaxSpeed { get; private set; }
        public string Color { get; private set; }
        public decimal Price { get; private set; }
        public Person Owner { get; private set; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="brand">Brand</param>
        /// <param name="model">Model</param>
        /// <param name="bodyType">Body type</param>
        /// <param name="engineVolume">Engine volume</param>
        /// <param name="maxSpeed">Max speed</param>
        /// <param name="colour">Color</param>
        /// <param name="price">Price</param>
        public Car(string brand, string model, BodyType bodyType, double engineVolume, ushort maxSpeed, string colour, decimal price)
        {
            this.Brand = brand;
            this.Model = model;
            this.BodyType = bodyType;
            this.EngineVolume = engineVolume;
            this.MaxSpeed = maxSpeed;
            this.Color = colour;
            this.Price = price;

        }
        /// <summary>
        /// Car sale
        /// </summary>
        /// <param name="owner">Client</param>
        public void Sell(Person owner)
        {
            this.Owner = owner;
        }

    }
}
