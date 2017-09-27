﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending
{

    public class Wrapper<T>
    {
        public T[] wrapped { get; set; }
        public int Count => wrapped != null ? wrapped.Length : 0;
        public T this[int index] => wrapped[index];
    }
}