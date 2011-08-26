using System;
using System.Collections.Generic;

namespace ninetynineproblems
{
	public class P1
	{
		
		public int Last( List<int> l)
		{
			return l[ l.Count - 1 ];	
		}
		
		public P1 ()
		{
			
			var l = new List<int>(){1,2,3,5,8};
			
			var result = Last(l);
			Console.WriteLine("last is " + result.ToString() );
			
		}
		
		
	
		
		
	}
}

