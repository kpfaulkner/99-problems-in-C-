using System;
using System.Collections.Generic;

namespace ninetynineproblems
{
	public class P2
	{
		public int Penultimate( List<int> l)
		{
			return l[ l.Count - 2 ];		
		}
		
		public P2 ()
		{

			var l = new List<int>(){1,2,3,5,8};
			
			var result = Penultimate( l );
			Console.WriteLine("penultimate is " + result.ToString() );
		}
	}
}

