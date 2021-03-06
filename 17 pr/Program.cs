using System;
using System.IO;
using System.Collections;

namespace Any_name
{
    class Program
    {
        static void Main()
        {
            int n;
            int[] m;
            using (StreamReader fileIn = new StreamReader("C:/Users/Екатерина/source/repos/Any_name/val.txt"))
            {
                n = int.Parse(fileIn.ReadLine());
                string[] text = fileIn.ReadLine().Split();
                m = new int[n];
                for (int i = 0; i < n; i++)
                {
                    m[i] = int.Parse(text[i]);
                }
            }
            DoubleArray arr = new DoubleArray(n, m);
            arr.Print(); // empty

            arr.Input(); // after input
            arr.Print();

            if (arr) { Console.WriteLine("Каждая строка не отсортирована по возрастанию"); }
            else { Console.WriteLine("OK"); }

            Console.WriteLine("Sorted"); 
            arr.Sort();
            arr.Print();

            if (arr) { Console.WriteLine("Каждая строка не отсортирована по возрастанию"); }
            else { Console.WriteLine("OK"); }

            Console.WriteLine("count {0}", arr.Count);   //count of elements
            Console.WriteLine("Enter the change");
            arr.Add = double.Parse(Console.ReadLine());
            arr.Print();  // after add

            Console.WriteLine("element [0, 2] {0}", arr[0, 2]);

            Console.WriteLine("element [2, 4] {0}", arr[2, 4]);
            Console.WriteLine("Enter element [2, 4]");
            arr[2, 4] = double.Parse(Console.ReadLine()); 
            Console.WriteLine("new element [2, 4] {0}\n", arr[2, 4]);

            arr.Print(); // after the changing of elements

            Console.WriteLine("arr++\n");
            arr++;
            arr.Print();

            Console.WriteLine("arr--\n");
            arr--;
            arr.Print(); 
            double[][] mas1 = (double[][])arr;
            double[][] mas2 = arr;
            DoubleArray b1 = mas1;
            DoubleArray b2 = (DoubleArray)mas2;

            
            mas1[0][1] = 1000;
            mas2[0][1] = 2000;
            b1[0, 1] = 100;
            b2[0, 1] = 200;

            Console.WriteLine("Maccив mas1: ");
            Print(mas1);
            arr.Print();

            Console.WriteLine("Maccив mas2: ");
            Print(mas2);
            arr.Print();

            Console.WriteLine("Maccив b1: ");
            b1.Print();
            arr.Print();

            Console.WriteLine("Maccив b2: ");
            b2.Print();
            arr.Print();




        }
    }
}
