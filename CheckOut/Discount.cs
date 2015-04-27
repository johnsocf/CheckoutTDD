using System;
using System.Collections.Generic;

namespace CheckOut
{
	public class Discount
	{
		public int _total;
		public Discount ()
		{
			
		}

		public int Check_For_Discount(IList<Product> _products, int total)
		{
			var CountA = 0;
			var CountB = 0;
			_total = total;
			foreach (var product in _products) {
				if (product.Name == "A") {
					CountA++;
				} else if (product.Name == "B") {
					CountB++;
				}
				if ((CountA % 3) == 0 && (CountA != 0)) {
					Triple_A_Discount ();
					CountA = 0;
				}
				if ((CountB % 2) == 0 && (CountB != 0)) {
					Double_B_Discount ();
					CountB = 0;
				}
			}

			return _total;
		}

		public void Triple_A_Discount ()
		{
			_total -= 20;
		}

		public void Double_B_Discount ()
		{
			_total -= 15;
		}
	}
}

