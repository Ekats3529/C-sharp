using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Any_name
{
    class DoubleArray
    {
        public double[][] array;
        public DoubleArray(int n, int[] m)
        {
            this.array = new double[n][];
            for (int i = 0; i < n; i++)
            {
                this.array[i] = new double[m[i]];
            }
        }

        public DoubleArray(double [][] array)
        {
            this.array = array;
        }

        public void Print()
        {
            for (int i = 0; i < (this.array).Length; i++)
            {
                for (int j = 0; j < (this.array[i]).Length; j++)
                {
                    Console.Write("{0} ", this.array[i][j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void Input()
        {
            using (StreamReader fileIn = new StreamReader("C:/Users/Екатерина/source/repos/Any_name/input.txt"))
            {
                for (int i = 0; i < (this.array).Length; i++)
                {
                    string[] text = fileIn.ReadLine().Split();
                    for (int j = 0; j < (this.array[i]).Length; j++)
                    {
                        this.array[i][j] = double.Parse(text[j]);
                    }
                }
            }
        }

        public void Sort()
        {
            for (int i = 0; i < (this.array).Length; i++)
            {
                Array.Sort(this.array[i]);
                Array.Reverse(this.array[i]);
            }
        }

        public int Length
        {
            get
            {
                return this.array.Length;
            }
        }
        public int Count
        {
            get
            {
                int k = 0;
                for (int i = 0; i < this.array.Length; i++)
                {
                    k += (this.array[i]).Length;
                }
                return k;
            }
        }

        public double Add
        {
            set
            {
                for (int i = 0; i < (this.array).Length; i++)
                {
                    for (int j = 0; j < (this.array[i]).Length; j++)
                    {
                        this.array[i][j] += value;
                    }
                }
            }
        }

        public double this[int i, int j]
        {
            get
            {
                return this.array[i][j];
            }
            set
            {
                this.array[i][j] = value;
            }
        }

        public int this[int i] // возвращает длину строки i
        {
            get
            {
                return (this.array[i]).Length;
            }
        }

        

       
        public static DoubleArray operator ++(DoubleArray a)
        {
            DoubleArray temp = new DoubleArray(a);
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i]; j++)
                {
                    temp[i, j] = a[i, j] + 1;
                }
            }
            return temp;
        }

        public static DoubleArray operator --(DoubleArray a)
        {
            DoubleArray temp = new DoubleArray(a);
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i]; j++)
                {
                    temp[i, j] = a[i, j] - 1;
                }
            }
            return temp;
        }

        public static bool operator true(DoubleArray a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i] - 1; j++)
                {
                    if (a[i, j + 1] < a[i, j]) { return true; }
                }
            }
            return false;
        }

        public static bool operator false(DoubleArray a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i] - 1; j++)
                {
                    if (a[i, j] <= a[i, j + 1]) { return false; }
                }
            }
            return true;
        }


        public static implicit operator DoubleArray(double[][] a)
        {
            return new DoubleArray(a);
        }

        public static implicit operator double[][](DoubleArray a)
        {
            double[][] temp = new double[a.Length][];
            for (int i = 0; i < a.Length; i++)
            {
                temp[i] = new double[a[i]];
            }
            return temp;
        }

    }
}

/*1.1 0.5 9.1
0.0 - 1.8 - 12.6 - 0.1 0.1
1.0 2.5 5.7 - 3.7 - 6.3 - 0.15 1.17
3.14
*/