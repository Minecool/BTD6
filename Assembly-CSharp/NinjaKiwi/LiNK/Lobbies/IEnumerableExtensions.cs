namespace NinjaKiwi.LiNK.Lobbies;

[Extension]
public static class IEnumerableExtensions
{
	[CompilerGenerated]
	private sealed class <InsertWhere>d__0 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable<T> original; //Field offset: 0x0
		public IEnumerable<T> <>3__original; //Field offset: 0x0
		private Func<T, T, Boolean> predicate; //Field offset: 0x0
		public Func<T, T, Boolean> <>3__predicate; //Field offset: 0x0
		private T itemToAdd; //Field offset: 0x0
		public T <>3__itemToAdd; //Field offset: 0x0
		private bool <added>5__2; //Field offset: 0x0
		private IEnumerator<T> <>7__wrap2; //Field offset: 0x0
		private T <item>5__4; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <InsertWhere>d__0`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[DebuggerHidden]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}


	[Extension]
	public static bool AnyItem(IEnumerable<T> items, Func<T, Boolean> predicate) { }

	[Extension]
	public static bool Contains(IEnumerable<Int32> list, int value) { }

	[Extension]
	public static byte CountByte(IEnumerable<T> items) { }

	[Extension]
	[IteratorStateMachine(typeof(<InsertWhere>d__0`1))]
	public static IEnumerable<T> InsertWhere(IEnumerable<T> original, T itemToAdd, Func<T, T, Boolean> predicate) { }

	[Extension]
	public static bool IsEmpty(IEnumerable<T> enumerable) { }

	[Extension]
	public static bool TryGetValue(IEnumerable<KeyValuePair`2<Byte, T>> enumerable, byte i, out T value) { }

}

