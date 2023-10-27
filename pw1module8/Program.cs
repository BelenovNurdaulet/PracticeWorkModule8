using System;


namespace pw1module8
{
    class Program
    {
        static void Main()
        {
            RangeOfArray rangeArray = new RangeOfArray(6, 10);

            Console.WriteLine("Введите значения для индексов от 6 до 10:");
            for (int i = 6; i <= 10; i++)
            {
                Console.Write($"Значение для индекса {i}: ");
                rangeArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Введенные значения:");
            for (int i = 6; i <= 10; i++)
            {
                Console.WriteLine($"Значение для индекса {i}: {rangeArray[i]}");
            }
        }
    }

    public class RangeOfArray
    {
        private int lowerBound;
        private int upperBound;
        private int[] array;

        public RangeOfArray(int lowerBound, int upperBound)
        {
            this.lowerBound = lowerBound;
            this.upperBound = upperBound;
            array = new int[upperBound - lowerBound + 1];
        }

        public int this[int index]
        {
            get
            {
                if (IsIndexValid(index))
                {
                    return array[index - lowerBound];
                }
                else
                {
                    throw new IndexOutOfRangeException("Индекс вне допустимого диапазона.");
                }
            }
            set
            {
                if (IsIndexValid(index))
                {
                    array[index - lowerBound] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Индекс вне допустимого диапазона.");
                }
            }
        }

        private bool IsIndexValid(int index)
        {
            return index >= lowerBound && index <= upperBound;
        }
    }
}

