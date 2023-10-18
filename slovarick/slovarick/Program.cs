using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slovarick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var city = new Dictionary<string, string>()
            {
                {"455000", "Магнитогорск"},
                {"455001", "Магадан"},
                {"455002", "Париж"},
                {"152830", "Мышкин"}
            };

            Console.WriteLine("Введите ключ");
            var a = Console.ReadLine();


            if (city.TryGetValue(a, out string value))
            {
                Console.WriteLine($"Индекс: {a} Город: {value}");
                city.Remove(a);
                Console.WriteLine("Удалено");


            }
            else
            {
                Console.WriteLine($"Индекс: {a} отсутствует в словаре");
            }

            foreach (var gorod in city)
            {
                Console.WriteLine($"Индекс: {gorod.Key} Город: {gorod.Value}");
            }

            city.Clear();
            Console.WriteLine("Удалены все элементы");

            foreach (var gorod in city)
            {
                Console.WriteLine($"Индекс: {gorod.Key} Город: {gorod.Value}");
               
            }
        }
    }
}
