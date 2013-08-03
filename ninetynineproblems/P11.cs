using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;

namespace ninetynineproblems
{
    public class P11
    {

        // can I LINQ my way out of the foreach?
        public List<object> RLE(List<char> l)
        {

            var p9Instance = new P9();
            var groupedList = p9Instance.Compress(l);
            var rleList = (from ll in groupedList select new Tuple<int, char>( ll.Count, ll[0])).ToList();

            var rleList2 = new List<object>();
            foreach (var entry in rleList)
            {
                if (entry.Item1 == 1)
                {
                    rleList2.Add(entry.Item2);
                }
                else
                {
                    rleList2.Add(entry);
                }

            }

            return rleList2;
        }

        public P11()
        {
            var l = new List<char>() { 'a', 'a', 'a', 'a', 'b', 'c', 'c', 'a', 'a', 'd', 'e', 'e', 'e', 'e' };

            var rleList = RLE(l);
            
            foreach (var i in rleList )
            {
                Console.WriteLine(i.ToString());
            }

        }
    }
}

