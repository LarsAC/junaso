using System;
using System.Collections.Specialized;
using NUnit.Framework;
using SharpTestsEx;
using SharpTestsEx.Assertions;

namespace junaso.tests
{
	public class When_sorting_integers_as_comparables
	{
		[Test]
		public void Should_yield_sorted_array()
		{
			SorterForComparable ss = new SorterForComparable();
			IComparable[] sequence = new IComparable[] { 3, 7, 1, 6, 4, 5, 2 };

			ss.Sort(sequence);

			sequence[0].Should().Be.EqualTo(1);
			sequence[1].Should().Be.EqualTo(2);
			sequence[2].Should().Be.EqualTo(3);
			sequence[3].Should().Be.EqualTo(4);
			sequence[4].Should().Be.EqualTo(5);
			sequence[5].Should().Be.EqualTo(6);
			sequence[6].Should().Be.EqualTo(7);
		}
	}
}
