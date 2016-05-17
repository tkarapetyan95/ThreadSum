using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSum
{
    class Range
    {
        public Range(int start, int end)
        {
            this.Start= start;
            this.End = end;
            Result = 0;
        }
        public int Start { get; set; }
        public int End { get; set; }
        public int Result { get; set; }
    }
}
