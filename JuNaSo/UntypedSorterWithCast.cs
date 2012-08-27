using System;
using System.IO;
using System.Collections.Specialized;
using System.Drawing;

namespace junaso
{
	public class UntypedSorterWithCast
	{
		public void Sort(object[] unsorted)
		{
			for(int i=0; i < unsorted.Length; i ++ )
			{
				for(int j=unsorted.Length - 1; j > i; j -- )
				{
					bool mustSwap = false;

					if( unsorted[j-1].GetType() == typeof(int) )
					{
						mustSwap = 	( typeof(int) == unsorted[j-1].GetType() ) &&
									( typeof(int) == unsorted[j].GetType() ) &&
									( (int) unsorted[j-1] > (int) unsorted[j] );
					}
					else if( unsorted[j-1].GetType() == typeof(double) )
					{
						mustSwap = 	( typeof(double) == unsorted[j-1].GetType() ) &&
									( typeof(double) == unsorted[j].GetType() ) &&
									( (double) unsorted[j-1] > (double) unsorted[j] );
					}
					else
					{
						throw new ArgumentException("Unsorted elements must be of equal type", "unsorted" );
					}

					if( mustSwap )
					{
						Swap( unsorted, j-1, j );
					}
				}
			}
		}

		private void Swap( object[] unsorted, int i, int j )
		{
			object tmp = unsorted[j];
			unsorted[j] = unsorted[i];
			unsorted[i] = tmp;
		}
	}
}