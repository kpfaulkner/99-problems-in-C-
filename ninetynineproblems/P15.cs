using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Linq;

namespace ninetynineproblems
{

    public class P15
    {
        public List<char> DuplicateN(int count, List<char> l)
        {
            var res = l.SelectMany(n => Enumerable.Range(0,count).Select( a => n)).ToList();

            return res;
        }

      

        public P15()
        {
            var l = new List<char>() {'a','b','c','c','d'};

            var res = DuplicateN(3, l);
            foreach (var i in res)
            {
                Console.WriteLine("{0}", i);
            }


        }
    }
}

