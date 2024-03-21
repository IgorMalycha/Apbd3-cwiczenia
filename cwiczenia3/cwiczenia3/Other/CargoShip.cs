using System.Collections;

namespace cwiczenia3;

public class CargoShip
{
    public List<Container> allContainers = new List<Container>();
    public int MaxSpeed { get; set; }
    public int MaxContainersNum { get; set; }
    public int MaxAllContainersWeight { get; set; }
    
    public CargoShip(int maxSpeed, int maxContainersNum, int maxAllContainersWeight)
    {
        MaxSpeed = maxSpeed;
        MaxContainersNum = maxContainersNum;
        MaxAllContainersWeight = maxAllContainersWeight;
    }

    public void LoadingContainterOnShip(Container container)
    {
        int sum = 0;
        for (int i = 0; i < allContainers.Count; i++)
        {
            sum += allContainers[i].CargoWeight;
            sum += allContainers[i].ContainerWeight;
        }

        if (sum <= MaxAllContainersWeight)
        {
            allContainers.Add(container);
        }
    }

    public void RemoveContainer(Container container)
    {
        allContainers.Remove(container);
    }

    public void ReplaceContainer(string number, Container container)
    {
        for (int i = 0; i < allContainers.Count; i++)
        {
            if (allContainers[i].SerialNumber.getWholeNum() == number)
            {
                allContainers[i] = container;
                break;
            }
        }
    }

    public void MoveConatinerOnOtherShip(CargoShip cargoShip, string number)
    {
        for (int i = 0; i < allContainers.Count; i++)
        {
            if (allContainers[i].SerialNumber.getWholeNum() == number)
            {
                cargoShip.allContainers.Add(allContainers[i]);
                break;
            }
        }
    }
}