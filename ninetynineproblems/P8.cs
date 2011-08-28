using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;

namespace ninetynineproblems
{
    public class P8
    {
        public IEnumerable<char> Compress(List<char> l)
        {

            char previousChar = ' ';

            foreach( var i in l)
            {
                if (i != previousChar)
                {
                    yield return i;
                }
                previousChar = i;
            
            }

        }

        public P8()
        {

            var l = new List<char>() {'a', 'a', 'a', 'a', 'b', 'c', 'c', 'a', 'a', 'd', 'e', 'e', 'e', 'e' };

            foreach( var i in Compress( l ) )
            {
                Console.WriteLine( i );            
            

            }

           
        }

    }
}

