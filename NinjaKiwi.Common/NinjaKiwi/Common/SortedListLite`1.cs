namespace NinjaKiwi.Common;

[Il2CppSetOption(Option::NullChecks (1), False)]
[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
public class SortedListLite : ListLite<T>
{
	internal sealed class SortFunction : MulticastDelegate
	{

		public SortFunction(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(T t1, T t2, AsyncCallback callback, object object) { }

		public override int EndInvoke(IAsyncResult result) { }

		public override int Invoke(T t1, T t2) { }

	}

	protected readonly SortFunction<T> sortFunction; //Field offset: 0x0

	public SortedListLite`1(SortFunction<T> sortFunction, int size = 1) { }

	public void Add(T item) { }

	public void Insert(int index, T item) { }

	public void Sort(Comparison<T> comparison) { }

	private int SortedInsert(int minIndex, int maxIndex, T[] list, T item) { }

}

