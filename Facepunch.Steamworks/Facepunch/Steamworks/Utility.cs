namespace Facepunch.Steamworks;

[Extension]
public static class Utility
{
	[CompilerGenerated]
	private sealed class <UnionSelect>d__6 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable<T> first; //Field offset: 0x0
		public IEnumerable<T> <>3__first; //Field offset: 0x0
		private IEnumerable<T> second; //Field offset: 0x0
		public IEnumerable<T> <>3__second; //Field offset: 0x0
		private Func<T, T, T> selector; //Field offset: 0x0
		public Func<T, T, T> <>3__selector; //Field offset: 0x0
		private Dictionary<T, T> <items>5__2; //Field offset: 0x0
		private IEnumerator<T> <>7__wrap2; //Field offset: 0x0

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
		public <UnionSelect>d__6`1(int <>1__state) { }

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

	public static class Epoch
	{
		private static readonly DateTime epoch; //Field offset: 0x0

		private static Epoch() { }

		public static DateTime ToDateTime(decimal unixTime) { }

	}


	internal static string FormatPrice(string currency, ulong price) { }

	[Extension]
	[IteratorStateMachine(typeof(<UnionSelect>d__6`1))]
	public static IEnumerable<T> UnionSelect(IEnumerable<T> first, IEnumerable<T> second, Func<T, T, T> selector) { }

}

