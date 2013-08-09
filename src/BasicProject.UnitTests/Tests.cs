using NUnit.Framework;

namespace BasicProject.UnitTests
{
    public class ExampleTests
    {
		[Test]
		public void TruthTest()
		{
			Assert.That(true, Is.EqualTo(true));
		}
    }
}
