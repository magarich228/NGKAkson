using AksonPriceList.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AksonPriceList.UI
{
    internal class PageActions
    {
        public static string StartMenu()
        {
            ConsoleKeyInfo key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.D1:
                    return "Price-list";

                case ConsoleKey.D2:
                    return "New";

                case ConsoleKey.D3:
                    return "About";

                case ConsoleKey.D4:
                    return "Exit";
            }

            return "StartMenu";
        }

        public static string About()
        {
            ConsoleKeyInfo key = Console.ReadKey();

            return key.Key == ConsoleKey.D1 ? "StartMenu" : "About";
        }

        public static string Exit()
        {
            Environment.Exit(0);
            return "";
        }

        public static string Price()
        {
            ConsoleKeyInfo key;
            var medicaments = Program._medicamentProvider.GetAll();

            key = Console.ReadKey();

            if (key.Key == ConsoleKey.D0)
                return "StartMenu";

            int num;
            if (int.TryParse(key.KeyChar.ToString(), out num))
            {
                if (num - 1 >= 0 && num - 1 < medicaments.Count)
                {
                    Controller.MedicamentNum = num - 1;
                    return "Info";
                }
            }

            return "Price-list";
        }

        public static string New()
        {
            MedicamentModel newModel = new MedicamentModel();

            Console.Write("Введите Название: ");
            newModel.Name = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Введите Страну: ");
            newModel.Country = Console.ReadLine();
            Console.WriteLine();

            decimal price;

            Console.Write("Введите Стоимость: ");
            bool flag = false;
            do
            {
                flag = !decimal.TryParse(Console.ReadLine(), out price);
                newModel.Price = price;

            } while (flag);
            Console.WriteLine();

            string category;
            newModel.Recomendations = new Dictionary<string, List<string>>();

            Console.WriteLine("При достаточном кол-ве категорий или показаний жмите enter");
            do
            {
                string pokazanie = "begin";

                Console.WriteLine("Введите название категории показаний (возраст):");
                category = Console.ReadLine();

                if (string.IsNullOrEmpty(category) || string.IsNullOrWhiteSpace(category))
                    continue;

                List<string> pokazaniya = new List<string>();
                newModel.Recomendations.Add(category, pokazaniya);

                while (!string.IsNullOrEmpty(pokazanie) || !string.IsNullOrWhiteSpace(pokazanie))
                {
                    Console.Write("Введите показание: ");
                    pokazanie = Console.ReadLine();

                    if (string.IsNullOrEmpty(pokazanie) || string.IsNullOrWhiteSpace(pokazanie))
                        continue;

                    pokazaniya.Add(pokazanie);
                }

            } while (!string.IsNullOrEmpty(category) || !string.IsNullOrWhiteSpace(category));

            newModel.Composition = new List<string>();
            Console.WriteLine("Вводите состав. По окончанию enter");
            string ingridient = "begin";

            while (!string.IsNullOrEmpty(ingridient) || !string.IsNullOrWhiteSpace(ingridient))
            {
                ingridient = Console.ReadLine();

                if (!string.IsNullOrEmpty(ingridient) || !string.IsNullOrWhiteSpace(ingridient))
                    continue;

                newModel.Composition.Add(ingridient);
            }

            Program._medicamentProvider.Add(newModel);

            Console.WriteLine("\nГотово.");

            Thread.Sleep(1500);
            return "StartMenu";
        }

        public static string Info()
        {
            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.D1)
                return "Price-list";

            return "Info";
        }
    }
}
