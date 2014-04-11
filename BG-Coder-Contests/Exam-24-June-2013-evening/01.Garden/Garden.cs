using System;
class Garden
{
    static void Main()
    {
        int tomato = int.Parse(Console.ReadLine());
        int tomatoArea = int.Parse(Console.ReadLine());
        int cucumber = int.Parse(Console.ReadLine());
        int cucumberArea = int.Parse(Console.ReadLine());
        int potato = int.Parse(Console.ReadLine());
        int potatoArea = int.Parse(Console.ReadLine());
        int carrot = int.Parse(Console.ReadLine());
        int carrotArea = int.Parse(Console.ReadLine());
        int cabbage = int.Parse(Console.ReadLine());
        int cabbageArea = int.Parse(Console.ReadLine());
        int beans = int.Parse(Console.ReadLine());
        int beansArea = 0;
        float sumTomato = tomato * 0.5f;
        float sumCucumber = cucumber * 0.4f;
        float sumPotato = potato * 0.25f;
        float sumCarrot = carrot * 0.6f;
        float sumCabbage = cabbage * 0.3f;
        float sumBeans = beans * 0.4f;
        float totalCosts = sumTomato + sumCucumber + sumPotato + sumCarrot + sumCabbage + sumBeans;
        int totalArea = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;
        Console.WriteLine("Total costs: {0:F2}", totalCosts);
        if (totalArea < 250)
        {
            beansArea = 250 - totalArea;
            Console.WriteLine("Beans area: {0}", beansArea);
        }
        if (totalArea == 250)
        {
            Console.WriteLine("No area for beans");
        }
        if (totalArea > 250)
        {
            Console.WriteLine("Insufficient area");
        }
    }
}