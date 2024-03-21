using cwiczenia3.Exceptions;

namespace cwiczenia3;

public class Container : IContainer
{
    public int CargoWeight { get; set; }
    public int ContainerHeight { get; set; }
    public int ContainerWeight { get; set; }
    public int ContainerDepth { get; set; }
    public SerialNumber SerialNumber {
        get;
        set;
    }
    public int MaxWeight { get; set; }

    public Container(string numsFirstLetters, string numsType, int cargoWeight, int cargoHeight, int containerWeight, int containerDepth, int maxWeight)
    {
        SerialNumber = new SerialNumber(numsFirstLetters, numsType);
        CargoWeight = cargoWeight;
        ContainerHeight = cargoHeight;
        ContainerWeight = containerWeight;
        ContainerDepth = containerDepth;
        MaxWeight = maxWeight;
    }

    public virtual void Load(int cargoWeight)
    {
        if (cargoWeight > MaxWeight)
        {
            throw new OverFillException();
        }
        CargoWeight = cargoWeight;
    }

    public virtual void UnLoad()
    {
        CargoWeight = 0;
    }

    public override string ToString()
    {
        return "CargoWeight: "+CargoWeight+" ContainerHeight: "+ContainerHeight+" ContainerWeight: "+ContainerWeight
               +" ContainerDepth: "+ContainerDepth+" SerialNumber: "+SerialNumber+" MaxWeight: "+ MaxWeight;
    }
}