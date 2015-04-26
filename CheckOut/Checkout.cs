using System;
using System.Collections.Generic;

namespace CheckOut
{
	public class Checkout
	{
		private IList<Product> _products;

		public Checkout ()
		{
			_products = new List<Product>();

		}
		public int getTotal() 
		{
			var total = 0;
			foreach (var i in _products) {
				total += i.Price;
			}
			return total;
		}
		public void ApplyDiscounts()
		{
			var discount = new Discount ();
			discount.Check_For_Discount(_products);
		}
		public void addProduct(Product product) 
		{
			_products.Add(product);
		}

	}
}

