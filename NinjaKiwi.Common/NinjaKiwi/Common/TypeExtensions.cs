namespace NinjaKiwi.Common;

[Extension]
public static class TypeExtensions
{
	[CompilerGenerated]
	private sealed class <BaseTypesAndSelf>d__0 : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Type <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private Type type; //Field offset: 0x28
		public Type <>3__type; //Field offset: 0x30

		private override Type System.Collections.Generic.IEnumerator<System.Type>.Current
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
		public <BaseTypesAndSelf>d__0(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator() { }

		[DebuggerHidden]
		private override Type System.Collections.Generic.IEnumerator<System.Type>.get_Current() { }

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
	[IteratorStateMachine(typeof(<BaseTypesAndSelf>d__0))]
	public static IEnumerable<Type> BaseTypesAndSelf(Type type) { }

}

