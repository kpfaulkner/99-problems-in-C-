using System;
using System.Collections.Generic;

namespace ninetynineproblems
{
	public class P3
	{
		public int Nth( int i, List<int> l)
		{
			
			return l[ i ];		
		}
		
		public P3 ()
		{

			var l = new List<int>(){1,2,3,5,8};
			
			var result = Nth( 2, l );
			Console.WriteLine("nth is " + result.ToString() );
		}
	}
}

