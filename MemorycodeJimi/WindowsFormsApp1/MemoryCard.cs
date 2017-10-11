using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class MemoryCard
    {
        bool flipped = false;
        int pair;

        public MemoryCard(int pair)
        {
            this.pair = pair;
        }

        public int Pair
        {
            get { return pair; }
        }
    }
}
