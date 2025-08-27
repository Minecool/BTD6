namespace NinjaKiwi.Common;

[Il2CppSetOption(Option::NullChecks (1), False)]
[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
public class LockList : IEnumerable<T>, IEnumerable
{
	private interface ILockAction
	{

		public void Run(LockList<T> list) { }

	}

	[Il2CppSetOption(Option::NullChecks (1), False)]
	[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
	[IsReadOnly]
	private struct LockActionAdd : ILockAction<T>
	{
		private readonly T item; //Field offset: 0x0

		public LockActionAdd(T item) { }

		public override void Run(LockList<T> list) { }

	}

	[Il2CppSetOption(Option::NullChecks (1), False)]
	[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
	[IsReadOnly]
	private struct LockActionAddRange : ILockAction<T>
	{
		private readonly IList<T> source; //Field offset: 0x0
		private readonly int sourceIndex; //Field offset: 0x0
		private readonly int length; //Field offset: 0x0

		public LockActionAddRange(IList<T> source, int sourceIndex, int length) { }

		public override void Run(LockList<T> list) { }

	}

	[Il2CppSetOption(Option::NullChecks (1), False)]
	[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
	private struct LockActionClear : ILockAction<T>
	{

		public override void Run(LockList<T> list) { }

	}

	[Il2CppSetOption(Option::NullChecks (1), False)]
	[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
	[IsReadOnly]
	private struct LockActionRemove : ILockAction<T>
	{
		private readonly T item; //Field offset: 0x0

		public LockActionRemove(T item) { }

		public override void Run(LockList<T> list) { }

	}

	[Il2CppSetOption(Option::NullChecks (1), False)]
	[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
	[IsReadOnly]
	private struct LockActionRemoveAll : ILockAction<T>
	{
		private readonly Predicate<T> match; //Field offset: 0x0

		public LockActionRemoveAll(Predicate<T> match) { }

		public override void Run(LockList<T> list) { }

	}

	[Il2CppSetOption(Option::NullChecks (1), False)]
	[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
	[IsReadOnly]
	internal struct StructLockListEnumerable : IDisposable
	{
		[Il2CppSetOption(Option::NullChecks (1), False)]
		[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
		internal struct Enumerator
		{
			private readonly LockList<T> list; //Field offset: 0x0
			private int index; //Field offset: 0x0
			private readonly Predicate<T> iterationPredicate; //Field offset: 0x0

			public T Current
			{
				 get { } //Length: 165
			}

			public Enumerator(LockList<T> list, Predicate<T> iterationPredicate) { }

			public T get_Current() { }

			public bool MoveNext() { }

			public void Reset() { }

		}

		private readonly LockList<T> list; //Field offset: 0x0

		public StructLockListEnumerable(LockList<T> list) { }

		public override void Dispose() { }

		public Enumerator<T> GetEnumerator() { }

	}

	[Il2CppSetOption(Option::NullChecks (1), False)]
	[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
	private struct StructLockListEnumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		private Enumerator<T> passthrough; //Field offset: 0x0
		private readonly Action release; //Field offset: 0x0
		private readonly Predicate<T> iterationPredicate; //Field offset: 0x0

		public override T Current
		{
			 get { } //Length: 55
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 96
		}

		public StructLockListEnumerator(Enumerator<T> passthrough, Predicate<T> iterationPredicate, Action release) { }

		public override void Dispose() { }

		public override T get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	private readonly List<T> list; //Field offset: 0x0
	private readonly List<ILockAction<T>> lockActions; //Field offset: 0x0
	private int lockCount; //Field offset: 0x0
	private readonly Action unlock; //Field offset: 0x0
	protected Predicate<T> iterationPredicate; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 8
	}

	public IList<T> Data
	{
		 get { } //Length: 5
	}

	public StructLockListEnumerable<T> DisposableEnumerable
	{
		 get { } //Length: 54
	}

	public bool IsLocked
	{
		 get { } //Length: 8
	}

	public LockList`1() { }

	public void Add(T obj) { }

	public void Add(IList<T> source, int sourceIndex, int length) { }

	public void Clear() { }

	public int get_Count() { }

	public IList<T> get_Data() { }

	public StructLockListEnumerable<T> get_DisposableEnumerable() { }

	public bool get_IsLocked() { }

	public override IEnumerator<T> GetEnumerator() { }

	public void Lock() { }

	public void Remove(T obj) { }

	public void RemoveAll(Predicate<T> match) { }

	public void Reset() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public void Unlock() { }

}

