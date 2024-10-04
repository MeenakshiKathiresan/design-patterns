using System;
namespace design_patterns.Behavioral.Observer
{
	public class Order
	{
		public Status status;

		public enum Status
		{
			Placed,
			Shipped,
			Delivered,
			Cancelled
		}
	}
}

