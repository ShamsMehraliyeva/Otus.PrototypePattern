public class Vehicle : IMyCloneable<Vehicle>, ICloneable
{
    public string Make { get; set; }
    public string Model { get; set; }

    public Vehicle(string make, string model)
    {
        Make = make;
        Model = model;
    }

    public Vehicle(Vehicle vehicle)
    {
        Make = vehicle.Make;
        Model = vehicle.Model;
    }

    public virtual Vehicle Clone()
    {
        return new Vehicle(this);
    }

    object ICloneable.Clone()
    {
        return Clone();
    }
}
