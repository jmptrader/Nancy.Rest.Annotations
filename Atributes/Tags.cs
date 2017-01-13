﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Nancy.Rest.Annotations.Atributes
{
    public class Tags : Attribute
    {
        public List<string> Values { get; set; }
        public Tags(params string[] tags)
        {
            Values = tags.ToList();
        }
    }
}
