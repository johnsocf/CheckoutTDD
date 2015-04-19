using NUnit.Framework;
using System;

namespace CheckOut
{
	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void TestCase ()
		{
			var checkout = new Checkout ();
			var total = checkout.getTotal ();
			Assert.That(total, Is.EqualTo(0));
		}
	}
}

