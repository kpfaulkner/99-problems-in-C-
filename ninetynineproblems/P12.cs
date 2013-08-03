using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;

namespace ninetynineproblems
{
    public class P12
    {

        public List<char> Expander(List<Tuple<int, char>> l)
        {
            var res = new List<char>();

            foreach (var i in l)
            {
                List<char> ll =  (Enumerable.Range(0, i.Item1).Select( n => i.Item2)).ToList<char>();
                res.AddRange(ll);
            }

            return res;
        }

        public P12()
        {
            var l = new List<Tuple<int,char>>() { new Tuple<int,char>( 4,'a'), 
                new Tuple<int,char>( 1,'b'), 
                new Tuple<int,char>( 2,'c'), 
                new Tuple<int,char>( 2,'a'), 
                new Tuple<int,char>( 1,'d'), 
                new Tuple<int,char>( 4,'e') };

            var res = Expander(l);
            foreach (var i in res)
            {
                Console.WriteLine(i.ToString());
            }


        }
    }
}

