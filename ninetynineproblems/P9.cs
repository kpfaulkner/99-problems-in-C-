using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;

namespace ninetynineproblems
{
    public class P9
    {
        public IEnumerable<List<char>> Compress(List<char> l)
        {

            char previousChar = l[0];

            var newList = new List<char>( previousChar);

            foreach(var i in l.Skip(1))
            {
                if (i == previousChar)
                {
                    newList.Add(i);
                }
                else
                {
                    yield return newList;
                    newList = new List<char>();
                    newList.Add(i);
                }
                previousChar = i;

            }

            yield return newList;

        }

        public P9()
        {

            var l = new List<char>() { 'a', 'a', 'a', 'a', 'b', 'c', 'c', 'a', 'a', 'd', 'e', 'e', 'e', 'e' };

            var res = Compress(l);

            /*
            foreach (var i in Compress(l))
            {
                Console.WriteLine("new list");
                foreach (var j in i)
                {
                    Console.WriteLine(j + " ");
                }
            }*/

        }
    }
}

