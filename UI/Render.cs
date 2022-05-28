using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AksonPriceList.UI
{
    internal static class Render
    {
        public static void StartMenu()
        {
            Clear();

            Console.WriteLine("Главно меню:");
            Console.WriteLine("1. Прайс-лист");
            Console.WriteLine("2. Добавление товара");
            Console.WriteLine("3. О программе");
            Console.WriteLine("4. Выход");
        }

        public static void About()
        {
            Clear();

            Console.WriteLine("Над программой работали студенты группы 21П Черепанова Елизавета и Кирилл Сергеевич.");
            Console.WriteLine("1. Назад");
        }

        public static void Exit() => Console.WriteLine("Completion...");

        public static void Price()
        {
            Clear();
            Console.WriteLine("Прайс-лист аптеки \"Эксон\"");

            var allMedicament = Program._medicamentProvider.GetAll();

            Console.WriteLine("Название\t\t\tЦена\t\t\tСтрана");
            for (int index = 1; index < allMedicament.Count + 1; index++)
            {
                Console.WriteLine($"{index}. {(allMedicament[index - 1].Name.Length < 12 ? allMedicament[index - 1].Name : (allMedicament[index - 1].Name.Substring(0, 10) + ".."))}\t\t\t{allMedicament[index - 1].Price}\t\t\t{allMedicament[index - 1].Country}");
            }
            Console.WriteLine();

            Console.WriteLine("0. Назад");
        }

        public static void New()
        {
            Console.Clear();

            Console.WriteLine("Добавление товара.");
        }

        public static void Info()
        {
            Clear();

            var medicaments = Program._medicamentProvider.GetAll();
            int index = Controller.MedicamentNum;

            Console.WriteLine($"Препарат: {medicaments[index].Name}\n\nСтрана: {medicaments[index].Country}\n\nЦена: {medicaments[index].Price}\n");

            Console.WriteLine("Состав:");
            foreach (var item in medicaments[index].Composition)
                Console.WriteLine($"   -{item}");

            Console.WriteLine("\nРекомендации:");
            foreach (var key in medicaments[index].Recomendations.Keys)
            {
                Console.WriteLine(key);

                foreach (var recomendation in medicaments[index].Recomendations[key])
                    Console.WriteLine($"   {recomendation}");
            }

            Console.WriteLine();
            Console.WriteLine("1. Назад");
        }

        public static void Clear() => Console.Clear();
    }
}
