using System;
namespace design_patterns.Creational.Singleton
{
	public class OrderSystem
	{
		public void Initialize()
		{
            OrderManager orderManager = OrderManager.Instance;
            OrderManager anotherOrderManager = OrderManager.Instance;
            Console.WriteLine($"Both references are the same: {ReferenceEquals(orderManager, anotherOrderManager)}");
			Console.ReadLine();
        }
	}
}

