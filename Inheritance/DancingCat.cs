using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class DancingCat : Cat
    {
        string danceMove;

        public DancingCat(string danceMove, string catname) : base(catname, false)
        {
            this.danceMove = danceMove;
        }

        public void Dance()
        {
            Console.WriteLine(this.name + "dances. She does the" + danceMove);
        }


    }
}
