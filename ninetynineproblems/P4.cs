using System;
using System.Collections.Generic;

namespace ninetynineproblems
{
	public class P4
	{
		public int Length(  List<int> l)
		{
			return l.Count;
		}
		
		public P4 ()
		{

			var l = new List<int>(){1,2,3,5,8};
			
			var result = Length(  l );
			Console.WriteLine("length is " + result.ToString() );
		}
	
	}
}

