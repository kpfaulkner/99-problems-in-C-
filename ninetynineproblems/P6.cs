using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;

namespace ninetynineproblems
{
	public class P6
	{
		public bool IsPalindrome(  List<int> l)
		{
			
			var ll = l.GetRange( 0, l.Count);
			ll.Reverse();
			return Enumerable.SequenceEqual( l, ll);
			
			
		}
		
		public P6 ()
		{

			var l = new List<int>(){1,2,3,5,8};
			
			var result = IsPalindrome(  l );
			Console.WriteLine("is palindrome is " + result.ToString() );
		}
	
	}
}

