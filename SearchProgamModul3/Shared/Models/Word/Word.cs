﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProgamModul3.Shared.Models.Word
{
    public class Word
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Default";

        public Word()
        {

        }
        public Word(int id)
        {
            Id = id;
        }
    }
}