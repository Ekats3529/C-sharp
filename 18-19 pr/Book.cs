using System;
using System.Collections.Generic;
using System.Text;

namespace Any_name
{
    public class Book : Product
    {
        protected string author;
        protected string publisher;
        protected string type = "book";

        public Book(string name, string author,  int cost, string publisher, int age) : base(name, cost, age)
        {
            this.author = author;
            this.publisher = publisher;
        }

        public override void Show()
        {
            Console.WriteLine("{0} {1} {2} {3} {4}\n", name, author, cost, publisher, age);
        }
        public override string Str()
        {
            return String.Format("{0} {1} {2} {3} {4}", name, author, cost, publisher, age);
        }

        public override string Type() { return type; }

        public override bool Is_Required(string type) { return (type == this.type ? true : false); }
    }
}
