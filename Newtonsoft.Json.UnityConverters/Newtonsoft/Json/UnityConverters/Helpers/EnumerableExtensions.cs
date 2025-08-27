namespace Newtonsoft.Json.UnityConverters.Helpers;

[Extension]
internal static class EnumerableExtensions
{
	[CompilerGenerated]
	private sealed class <WhereNotNullRef>d__0 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable<T> values; //Field offset: 0x0
		public IEnumerable<T> <>3__values; //Field offset: 0x0
		private IEnumerator<T> <>7__wrap1; //Field offset: 0x0

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
		public <WhereNotNullRef>d__0`1(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <WhereNotNullValue>d__1 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable<Nullable`1<T>> values; //Field offset: 0x0
		public IEnumerable<Nullable`1<T>> <>3__values; //Field offset: 0x0
		private IEnumerator<Nullable`1<T>> <>7__wrap1; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 147
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 156
		}

		[DebuggerHidden]
		public <WhereNotNullValue>d__1`1(int <>1__state) { }

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
	[IteratorStateMachine(typeof(<WhereNotNullRef>d__0`1))]
	public static IEnumerable<T> WhereNotNullRef(IEnumerable<T> values) { }

	[Extension]
	[IteratorStateMachine(typeof(<WhereNotNullValue>d__1`1))]
	public static IEnumerable<T> WhereNotNullValue(IEnumerable<Nullable`1<T>> values) { }

}

