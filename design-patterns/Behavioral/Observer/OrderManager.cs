using System;
namespace design_patterns.Behavioral.Observer
{
	public class OrderManager
	{
		private List<IListener> orderListeners = new List<IListener>();

		public void AttachListener(IListener listener)
		{
			orderListeners.Add(listener);
		}

		public void DetachListener(IListener listener)
		{
			orderListeners.Remove(listener);
		}
	}
}

