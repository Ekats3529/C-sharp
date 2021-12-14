using System;
using System.Collections.Generic;
using System.Text;

namespace Any_name
{
    public class Toy: Product
    {
        protected string manufacturer;
        protected string material;
        protected string type = "toy";

        public Toy(string name, int cost, string manufacturer, string material, int age) : base(name, cost, age)
        {
            this.manufacturer = manufacturer;
            this.material = material;
        }
        public override void Show()
        {
            Console.WriteLine("{0} {1} {2} {3} {4}\n", name, cost, manufacturer, material, age);
        }

        public override string Str()
        {
            return String.Format("{0} {1} {2} {3} {4}", name, cost, manufacturer, material, age);
        }

        public override string Type() { return type;}

        public override bool Is_Required(string type) { return (type == this.type ? true : false); }
    }
}
