using System;

namespace junaso
{
	public class SorterForComparable
	{
		public void Sort(IComparable[] unsorted)
		{
			for(int i=0; i < unsorted.Length; i ++ )
			{
				for(int j=unsorted.Length - 1; j > i; j -- )
				{
					if( unsorted[j-1].CompareTo(unsorted[j]) > 0 )
					{
						Swap( unsorted, j-1, j );
					}
				}
			}
		}

		private void Swap( IComparable[] unsorted, int i, int j )
		{
			IComparable tmp = unsorted[j];
			unsorted[j] = unsorted[i];
			unsorted[i] = tmp;
		}
	}
}

