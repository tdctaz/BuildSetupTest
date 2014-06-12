using System.Threading;
using Xunit;

namespace Application.IntegrationTests
{
	public class SomeIntegrationTest
	{
		[Fact]
		public void WorkingTest()
		{
			Thread.Sleep(10000);

			Assert.True(true);
		}
	}
}
