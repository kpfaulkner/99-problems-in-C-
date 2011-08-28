using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;

namespace ninetynineproblems
{
    public class P9
    {
        public IEnumerable<char> Compress(List<char> l)
        {

            char previousChar = ' ';

            var newList = new List<char>();

            foreach (var i in l)
            {
                if (i != previousChar)
                {
                    newList.Add(i);
                }
                else
                {
                    yield return newList;
                }
                previousChar = i;

            }

        }

        public P9()
        {

            var l = new List<char>() { 'a', 'a', 'a', 'a', 'b', 'c', 'c', 'a', 'a', 'd', 'e', 'e', 'e', 'e' };

            foreach (var i in Compress(l))
            {
                Console.WriteLine(i);


            }


        }

    }
}

