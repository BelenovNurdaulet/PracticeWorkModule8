using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pw3module8
{
    class Program
    {
        static void Main()
        {
            // Предположим, что данные о продажах за последние 5 месяцев хранятся в массиве
            double[] salesData = { 100, 120, 130, 110, 115 };

            // Вычисляем среднее значение месяцев и продаж
            int n = salesData.Length;
            double sumX = 0;
            double sumY = 0;
            for (int i = 0; i < n; i++)
            {
                sumX += i + 1; // месяцы от 1 до n
                sumY += salesData[i];
            }
            double meanX = sumX / n;
            double meanY = sumY / n;

            // Вычисляем параметры линейной регрессии
            double a = 0;
            double b = 0;
            double numerator = 0;
            double denominator = 0;
            for (int i = 0; i < n; i++)
            {
                numerator += (i + 1 - meanX) * (salesData[i] - meanY);
                denominator += Math.Pow(i + 1 - meanX, 2);
            }
            a = numerator / denominator;
            b = meanY - a * meanX;

            // Прогнозируем продажи на следующие три месяца 
            for (int i = 0; i < 3; i++)
            {
                int month = n + i + 1;
                double salesForecast = a * month + b;
                Console.WriteLine($"Прогноз продаж бронебойных снарядов (АР) для месяца {month}: {salesForecast} единиц .");
            }
        }
    }
}
