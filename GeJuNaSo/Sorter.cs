using System;

namespace GeJuNaSo
{
	public class Sorter<T> where T : IComparable<T>
	{
		public void Sort(T[] unsorted)
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

		private void Swap( T[] unsorted, int i, int j )
		{
			T tmp = unsorted[j];
			unsorted[j] = unsorted[i];
			unsorted[i] = tmp;
		}
	}
}

