using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Linq;

namespace ninetynineproblems
{
    // naive non LINQ version.
    // but have seen Jon Skeet answer in similar fashion. So happy with this option
    // http://stackoverflow.com/questions/11330064/linq-to-count-continues-repeated-itemsint-in-an-int-array
    public class P13
    {
        public List<Tuple<int, char>> EncodeDirect(List<char> l)
        {
            var res = new List<Tuple<int, char>>();

            var count = 0;
            char ch = ' ';

            Tuple<int, char> currentEntry = null;

            foreach (var i in l)
            {
                if (i != ch)
                {
                    if (ch == ' ')
                    {
                        ch = i;
                        count = 1;
                    }
                    else
                    {
                        
                        res.Add(new Tuple<int, char>(count, ch));
                        ch = i;
                        count = 1;
                    }
                }
                else
                {
                    count++;
                }

            }
            res.Add( new Tuple<int, char>(count,ch));
            return res;
        }

      

        public P13()
        {
            var l = new List<char>() {'a', 'a', 'a', 'a', 'b', 'c', 'c', 'a', 'a', 'd', 'e', 'e', 'e', 'e'};

            var res = EncodeDirect(l);
            foreach (var i in res)
            {
                Console.WriteLine("{0}:{1}", i.Item1, i.Item2);
            }


        }
    }
}

