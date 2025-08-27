namespace NinjaKiwi.LiNK.Lobbies;

public class OtherPlayersPrivate : IEnumerable<OtherPlayerPrivate>, IEnumerable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<OtherPlayerPrivate> <>9__1_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <.ctor>b__1_0(OtherPlayerPrivate x, OtherPlayerPrivate y) { }

	}

	[CompilerGenerated]
	private sealed class <GetConnected>d__5 : IEnumerable<OtherPlayerPrivate>, IEnumerable, IEnumerator<OtherPlayerPrivate>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private OtherPlayerPrivate <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public OtherPlayersPrivate <>4__this; //Field offset: 0x28
		private OtherPlayerPrivate[] <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38

		private override OtherPlayerPrivate System.Collections.Generic.IEnumerator<NinjaKiwi.LiNK.Lobbies.OtherPlayerPrivate>.Current
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
		public <GetConnected>d__5(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<OtherPlayerPrivate> System.Collections.Generic.IEnumerable<NinjaKiwi.LiNK.Lobbies.OtherPlayerPrivate>.GetEnumerator() { }

		[DebuggerHidden]
		private override OtherPlayerPrivate System.Collections.Generic.IEnumerator<NinjaKiwi.LiNK.Lobbies.OtherPlayerPrivate>.get_Current() { }

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
	private sealed class <GetEnumerator>d__8 : IEnumerator<OtherPlayerPrivate>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private OtherPlayerPrivate <>2__current; //Field offset: 0x18
		public OtherPlayersPrivate <>4__this; //Field offset: 0x20
		private OtherPlayerPrivate[] <>7__wrap1; //Field offset: 0x28
		private int <>7__wrap2; //Field offset: 0x30

		private override OtherPlayerPrivate System.Collections.Generic.IEnumerator<NinjaKiwi.LiNK.Lobbies.OtherPlayerPrivate>.Current
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
		public <GetEnumerator>d__8(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override OtherPlayerPrivate System.Collections.Generic.IEnumerator<NinjaKiwi.LiNK.Lobbies.OtherPlayerPrivate>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private readonly OtherPlayerPrivate[] otherPlayers; //Field offset: 0x10

	public bool AreAllDisconnected
	{
		 get { } //Length: 376
	}

	public OtherPlayersPrivate(List<OtherPlayerPrivate> otherPlayers) { }

	public OtherPlayerPrivate Get(byte playerNumber) { }

	public bool get_AreAllDisconnected() { }

	[IteratorStateMachine(typeof(<GetConnected>d__5))]
	public IEnumerable<OtherPlayerPrivate> GetConnected() { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__8))]
	public override IEnumerator<OtherPlayerPrivate> GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public bool TryGet(byte playerNumber, out OtherPlayerPrivate otherPlayer) { }

	public bool TryGetConnected(byte playerNumber, out OtherPlayerPrivate otherPlayer) { }

}

