using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Linq;

namespace ninetynineproblems
{

    public class P16
    {
        public List<char> Drop(int i, List<char> l)
        {
            var res = Enumerable.Range(0, l.Count).Where(n => (n+1)%i != 0).Select(a => l[a]).ToList();

            return res;
        }

      

        public P16()
        {
            var l = new List<char>() {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k'};

            var res = Drop(3, l);
            foreach (var i in res)
            {
                Console.WriteLine("{0}", i);
            }


        }
    }
}

