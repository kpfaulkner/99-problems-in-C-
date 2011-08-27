using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;

namespace ninetynineproblems
{
	public class P7
	{
		public void Flatten(  IEnumerable mysteryObject, List<int> existingList)
		{
			// go through each element of the mysteryobject.
            foreach (var i in mysteryObject)
            {
                // if its also an enumerable then loop... otherwise assume we've got
                // an int, so add it to the existing list.
                if (i is IEnumerable)
                {
                    Flatten( (IEnumerable) i, existingList);
                }
                else
                {
                    existingList.Add( (int) i);
                }
            }
			
		}
		
		public P7 ()
		{

            var ar = new ArrayList() { 1, 2, 3, new List<int>() { 6, 7, 8 }, 77, 88, new List<int> { 55, 33 }, new ArrayList(){1, new List<int>(){99,11} } };
  
            var newList = new List<int>();
			Flatten(  ar, newList  );

            foreach (var i in newList)
            {
                Console.WriteLine(i);
            }
		}
	
	}
}

