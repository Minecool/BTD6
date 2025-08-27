namespace NinjaKiwi.Common.Linq;

[Extension]
public static class ListExtensions
{
	[CompilerGenerated]
	private sealed class <Split>d__8 : IEnumerable<List`1<T>>, IEnumerable, IEnumerator<List`1<T>>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private List<T> <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private List<T> l; //Field offset: 0x0
		public List<T> <>3__l; //Field offset: 0x0
		private int nSize; //Field offset: 0x0
		public int <>3__nSize; //Field offset: 0x0
		private int <i>5__2; //Field offset: 0x0

		private override List<T> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<T>>.Current
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
		public <Split>d__8`1(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<List`1<T>> System.Collections.Generic.IEnumerable<System.Collections.Generic.List<T>>.GetEnumerator() { }

		[DebuggerHidden]
		private override List<T> System.Collections.Generic.IEnumerator<System.Collections.Generic.List<T>>.get_Current() { }

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
	public static bool All(IList<Boolean> list) { }

	[Extension]
	public static bool All(IList<T> list, Predicate<T> match) { }

	[Extension]
	public static bool Any(IList<T> list) { }

	[Extension]
	public static bool Contains(IList<T> list, T item) { }

	[Extension]
	public static bool Contains(IList<T> list, Predicate<T> match) { }

	[Extension]
	public static int FindIndex(IList<T> source, Predicate<T> match) { }

	[Extension]
	public static int FindIndex(IList<T> source, int startIndex, Predicate<T> match) { }

	[Extension]
	public static T FirstOrDefault(IList<T> list) { }

	[Extension]
	public static T FirstOrDefault(IList<T> list, Predicate<T> match) { }

	[Extension]
	public static T Pop(IList<T> list) { }

	[Extension]
	public static void Resize(List<T> list, int size, T value = null) { }

	[Extension]
	[IteratorStateMachine(typeof(<Split>d__8`1))]
	public static IEnumerable<List`1<T>> Split(List<T> l, int nSize) { }

}

