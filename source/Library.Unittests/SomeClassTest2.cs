using System.Threading;
using Xunit;

namespace Library.Unittests
{
	public class SomeClassTest2
	{
		[Fact]
		public void WorkingTest()
		{
			Thread.Sleep(500);

			Assert.True(true);
		}

		[Fact]
		public void SlowWorkingTest1()
		{
			Thread.Sleep(10000);

			Assert.True(true);
		}

		[Fact]
		public void SlowWorkingTest2()
		{
			Thread.Sleep(10000);

			Assert.True(true);
		}

		[Fact]
		public void SlowWorkingTest3()
		{
			Thread.Sleep(10000);

			Assert.True(true);
		}
	}
}
