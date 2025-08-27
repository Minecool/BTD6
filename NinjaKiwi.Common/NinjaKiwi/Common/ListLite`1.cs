namespace NinjaKiwi.Common;

[DefaultMember("Item")]
[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
[Il2CppSetOption(Option::NullChecks (1), False)]
public class ListLite : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
{
	internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		private ListLite<T> list; //Field offset: 0x0
		private int index; //Field offset: 0x0
		private T current; //Field offset: 0x0

		public override T Current
		{
			 get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 37
		}

		public Enumerator(ListLite<T> list) { }

		public override void Dispose() { }

		public override T get_Current() { }

		public override bool MoveNext() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override void System.Collections.IEnumerator.Reset() { }

	}

	private const int maxArrayLength = 2146435071; //Field offset: 0x0
	private const int _defaultCapacity = 4; //Field offset: 0x0
	protected T[] _items; //Field offset: 0x0
	protected int _size; //Field offset: 0x0

	public int Capacity
	{
		 get { } //Length: 8
		 set { } //Length: 182
	}

	public override int Count
	{
		 get { } //Length: 4
	}

	public T[] Data
	{
		 get { } //Length: 5
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 3
	}

	public override T Item
	{
		 get { } //Length: 13
		 set { } //Length: 13
	}

	public ListLite`1() { }

	public ListLite`1(int capacity) { }

	public override void Add(T item) { }

	public void Add(T[] source, int sourceIndex, int length) { }

	public override void Clear() { }

	public override bool Contains(T item) { }

	public override void CopyTo(T[] array, int arrayIndex) { }

	protected void EnsureCapacity(int min) { }

	public bool Exists(Predicate<T> match) { }

	public T Find(Predicate<T> match) { }

	public int FindIndex(int startIndex, int count, Predicate<T> match) { }

	public int FindIndex(int startIndex, Predicate<T> match) { }

	public int FindIndex(Predicate<T> match) { }

	public int get_Capacity() { }

	public override int get_Count() { }

	public T[] get_Data() { }

	public override bool get_IsReadOnly() { }

	public override T get_Item(int index) { }

	public Enumerator<T> GetEnumerator() { }

	public override int IndexOf(T item) { }

	public int IndexOf(T item, int index) { }

	public int IndexOf(T item, int index, int count) { }

	public override void Insert(int index, T item) { }

	public override bool Remove(T item) { }

	public int RemoveAll(Predicate<T> match) { }

	public override void RemoveAt(int index) { }

	public void RemoveRange(int index, int count) { }

	public void set_Capacity(int value) { }

	public override void set_Item(int index, T value) { }

	public void Sort() { }

	public void Sort(IComparer<T> comparer) { }

	public void Sort(int index, int count, IComparer<T> comparer) { }

	public void Sort(Comparison<T> comparison) { }

	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public T[] ToArray() { }

	public void TrimExcess() { }

}

