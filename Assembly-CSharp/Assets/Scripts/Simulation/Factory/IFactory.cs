namespace Assets.Scripts.Simulation.Factory;

internal interface IFactory
{

	public int PooledCount
	{
		 get { } //Length: 0
	}

	public void Clear() { }

	public RootBehavior CreateBehavior() { }

	public void Flush(bool fullFlush) { }

	public int get_PooledCount() { }

	public IEnumerable<TDerived> GetAs() { }

}

