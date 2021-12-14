using System.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Any_name
{
    abstract public class Product : IComparable
    {
        protected string name;
        protected int cost;
        protected int age;
        protected string type = "";

        public Product(string name, int cost, int age)
        {
            this.name = name;
            this.cost = cost;
            this.age = age;
        }
        abstract public void Show();
        abstract public string Str();
        abstract public string Type();
        abstract public bool Is_Required(string type);

        public int CompareTo(object obj)
        {
            Product b = (Product)obj; 

            if (this.age == b.age)
            {
                return 0;
            }
            else
            {
                if (this.age > b.age)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}

