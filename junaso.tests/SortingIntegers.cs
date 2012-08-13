using System;
using System.Collections.Specialized;
using NUnit.Framework;
using SharpTestsEx;
using SharpTestsEx.Assertions;

namespace junaso.tests
{
	public class When_sorting_integers
	{
		[Test]
		public void Should_yield_sorted_array()
		{
			IntSorter ss = new IntSorter();
			int[] sequence = new [] { 3, 7, 1, 6, 4, 5, 2 };

			ss.Sort(sequence);

			sequence[0].Should().Be.EqualTo(1);
			sequence[1].Should().Be.EqualTo(2);
			sequence[2].Should().Be.EqualTo(3);
			sequence[3].Should().Be.EqualTo(4);
		}
	}
}
