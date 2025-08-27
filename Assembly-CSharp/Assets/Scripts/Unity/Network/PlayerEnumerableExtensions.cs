namespace Assets.Scripts.Unity.Network;

[Extension]
public static class PlayerEnumerableExtensions
{
	[CompilerGenerated]
	private sealed class <WhereConnected>d__0 : IEnumerable<CoopPlayerInfo>, IEnumerable, IEnumerator<CoopPlayerInfo>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private CoopPlayerInfo <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private IEnumerable<CoopPlayerInfo> players; //Field offset: 0x28
		public IEnumerable<CoopPlayerInfo> <>3__players; //Field offset: 0x30
		private IEnumerator<CoopPlayerInfo> <>7__wrap1; //Field offset: 0x38

		private override CoopPlayerInfo System.Collections.Generic.IEnumerator<Assets.Scripts.Unity.Network.CoopPlayerInfo>.Current
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
		public <WhereConnected>d__0(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<CoopPlayerInfo> System.Collections.Generic.IEnumerable<Assets.Scripts.Unity.Network.CoopPlayerInfo>.GetEnumerator() { }

		[DebuggerHidden]
		private override CoopPlayerInfo System.Collections.Generic.IEnumerator<Assets.Scripts.Unity.Network.CoopPlayerInfo>.get_Current() { }

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
	[IteratorStateMachine(typeof(<WhereConnected>d__0))]
	public static IEnumerable<CoopPlayerInfo> WhereConnected(IEnumerable<CoopPlayerInfo> players) { }

}

