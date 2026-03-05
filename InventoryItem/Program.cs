using System;
using System.ComponentModel.DataAnnotations.Schema;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("=== 인벤토리 목록 ===");
InventoryItem[] inventoryItem = new InventoryItem[5];
inventoryItem[0] = new InventoryItem("검", 3.5, 1500);
inventoryItem[1] = new InventoryItem("방패", 5, 1200);
inventoryItem[2] = new InventoryItem("포션", 0.3, 50);
inventoryItem[3] = new InventoryItem("활" , 1.8, 1300);
inventoryItem[4] = new InventoryItem("투구", 2, 800);

foreach (InventoryItem item in inventoryItem)
{
    Console.WriteLine($"{item.Name} - 무게: {item.Weight}Kg, 가격: {item.Price}");
}

double fullweight = 0;
int fullprice = 0;
double avgprice = 0;
string max = null;
string min = null;

for (int i = 0; i < 5; i++)
{
    fullweight += inventoryItem[i].Weight;
    fullprice += inventoryItem[i].Price;
    if (i < 4)
    {
        if (inventoryItem[i].Price < inventoryItem[i + 1].Price)
        {
            max = inventoryItem[i+1].Name;
        }
        else
        {
            max = inventoryItem[i].Name;
        }

        if (inventoryItem[i].Weight < inventoryItem[i + 1].Weight)
        {
            min = inventoryItem[i].Name;
        }
        else
        {
            min = inventoryItem[i+1].Name;
        }
    }
}
avgprice = fullprice / 5;
Console.WriteLine("=== 인벤토리 통계 ===");
Console.WriteLine($"전체 무게: {fullweight:F2}kg");
Console.WriteLine($"전체 가격: {fullprice}골드");
Console.WriteLine($"평균 가격: {avgprice}골드");
Console.WriteLine($"가장 비싼 아이템: {max}");
Console.WriteLine($"가장 가벼운 아이템:{min}");



struct InventoryItem
{
    public string Name;
    public double Weight;
    public int Price;

    public InventoryItem(string name, double weight, int price)
    {
        Name = name;
        Weight = weight;
        Price = price;
    }
}