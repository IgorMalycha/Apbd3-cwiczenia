using System.Security.AccessControl;
using System.Xml;
using cwiczenia3.Exceptions;

namespace cwiczenia3;

public class LiquidContainer : Container, IHazardNotifier
{
    public bool IsDangerous { get; set; }

    public LiquidContainer(string numsFirstLetters, string numsType, int cargoWeight, int cargoHeight, int containerWeight, int containerDepth, int maxWeight, bool isDangerous) : base(numsFirstLetters, numsType, cargoWeight, cargoHeight, containerWeight, containerDepth, maxWeight)
    {
        IsDangerous = isDangerous;
    }

    public override void Load(int cargoWeight)
    {
        if (IsDangerous)
        {
            if (cargoWeight >= (MaxWeight / 2))
            {
                Console.WriteLine(Notifie(SerialNumber.getWholeNum()));
            }
            else
            {
                CargoWeight = cargoWeight;
            }
                
        }
        else
        {
            if (cargoWeight >= (MaxWeight * 0.9))
            {
                Console.Write("operacja niebezpieczna");
            }
            else
            {
                CargoWeight = cargoWeight;
            }
        }
    }

    public string Notifie(String num)
    {
        return "Niebezpieczna operajca na kontenerze: " + num + " za dużo płynu w kontenerze";
    }
}