public class Truck : Vehicle, IMyCloneable<Truck>, ICloneable
{
    public int LoadCapacity { get; set; }

    public Truck(string make, string model, int loadCapacity) : base(make, model)
    {
        LoadCapacity = loadCapacity;
    }

    public Truck(Truck truck) : base(truck)
    {
        LoadCapacity = truck.LoadCapacity;
    }

    public override Truck Clone()
    {
        return new Truck(this);
    }

    object ICloneable.Clone()
    {
        return Clone();
    }
}
