﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simplelistitem
{
    public class SimpleListItem<T>
    {
        public T data { get; set; }
        public SimpleListItem<T> next { get; set; }
        public SimpleListItem(T param)
        {
            this.data = param;
        }
    }
}
