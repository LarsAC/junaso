using System;
using System.Collections.Specialized;
using NUnit.Framework;
using SharpTestsEx;
using SharpTestsEx.Assertions;

namespace junaso.tests
{
	public class When_sorting_an_untyped_array_of_integers
	{
		[Test]
		public void Should_yield_sorted_array()
		{
			UntypedSorterWithCast ss = new UntypedSorterWithCast();
			object[] sequence = new object[] { 3, 7, 1, 6, 4, 5, 2 };

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

	public class When_sorting_an_untyped_array_of_doubles
	{
		[Test]
		public void Should_yield_sorted_array()
		{
			UntypedSorterWithCast ss = new UntypedSorterWithCast();
			object[] sequence = new object[] { 3.0, 7.0, 1.0, 6.0, 4.0, 5.0, 2.0 };

			ss.Sort(sequence);

			sequence[0].Should().Be.EqualTo(1.0);
			sequence[1].Should().Be.EqualTo(2.0);
			sequence[2].Should().Be.EqualTo(3.0);
			sequence[3].Should().Be.EqualTo(4.0);
			sequence[4].Should().Be.EqualTo(5.0);
			sequence[5].Should().Be.EqualTo(6.0);
			sequence[6].Should().Be.EqualTo(7.0);
		}
	}
}
