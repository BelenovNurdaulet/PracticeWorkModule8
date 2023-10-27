using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pw2module8
{

    class Program
    {
        static void Main()
        {
            double discount = 1.0;
            DateTime currentTime = DateTime.Now;

            // Проверяем, если текущее время от 8:00 до 12:00, предоставляем скидку 5%
            if (currentTime.Hour >= 8 && currentTime.Hour < 12)
            {
                discount = 0.30;
            }

            // Перечисляем продукты и их цены в тенге
            string[] products = { "Яблоки", "Бананы", "Молоко" }; 
            double[] prices = { 250, 150, 400 }; // цены

            double total = 0;

            // Рассчитываем общую стоимость продуктов с учетом скидки
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Введите количество {products[i]}:");
                int quantity = int.Parse(Console.ReadLine());
                total += prices[i] * quantity * discount;
            }

            Console.WriteLine($"Общая стоимость покупки: {total} тенге.");
        }
    }
}

