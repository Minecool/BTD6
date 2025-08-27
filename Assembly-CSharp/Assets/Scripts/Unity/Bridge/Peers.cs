namespace Assets.Scripts.Unity.Bridge;

public class Peers : IEnumerable<Peer>, IEnumerable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<Peer> <>9__1_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <.ctor>b__1_0(Peer x, Peer y) { }

	}

	[CompilerGenerated]
	private sealed class <GetEnumerator>d__4 : IEnumerator<Peer>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Peer <>2__current; //Field offset: 0x18
		public Peers <>4__this; //Field offset: 0x20
		private Peer[] <>7__wrap1; //Field offset: 0x28
		private int <>7__wrap2; //Field offset: 0x30

		private override Peer System.Collections.Generic.IEnumerator<Assets.Scripts.Unity.Bridge.Peer>.Current
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
		public <GetEnumerator>d__4(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override Peer System.Collections.Generic.IEnumerator<Assets.Scripts.Unity.Bridge.Peer>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private readonly Peer[] peers; //Field offset: 0x10

	public Peers(List<Peer> peers) { }

	public Peer Get(byte playerNumber) { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__4))]
	public override IEnumerator<Peer> GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public bool TryGet(byte playerNumber, out Peer peer) { }

}

