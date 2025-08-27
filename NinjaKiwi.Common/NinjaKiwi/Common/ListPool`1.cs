namespace NinjaKiwi.Common;

[Il2CppSetOption(Option::NullChecks (1), False)]
[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
public static class ListPool
{
	internal struct PooledList : IDisposable
	{
		private List<T> list; //Field offset: 0x0

		public int Count
		{
			 get { } //Length: 49
		}

		public List<T> List
		{
			 get { } //Length: 497
		}

		public override void Dispose() { }

		public int get_Count() { }

		public List<T> get_List() { }

	}

	private static readonly Stack<List`1<T>> pool; //Field offset: 0x0

	private static ListPool`1() { }

	public static PooledList<T> Get() { }

}

