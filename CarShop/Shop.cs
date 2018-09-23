using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    /// <summary>
    /// Class shop contains list of cars and list of clients of shop
    /// </summary>
    class Shop
    {
        /// <summary>
        /// List of cars
        /// </summary>
        private List<Car> Cars { get; set; }
        /// <summary>
        /// List of clients
        /// </summary>
        private List<Person> Owners { get; set; }

        /// <summary>
        /// Initialization of shop components
        /// </summary>
        public Shop()
        {
            Cars = new List<Car>();
            Owners = new List<Person>();
        }
        /// <summary>
        /// Adds car in list of cars
        /// </summary>
        /// <param name="car">Car</param>
        public void AddCar(Car car)
        {
            Cars.Add(car);
        }
        /// <summary>
        /// Adds client in list of clients
        /// </summary>
        /// <param name="owner">Client</param>
        public void AddOwner(Person owner)
        {
            Owners.Add(owner);
        }
        /// <summary>
        /// Writes the list of  on the screen 
        /// </summary>
        public void ShowCars()
        {
            Console.WriteLine("\nСписок автомобилей");
            for (int i = 0; i < Cars.Count; i++)
            {
                Console.WriteLine($"{Cars[i].Brand} {Cars[i].Model} {Cars[i].BodyType} {Cars[i].Color} {Cars[i].EngineVolume} {Cars[i].MaxSpeed} {Cars[i].Price} {((Cars[i].Owner == null) ? "null" :Owners.IndexOf(Cars[i].Owner).ToString())}");
            }
        }
        /// <summary>
        /// Writes the list of clients on the screen 
        /// </summary>
        public void ShowOwners()
        {
            Console.WriteLine("\nСписок клиентов");
            for (int i = 0; i < Owners.Count; i++)
            {
                Console.WriteLine($"{i} {Owners[i].Surname} {Owners[i].Name} {Owners[i].Patronymic} {Owners[i].TelNumber} {Owners[i].Email}");
            }
        }
        /// <summary>
        /// Writes the list of sold cars on the screen 
        /// </summary>
        public void ShowSoldCars()
        {
            Console.WriteLine("\nСписок проданых автомобилей");
            for (int i = 0; i < Cars.Count; i++)
            {
                if (Cars[i].Owner != null)
                {
                    Console.WriteLine($"{Cars[i].Brand} {Cars[i].Model} {Cars[i].BodyType} {Cars[i].Color} {Cars[i].EngineVolume} {Cars[i].MaxSpeed} {Cars[i].Price} {Owners.IndexOf(Cars[i].Owner).ToString()}");
                }
            }
        }
        /// <summary>
        /// Car sale
        /// </summary>
        /// <param name="carIndex">Car index in list of cars</param>
        /// <param name="ownerIndex">Client index in list of clients</param>
        public void SellCar(int carIndex, int ownerIndex)
        {
            Cars[carIndex].Sell(Owners[ownerIndex]);
        }

    }
}
