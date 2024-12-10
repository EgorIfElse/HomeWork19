using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Compukter compukter = new Compukter();
        List<Compukter> comp = new List<Compukter>
        {
            new Compukter() { Code =1, Name = "MSI", TypeProcessor = "Intel", Frequency = 60, Ram = 2, VolumeMemory = 100, VideoCard = 1, Price = 50000, Quantity = 9 },
            new Compukter() { Code =2, Name = "Honor", TypeProcessor = "Snapdragon", Frequency = 120, Ram = 4, VolumeMemory = 1000, VideoCard = 1, Price = 70000, Quantity = 17 },
            new Compukter() { Code =3, Name = "MacBook", TypeProcessor = "Bionic M1", Frequency = 144, Ram = 8, VolumeMemory = 200, VideoCard = 1, Price = 500000, Quantity = 1 },
            new Compukter() { Code =4, Name = "Samsung", TypeProcessor = "Intel", Frequency = 120, Ram = 6, VolumeMemory = 100, VideoCard = 1, Price = 150000, Quantity = 3 },
            new Compukter() { Code =5, Name = "Xiaomi", TypeProcessor = "Snapdragon", Frequency = 60, Ram = 4, VolumeMemory = 300, VideoCard = 1, Price = 10000, Quantity = 13 },
            new Compukter() { Code =6, Name = "Dell", TypeProcessor = "Snapdragon", Frequency = 30, Ram = 2, VolumeMemory = 300, VideoCard = 1, Price = 35000, Quantity = 5 },
            new Compukter() { Code =7, Name = "Huafei", TypeProcessor = "Intel", Frequency = 60, Ram = 2, VolumeMemory = 500, VideoCard = 1, Price = 50000, Quantity = 1 },
            new Compukter() { Code =8, Name = "Tiger", TypeProcessor = "Bionic A15", Frequency = 30, Ram = 1, VolumeMemory = 100, VideoCard = 1, Price = 55000, Quantity = 92 },
            new Compukter() { Code =9, Name = "Grisha", TypeProcessor = "Baikal", Frequency = 15, Ram = 1, VolumeMemory = 10, VideoCard = 1, Price = 1000, Quantity = 19 }
        };

        Console.WriteLine("Введите тип процессора");
        string proc = Console.ReadLine();
        var result1 = comp.Where(x => x.TypeProcessor == proc).ToList();
        compukter.Print(result1);


        Console.WriteLine("Введите кол-во Гб ОЗУ");
        int ozu = Convert.ToInt32(Console.ReadLine());
        var result2 = comp.Where(x => x.Ram >= ozu).ToList();
        compukter.Print(result2);


        var result3 = comp.OrderBy(x => x.Price).ToList();
        compukter.Print(result3);




        IEnumerable<IGrouping<string, Compukter>> compukters = comp.GroupBy(x => x.TypeProcessor).ToList();
        foreach (var comp1 in compukters)
        {
            Console.WriteLine(comp1.Key);
            foreach (var compukter1 in comp1)
            {
                Console.WriteLine($"{compukter1.Code},{compukter1.Name}, {compukter1.Frequency}, {compukter1.Ram}, {compukter1.VolumeMemory}, {compukter1.VideoCard}, {compukter1.Price}, {compukter1.Quantity}");
            }
        }

        var result4 = comp.OrderBy(x => x.Price).FirstOrDefault();
        Console.WriteLine($"{result4.Code},{result4.Name},{result4.TypeProcessor}, {result4.Frequency}, {result4.Ram}, {result4.VolumeMemory}, {result4.VideoCard}, {result4.Price}, {result4.Quantity}");

        var result5 = comp.OrderBy(x => x.Price).LastOrDefault();
        Console.WriteLine($"{result5.Code},{result5.Name},{result5.TypeProcessor}, {result5.Frequency}, {result5.Ram}, {result5.VolumeMemory}, {result5.VideoCard}, {result5.Price}, {result5.Quantity}");


        var result6 = comp.Any(x => x.Quantity >= 30);
        
        if (result6)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }


    }
}
class Compukter
{
    public int Code { get; set; }
    public string Name { get; set; }
    public string TypeProcessor { get; set; }
    public int Frequency { get; set; }
    public int Ram { get; set; }
    public int VolumeMemory { get; set; }
    public int VideoCard { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }

    public void Print(List<Compukter> c)
    {
        foreach (Compukter compukter in c)
        {
            Console.WriteLine($"{compukter.Code},{compukter.Name},{compukter.TypeProcessor}, {compukter.Frequency}, {compukter.Ram}, {compukter.VolumeMemory}, {compukter.VideoCard}, {compukter.Price}, {compukter.Quantity}");
        }

    }
}



