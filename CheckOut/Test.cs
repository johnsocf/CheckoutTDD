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
			var checkout = new Checkout();
			var total = checkout.getTotal ();
			Assert.That(total, Is.EqualTo(0));
		}
		[Test ()]
		public void Should_return_50_for_product_A  ()
		{
			var checkout = new Checkout();
			var productA = new Product { Name = "A", Price = 50 };
			checkout.addProduct(productA);
			checkout.getTotal();
			Assert.That (checkout.getTotal(), Is.EqualTo(50));
		}
		[Test ()]
		public void Should_return_120_for_product_A_and_B ()
		{
			var checkout = new Checkout ();
			var productA = new Product { Name = "A", Price = 20 };
			var productB = new Product { Name = "B", Price = 100 };
			checkout.addProduct(productA);
			checkout.addProduct(productB);
			checkout.getTotal();
			Assert.That (checkout.getTotal(), Is.EqualTo(120));
		}
		[Test ()]
		public void Should_process_A_discount ()
		{
			var checkout = new Checkout ();
			var productA = new Product { Name = "A", Price = 20 };
			var productB = new Product { Name = "B", Price = 100 };
			checkout.addProduct(productA);
			checkout.addProduct(productB);
			checkout.getTotal();
			checkout.ApplyDiscounts();
		}

	}
}

