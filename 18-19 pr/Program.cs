using System;
using System.IO;
using System.Collections;
using System.Text;
using System.Collections.Generic;

namespace Any_name
{
    class Program
    {

        static public List<Product> Input()
        {
            using (StreamReader fileIn = new StreamReader("C:/Users/Екатерина/source/repos/Any_name/input.txt"))
            {
                List<Product> arr = new List<Product>();
                while (!fileIn.EndOfStream)
                {
                    string[] text = fileIn.ReadLine().Split(' ');
                    if (text.Length == 4)
                    {
                        arr.Add(new SportsEquipment(text[0], int.Parse(text[1]), text[2], int.Parse(text[3])));
                    }
                    if (text.Length == 5)
                    {
                        try
                        {
                            arr.Add(new Book(text[0], text[1], int.Parse(text[2]), text[3], int.Parse(text[4])));
                        }
                        catch (FormatException error)
                        {
                            arr.Add(new Toy(text[0], int.Parse(text[1]), text[2], text[3], int.Parse(text[4])));
                        }
                    }

                }
                return arr;
            }
        }
        static void Print(List<Product> array)
        {
            using (StreamWriter fileOut = new StreamWriter("C:/Users/Екатерина/source/repos/Any_name/output.txt", false))
            {
                foreach (Product item in array)
                {
                    fileOut.WriteLine(item.Str());
                }
            }

        }

        static void Show(List<Product> array)
        {
           foreach (Product item in array)
           {
                switch (item.Type())
                {
                    case "toy":
                        Console.WriteLine("\tIt is a toy"); break;
                    case "book":
                        Console.WriteLine("\tIt is a book"); break;
                    case "sports_equipment":
                        Console.WriteLine("\tIt is a toy"); break;
                }
                item.Show();
                
           }
        }

        static void Find(List<Product> array, string type)
        {
            int k = 0;
            foreach (Product item in array)
            {
                if (item.Is_Required(type))
                {
                    item.Show();
                    k++;
                }
            }
            Console.WriteLine("The count of products ({0}) is {1}", type, k);
        }

        static void Main()
        {
            List<Product> array = Input();
            Show(array);
            Print(array);
            string type;
            Console.WriteLine("Enter the type");
            type = Console.ReadLine();
            Find(array, type);
            array.Sort();
            Print(array);
        }
    }
}
