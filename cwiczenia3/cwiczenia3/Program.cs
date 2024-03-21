using System.ComponentModel;
using cwiczenia3;
using Container = cwiczenia3.Container;

public class Program{
    
    public static void Main(string[] args)
    {

        CargoShip cargoShip = new CargoShip(14, 100, 400);
        LiquidContainer liquidContainer = new LiquidContainer("tco", "C", 100, 20, 60, 20, 200, true);
        CargoShip cargoShip2 = new CargoShip(10, 100, 400);
        Console.WriteLine(liquidContainer);
        liquidContainer.Load(100);
        Console.WriteLine(cargoShip.ToString());
        cargoShip.LoadingContainterOnShip(liquidContainer);
        liquidContainer.UnLoad();
        cargoShip.RemoveContainer(liquidContainer);
        
        
        

        // List<CargoShip> cargoShips = new List<CargoShip>();
        // List<Container> containers = new List<Container>();
        //
        // while (true)
        // {
        //     Console.Write("Lista Kontenerowcow: ");
        //     if (cargoShips.Count == 0)
        //     {
        //         Console.Write("Brak");
        //     }
        //     else
        //     {
        //         for (int i = 1; i <= cargoShips.Count; i++)
        //         {
        //             Console.Write("Statek "+i + " ("+ cargoShips[i]+ ")");
        //         }
        //         
        //         Console.Write("Lista Kontenerów: ");
        //         if (containers.Count == 0)
        //         {
        //             Console.Write("Brak");
        //         }
        //         else
        //         {
        //             for (int i = 1; i <= containers.Count; i++)
        //             {
        //                 Console.Write("Kontener "+i + " ("+ containers[i]+ ")");
        //             }
        //         }
        //     }
        //     
        //
        //     Console.Write("Możliwe Akcje: (wpisz numer)");
        //         Console.Write("1. Dodaj kontenerowiec");
        //
        //         if (containers.Count() != 0)
        //         {
        //             Console.Write("2. Usun kontenerowiec");
        //             Console.Write("3. Dodaj kontener");
        //             // Console.Write("4. Umiesc kontenery na statku");
        //             // Console.Write("5. Zaladuj ladunek do kontenera");
        //             // Console.Write("6. Usun kontener");
        //             // Console.Write("7. Usun kontener z kontenerowca");
        //             // Console.Write("8. Dodaj kontenerowiec");
        //             // Console.Write("9. Zastap kontener na statku o danym numerze innym kontenerem");
        //             // Console.Write("10. Przenies kontener na inny statek");
        //             
        //         }
        //         string innTmp = Console.ReadLine();
        //         int inn = int.Parse(innTmp);
        //         if (inn == 1)
        //         {
        //             int speed = int.Parse(Console.ReadLine());
        //             Console.WriteLine("podaj maksymalna ilosc kontenerow");
        //             int maxNum = int.Parse(Console.ReadLine());
        //             Console.WriteLine("podaj maksymalna ladownosc");
        //             int maxWeight = int.Parse(Console.ReadLine());
        //             cargoShips.Add(new CargoShip(speed, maxNum, maxWeight));
        //             
        //         }else if (inn == 2 && containers.Count() != 0)
        //         {
        //             Console.WriteLine("Podaj numer koneterowca z listy do usuniecia:");
        //             int inn2 = int.Parse(Console.ReadLine());
        //             cargoShips.RemoveAt(inn2);
        //         }else if (inn == 3 && containers.Count() != 0)
        //         {
        //             Console.WriteLine("Podaj typ kontenera: ");
        //             Console.WriteLine("1. Plyn");
        //             Console.WriteLine("2. Gaz");
        //             Console.WriteLine("3. Chlodniczy");
        //             string inn2 = Console.ReadLine();
        //             if (inn2 == "1")
        //             {
        //                 Console.WriteLine("Podaj trzy pierwsze litery numeru: ");
        //                 string numsFirstLetters = Console.ReadLine();
        //                 Console.WriteLine("Podaj typ numeru: ");
        //                 string numsType = Console.ReadLine();
        //                 Console.WriteLine("Podaj ciezar ladunku: ");
        //                 int cargoWeight = int.Parse(Console.ReadLine());
        //                 Console.WriteLine("Podaj wysokosc ladunku: ");
        //                 int cargoHeight = int.Parse(Console.ReadLine());
        //                 Console.WriteLine("Podaj ciezar konteneru: ");
        //                 int containerWeight = int.Parse(Console.ReadLine());
        //                 Console.WriteLine("Podaj glebokosc konteneru: ");
        //                 int containerDepth = int.Parse(Console.ReadLine());
        //                 Console.WriteLine("Podaj maksymalny ciazar konteneru: ");
        //                 int maxWeight = int.Parse(Console.ReadLine());
        //                 Console.WriteLine("Podaj czy ladunek jest niebezpieczny: ");
        //                 bool isDangerous = bool.Parse(Console.ReadLine());
        //                 containers.Add(new LiquidContainer(numsFirstLetters, numsType,
        //                     cargoWeight, cargoHeight, containerWeight, containerDepth, maxWeight, isDangerous));
        //             }
        //             else if (inn2 == "2")
        //             {
        //                 Console.WriteLine("Podaj trzy pierwsze litery numeru: ");
        //                 string numsFirstLetters = Console.ReadLine();
        //                 Console.WriteLine("Podaj typ numeru: ");
        //                 string numsType = Console.ReadLine();
        //                 Console.WriteLine("Podaj ciezar ladunku: ");
        //                 int cargoWeight = int.Parse(Console.ReadLine());
        //                 Console.WriteLine("Podaj wysokosc ladunku: ");
        //                 int cargoHeight = int.Parse(Console.ReadLine());
        //                 Console.WriteLine("Podaj ciezar konteneru: ");
        //                 int containerWeight = int.Parse(Console.ReadLine());
        //                 Console.WriteLine("Podaj glebokosc konteneru: ");
        //                 int containerDepth = int.Parse(Console.ReadLine());
        //                 Console.WriteLine("Podaj maksymalny ciazar konteneru: ");
        //                 int maxWeight = int.Parse(Console.ReadLine());
        //                 Console.WriteLine("Podaj cisnienie konteneru: ");
        //                 int preasure = int.Parse(Console.ReadLine());
        //                 containers.Add(new GasContainer(numsFirstLetters, numsType, cargoWeight
        //                 , cargoHeight, containerWeight, containerDepth, maxWeight, preasure));
        //             }
        //             else
        //             {
        //                 Console.WriteLine("Podaj trzy pierwsze litery numeru: ");
        //                 string numsFirstLetters = Console.ReadLine();
        //                 Console.WriteLine("Podaj typ numeru: ");
        //                 string numsType = Console.ReadLine();
        //                 Console.WriteLine("Podaj ciezar ladunku: ");
        //                 int cargoWeight = int.Parse(Console.ReadLine());
        //                 Console.WriteLine("Podaj wysokosc ladunku: ");
        //                 int cargoHeight = int.Parse(Console.ReadLine());
        //                 Console.WriteLine("Podaj ciezar konteneru: ");
        //                 int containerWeight = int.Parse(Console.ReadLine());
        //                 Console.WriteLine("Podaj glebokosc konteneru: ");
        //                 int containerDepth = int.Parse(Console.ReadLine());
        //                 Console.WriteLine("Podaj maksymalny ciazar konteneru: ");
        //                 int maxWeight = int.Parse(Console.ReadLine());
        //                 Console.WriteLine("Podaj temperature konteneru: ");
        //                 double temp = double.Parse(Console.ReadLine());
        //                 Console.WriteLine("Podaj nazwe produktu: ");
        //                 string nazwa = Console.ReadLine();
        //                 Console.WriteLine("Podaj temperature ladunku: ");
        //                 int temp2 = int.Parse(Console.ReadLine());
        //                 containers.Add(new CoolingContainer(numsFirstLetters, numsType, cargoWeight, cargoHeight
        //                 , containerWeight, containerDepth, maxWeight,temp, new Product(nazwa, temp2)));
        //             }
        //         }else if (inn == 4 && containers.Count() != 0)
        //         {
        //             
        //         }
        // }

    }
}

