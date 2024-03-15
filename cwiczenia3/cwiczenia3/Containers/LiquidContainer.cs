namespace cwiczenia3;

public class LiquidContainer : Container
{
    public LiquidContainer(string numsFirstLetters, string numsType, int cargoWeight, int cargoHeight, int containerWeight, int containerDepth, int maxWeight) : base(numsFirstLetters, numsType, cargoWeight, cargoHeight, containerWeight, containerDepth, maxWeight)
    {
        
    }

    public override void Load(int cargoWeight)
    {
        base.Load(cargoWeight);
    }
}