using System;
using System.Collections.Generic;
using System.Text;

namespace Any_name
{
    public class SportsEquipment : Product
    {
        protected string manufacturer;
        protected string type = "sports_equipment";

        public SportsEquipment(string name, int cost, string manufacturer, int age) :base(name, cost, age)
        {
            this.manufacturer = manufacturer;
        }
        public override void Show()
        {
            Console.WriteLine("{0} {1} {2} {3}\n", name, cost, manufacturer, age);
        }
        public override string Str()
        {
            return String.Format("{0} {1} {2} {3}", name, cost, manufacturer, age);
        }

        public override string Type() { return type; }

        public override bool Is_Required(string type) { return (type == this.type ? true : false); }
    }
}
