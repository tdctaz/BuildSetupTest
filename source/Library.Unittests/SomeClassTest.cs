using System.Threading;
using Xunit;

namespace Library.Unittests
{
	public class SomeClassTest
	{
		[Fact]
		public void WorkingTest()
		{
			Thread.Sleep(500);

			Assert.True(true);
		}

		[Fact]
		public void SlowWorkingTest()
		{
			Thread.Sleep(20000);

			Assert.True(true);
		}
	}
}
