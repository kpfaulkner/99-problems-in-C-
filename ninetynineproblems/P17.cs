using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Linq;

namespace ninetynineproblems
{

    public class P17
    {
        public Tuple<List<char>, List<char>> Split(int i, List<char> l)
        {
            var first = l.Take(i).ToList();
            var last = l.Skip(i).ToList();

            var res = new Tuple<List<char>, List<char>>(first, last);

            return res;
        }

      

        public P17()
        {
            var l = new List<char>() {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k'};

            var res = Split(3, l);
            res.Item1.ForEach( Console.Write);
            Console.WriteLine("\n");
            res.Item2.ForEach(Console.Write);

        }
    }
}

