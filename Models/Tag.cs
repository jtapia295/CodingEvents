﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coding_Events.Models
{
    public class Tag
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Tag(string name)
        {
            Name = name;
        }
        public Tag()
        {

        }
    }
}