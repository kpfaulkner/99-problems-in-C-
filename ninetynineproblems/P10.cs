using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;

namespace ninetynineproblems
{
    public class P10
    {

        // very obvious approach
        public List<Tuple<int, char>> Attempt1(List<char> l)
        {
            
            var p9Instance = new P9();
            var groupedList = p9Instance.Compress(l);
            var rleList = new List<Tuple<int, char>>();

            foreach (var group in groupedList)
            {
                rleList.Add(new Tuple<int, char>(group.Count, group[0]));
            }

            return rleList;
        }

        // slightly neater.
        public List<Tuple<int, char>> Attempt2(List<char> l)
        {

            var p9Instance = new P9();
            var groupedList = p9Instance.Compress(l);
            var rleList = (from ll in groupedList select new Tuple<int, char>( ll.Count, ll[0])).ToList();

            return rleList;
        }

        public P10()
        {
            var l = new List<char>() { 'a', 'a', 'a', 'a', 'b', 'c', 'c', 'a', 'a', 'd', 'e', 'e', 'e', 'e' };

            var rleList1 = Attempt1(l);

            foreach (var i in rleList1)
            {
                Console.WriteLine(i.Item1 + " : " + i.Item2);
            }

            var rleList2 = Attempt2(l);

            foreach (var i in rleList2)
            {
                Console.WriteLine(i.Item1 + " : " + i.Item2);
            }

        }
    }
}

