using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM03console
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Введите кол-во городов:");
                int count = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");
                Town[] town = new Town[count];
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Введите Название города:");
                    var name = Console.ReadLine();
                    Console.WriteLine("Введите Количество жителей:");
                    int kolvo = Convert.ToInt32( Console.ReadLine());
                    Console.WriteLine("Введите Площадь территории города");
                    int ploshad = Convert.ToInt32 (Console.ReadLine());
                    town[i] = new Town(name, kolvo, ploshad, count);
                }
                town = Town.Sort(town);
                foreach (var towns in town)
                {
                    Console.WriteLine(town.ToString());
                }
                Console.WriteLine("Введите путь для сохранения файлов");
                var path = Console.ReadLine();
                path = "Text.txt";
                Town.SaveAs(path, town);
                Console.ReadLine();
            }
            catch (Exception exe)
            {
                Console.WriteLine(exe.Message);
            }

        }
    }
}

