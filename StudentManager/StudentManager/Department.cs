﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class Department
    {
        private string name;


        private List<Class> classes = new List<Class>();

        public string Name { get => name; set => name = value; }
        internal List<Class> Classes { get => classes; set => classes = value; }
    }
}
