﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseExporter.Attributes
{
    public class TableNameAttribute : Attribute
    {
        public string Name { get; }
        public TableNameAttribute(string name)
        {
            Name = name;
        }
    }
}
