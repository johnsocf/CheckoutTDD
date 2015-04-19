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
		public int getTotal() {
			var total = 0;
			foreach (var i in _products) {
				total += i.Price;
			}
			return total;
		}
		public void addProduct(Product product) {
			_products.Add(product);
		}

		public decimal processCouponDiscount(int total, int percentOff) {
			
			decimal percentageOff = (percentOff/100m);
				
			var	discount = (total * percentageOff);
			var	totalAfterDiscount = Math.Round(total - discount, 0);

			return totalAfterDiscount;
		}
	}
}

