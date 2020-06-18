using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PM03console
{

    class Town : Object
    {
        private string name;
        private int kolvo;
        private int ploshad;
        private int count;

        public string Name
        {
            get => name; set => name = value;
        }
        public int Kolvo
        {
            get => kolvo; set => kolvo = value;
        }
        public int Ploshad
        {
            get => ploshad; set => ploshad = value;
        }
        public Int32 Count
        {
            get => count; set => count = value;
        }
        public Town(string name, int kolvo, int ploshad, int count)
        {
            this.Name = name;
            this.Kolvo = kolvo;
            this.Ploshad = ploshad;
            this.count = count;
        }
        public Town()
        {
            this.Name = "";
            this.Kolvo = 0;
            this.Ploshad = 0;
        }
        public static Town[] Sort(Town[] town)
        {
            {

                for (int i = 0; i < town.Length; i++)
                {
                    for (int j = i + 1; j < town.Length; j++)
                    {
                      
                            if (town[i].ploshad > town[j].ploshad)
                            {
                                var temp = town[i].ploshad;
                            town[i].ploshad = town[j].ploshad;
                            town[j].ploshad = temp;
                            }
                    }
                }

                return town;
            }
        }

        public static bool SaveAs(string path, Town[] gorod)
        {
            if (File.Exists(path.ToString()))
            {

                Console.WriteLine("Файл уже существует,перезаписать файл?(Y/N)");
                string answer = Console.ReadLine();
                if (answer == "y" || answer == "Y" || answer == "у" || answer == "У" || answer == "д" || answer == "Д")
                {
                    File.Delete(path);
                    TextWriter opnFile = new StreamWriter(path);
                    foreach (var tow in gorod)
                    {
                        opnFile.WriteLine(gorod.ToString());
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                using (TextWriter opnFile = new StreamWriter(path.ToString()))
                {
                    foreach (var tow in gorod)
                    {
                        opnFile.WriteLine(tow.ToString());
                    }
                    opnFile.Close();
                }
                return true;
            }
        }
        public override string ToString()
        {
            return "Название: " + Name +  "Площадь:" + Ploshad + "\nКоличество жителей:" + Kolvo+ "\n";
        }

    }
}

