using System;
using NUnit.Framework;
using GeJuNaSo;
using SharpTestsEx;
using SharpTestsEx.Assertions;

namespace junaso.tests
{
	public class When_sorting_integers_using_generics
	{
		[Test]
		public void Should_yield_sorted_array()
		{
			Sorter<int> ss = new Sorter<int>();
			int[] sequence = new [] { 3, 7, 1, 6, 4, 5, 2 };

			ss.Sort(sequence);

			sequence[0].Should().Be.EqualTo(1);
			sequence[1].Should().Be.EqualTo(2);
			sequence[2].Should().Be.EqualTo(3);
			sequence[3].Should().Be.EqualTo(4);
			sequence[6].Should().Be.EqualTo(7);
		}
	}

	public class When_sorting_doubles_using_generics
	{
		[Test]
		public void Should_yield_sorted_array()
		{
			Sorter<double> ss = new Sorter<double>();
			double[] sequence = new [] { 3.0, 7.0, 1.0, 6.0, 4.0, 5.0, 2.0 };

			ss.Sort(sequence);

			sequence[0].Should().Be.EqualTo(1.0);
			sequence[1].Should().Be.EqualTo(2.0);
			sequence[2].Should().Be.EqualTo(3.0);
			sequence[3].Should().Be.EqualTo(4.0);
			sequence[6].Should().Be.EqualTo(7.0);
		}
	}
}
