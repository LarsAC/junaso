using System;
using System.IO;
using System.Collections.Specialized;
using System.Drawing;

namespace junaso
{
	public class IntSorter
	{
		public void Sort(int[] unsorted)
		{
			for(int i=0; i < unsorted.Length; i ++ )
			{
				for(int j=unsorted.Length - 1; j > i; j -- )
				{
					if( unsorted[j-1] > unsorted[j] )
					{
						Swap( unsorted, j-1, j );
					}
				}
				/*
				for(int t=0; t < unsorted.Length; t++ )
				{
					if( t + 1 == unsorted[t] )
					{
						Console.WriteLine(t.ToString() + " at correct position");
					}
				}
				Console.WriteLine( "________Iteration " + i + " finished._________");
				*/
			}
		}

		private void Swap( int[] unsorted, int i, int j )
		{
			int tmp = unsorted[j];
			unsorted[j] = unsorted[i];
			unsorted[i] = tmp;
		}
	}
}