public class ElectricCar : Car, IMyCloneable<ElectricCar>, ICloneable
{
    public int BatteryCapacity { get; set; }

    public ElectricCar(string make, string model, string fuelType, int doors, int batteryCapacity)
        : base(make, model, fuelType, doors)
    {
        BatteryCapacity = batteryCapacity;
    }

    public ElectricCar(ElectricCar car) : base(car)
    {
        BatteryCapacity = car.BatteryCapacity;
    }

    public override ElectricCar Clone()
    {
        return new ElectricCar(this);
    }

    object ICloneable.Clone()
    {
        return Clone();
    }
}
