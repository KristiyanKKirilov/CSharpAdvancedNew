﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            //return !string.IsNullOrEmpty(this.ToString());
            return Count == 0;
        }
        public Stack<string> AddRange(IEnumerable<string> strings)
        {
            foreach (var item in strings)
            {
                Push(item);
            }
            return this;
        }

    }
}
