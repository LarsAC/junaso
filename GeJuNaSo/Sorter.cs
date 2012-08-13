using System;

namespace GeJuNaSo
{
	public class Sorter<T> where T : IComparable
	{
		public void Sort(T[] unsorted)
		{
			for(int i=0; i < unsorted.Length - 1; i ++ )
			{
				for(int j=i+1; j < unsorted.Length; j ++ )
				{
					if( unsorted[i].CompareTo(unsorted[j]) > 0 )
					{
						Swap( unsorted, i, j );
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

