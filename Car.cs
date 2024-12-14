public class Car : Vehicle, IMyCloneable<Car>, ICloneable
{
    public string FuelType { get; set; }
    public int Doors { get; set; }

    public Car(string make, string model, string fuelType, int doors)
        : base(make, model)
    {
        FuelType = fuelType;
        Doors = doors;
    }

    public Car(Car car) : base(car)
    {
        FuelType = car.FuelType;
        Doors = car.Doors;
    }

    public override Car Clone()
    {
        return new Car(this);
    }

    object ICloneable.Clone()
    {
        return Clone();
    }
}
