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
			var productA = new Product { Name = "A", Price = 50 };
			var productB = new Product { Name = "B", Price = 30 };
			checkout.addProduct(productA);
			checkout.addProduct(productB);
			checkout.getTotal();
			Assert.That (checkout.getTotal(), Is.EqualTo(80));
		}
		[Test ()]
		public void Should_return_130_for_3_A_Products ()
		{
			var checkout = new Checkout ();
			var productA = new Product { Name = "A", Price = 50 };
			checkout.addProduct(productA);
			checkout.addProduct(productA);
			checkout.addProduct(productA);
			var total = checkout.getTotal();
			var totalAfterDiscounts = checkout.ApplyDiscounts(total);
			Assert.That (totalAfterDiscounts, Is.EqualTo(130));
		}

		[Test ()]
		public void Should_return_180_for_4_A_Products ()
		{
			var checkout = new Checkout ();
			var productA = new Product { Name = "A", Price = 50 };
			checkout.addProduct(productA);
			checkout.addProduct(productA);
			checkout.addProduct(productA);
			checkout.addProduct(productA);
			var total = checkout.getTotal();
			var totalAfterDiscounts = checkout.ApplyDiscounts(total);
			Assert.That (totalAfterDiscounts, Is.EqualTo(180));
		}

	}
}

