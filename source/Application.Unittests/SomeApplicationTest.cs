using System.Threading;
using Xunit;

namespace Application.Unittests
{
	public class SomeApplicationTest
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

		[Fact]
		public void FailingTest()
		{
			Assert.True(false);
		}
	}
}
