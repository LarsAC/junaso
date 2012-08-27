using System;
using System.IO;
using System.Collections.Specialized;
using System.Drawing;

namespace junaso
{
	public class DoubleSorter
	{
		public void Sort(double[] unsorted)
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
			}
		}

		private void Swap( double[] unsorted, int i, int j )
		{
			double tmp = unsorted[j];
			unsorted[j] = unsorted[i];
			unsorted[i] = tmp;
		}
	}
}