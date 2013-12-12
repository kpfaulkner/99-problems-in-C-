using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Linq;

namespace ninetynineproblems
{

    public class P14
    {
        public List<char> Duplicate(List<char> l)
        {
            var res = l.SelectMany(n => new List<char> {n, n}).ToList();

            return res;
        }

      

        public P14()
        {
            var l = new List<char>() {'a','b','c','c','d'};

            var res = Duplicate(l);
            foreach (var i in res)
            {
                Console.WriteLine("{0}", i);
            }


        }
    }
}

