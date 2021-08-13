using System;

namespace HomeWork4Kataev
{

    class Program
    {
        static void Main(string[] args)
        {
            //Объявление массива длинной 20 элементов с минимальным и максимальным значениями 
            MyArray myArray = new MyArray(20, -10000, 10000);
            Console.WriteLine(myArray.ToString());
            myArray.Pari();
            Console.ReadLine();
        }
    }


    public class MyArray
    {
        //Приватное поле-массив класса Array 
        private int[] ai;


        //Конструктор массива с заполением случаяными числами 
        public MyArray(int n, int min, int max)
        {
            ai = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
                ai[i] = random.Next(min, max);
        }

        
        public int Pari() //Метод подсчета пар чисел, которые делятся на 3
        {
            int count = 0;
            for (int i = 0; i < ai.Length - 1; i++)
            {
                if (ai[i] % 3 == 0 | ai[i + 1] % 3 == 0)
                    count++;
                Console.WriteLine("Пара чисел: {0} и {1}", ai[i], ai[i + 1]);
            }
            Console.WriteLine("Количество пар: " + count);
            return count;
        }

        
        override public string ToString() //Метод вывода массива на консоль
        {
            string stringarray = "";
            foreach (int x in ai)
                stringarray = stringarray + x + " ";
            return stringarray;
        }
    }
}
