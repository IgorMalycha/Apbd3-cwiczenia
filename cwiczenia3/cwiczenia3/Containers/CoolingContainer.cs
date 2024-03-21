namespace cwiczenia3;

public class CoolingContainer : Container
{
    public double TemperatureInCargo { get; set; }
    public Product product { get; set; }

    public CoolingContainer(string numsFirstLetters, string numsType, int cargoWeight, int cargoHeight, int containerWeight, int containerDepth, int maxWeight, double temperatureInCargo, Product product) : base(numsFirstLetters, numsType, cargoWeight, cargoHeight, containerWeight, containerDepth, maxWeight)
    {
        TemperatureInCargo = temperatureInCargo;
        this.product = product;
    }
}