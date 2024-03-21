namespace cwiczenia3;

public class GasContainer : Container, IHazardNotifier

{
    public int Preasure { get; set; }

    public GasContainer(string numsFirstLetters, string numsType, int cargoWeight, int cargoHeight, int containerWeight, int containerDepth, int maxWeight, int preasure) : base(numsFirstLetters, numsType, cargoWeight, cargoHeight, containerWeight, containerDepth, maxWeight)
    {
        Preasure = preasure;
    }

    public override void UnLoad()
    {
        if (CargoWeight < (MaxWeight * 0.05))
        {
            Console.Write(Notifie(SerialNumber.getWholeNum()));
            CargoWeight = (int)(CargoWeight * 0.05);
        }
        
    }

    public string Notifie(string num)
    {
        return "Niebezpieczne operacja na kontenerze: " + num+ " za mało ładunku pzoostawionego w kontenerze";
    }
}