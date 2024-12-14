namespace Otus.PrototypePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyota", "Camry", "Petrol", 4);
            Car clonedCar = car.Clone();
            Console.WriteLine($"Original Car: {car.Make} {car.Model}, {car.FuelType}, {car.Doors} doors");
            Console.WriteLine($"Cloned Car: {clonedCar.Make} {clonedCar.Model}, {clonedCar.FuelType}, {clonedCar.Doors} doors");

            ElectricCar electricCar = new ElectricCar("Tesla", "Model S", "Electric", 4, 100);
            ElectricCar clonedElectricCar = electricCar.Clone();
            Console.WriteLine($"Original Electric Car: {electricCar.Make} {electricCar.Model}, {electricCar.BatteryCapacity} kWh");
            Console.WriteLine($"Cloned Electric Car: {clonedElectricCar.Make} {clonedElectricCar.Model}, {clonedElectricCar.BatteryCapacity} kWh");
        }

    }
}
