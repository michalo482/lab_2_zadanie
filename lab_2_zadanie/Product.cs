﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    public class Product : IThing
    {
        private string? name;
        public string? Name { get => name; set => name = value; }

        public Product(string? name)
        {
            this.name = name;
        }

        public virtual void Print()
        {
            Console.Write($"{Name} ");
        }
    }
}
