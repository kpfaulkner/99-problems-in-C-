using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;

namespace ninetynineproblems
{
	public class P7
	{
		public void Flatten(  object mysteryObject, List<int> existingList)
		{
			
			if ( mysteryObject is List<object>)
			{
				var mysteryList = mysteryObject as List<object>;
				foreach( var l in mysteryList)
				{
					Flatten( l, existingList );	
				}
			}
			else
			{
				// just add entry to the list.
				existingList.Add( (int)mysteryObject );
				
			}
			
		}
		
		public P7 ()
		{

			var l = new List<int>(){1,2,3,5,8};
			var newList = new List<int>();
			Flatten(  l, newList  );
			Console.WriteLine("flattened  " + newList.ToString() );
		}
	
	}
}

