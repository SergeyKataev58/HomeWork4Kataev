using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HomeWork4Kataev
{

    class Program
    {
        static void Main(string[] args)
        {
            
            MyArray myArray = new MyArray("Mass.txt");
            Console.WriteLine(myArray.ToString());
            myArray.Pari();
            Console.ReadLine();
        }
    }


    class MyArray
    {
        int[] a;
        public MyArray(string Mass)
        {
            StreamReader sr = new StreamReader("C:\\Users\\Сергей\\Desktop\\Mass.txt");
            //  Считываем количество элементов массива
            int N = int.Parse(sr.ReadLine());
            a = new int[N];
            //  Считываем массив
            for (int i = 0; i < N; i++)
            {
                a[i] = int.Parse(sr.ReadLine());
            }
            sr.Close();
        }
        public int Length
        {
            get
            {
                return a.Length;
            }
        }


        public int Pari() //Метод подсчета пар чисел, которые делятся на 3
        {
            int count = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] % 3 == 0 | a[i + 1] % 3 == 0)
                    count++;
                Console.WriteLine("Пара чисел: {0} и {1}", a[i], a[i + 1]);
            }
            Console.WriteLine("Количество пар: " + count);
            return count;
        }


        override public string ToString() //Метод вывода массива на консоль
        {
            string stringarray = "";
            foreach (int x in a)
                stringarray = stringarray + x + " ";
            return stringarray;
        }
    }
}
