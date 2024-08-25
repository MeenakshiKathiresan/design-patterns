using System;
namespace design_patterns.Creational.Singleton
{
	public class OrderManager
	{
		private static OrderManager _instance;
		private static readonly object _lock = new object();

        public static OrderManager Instance
		{
			get {
				if(_instance == null)
				{
					lock (_lock)
					{
						if(_instance == null)
						{
							_instance = new OrderManager();
						}
					}
				}
				return _instance;
			}
		}
	}
}

