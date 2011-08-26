using System;
using System.Collections.Generic;

namespace ninetynineproblems
{
	public class P5
	{
		public List<int> Reverse(  List<int> l)
		{
			l.Reverse();
			
			return l;
			
		}
		
		public P5 ()
		{

			var l = new List<int>(){1,2,3,5,8};
			
			var result = Reverse(  l );
			Console.WriteLine("reverse is " + result.ToString() );
		}
	
	}
}

