namespace Firebase.Unity;

[Preserve]
internal class UnitySynchronizationContext : SynchronizationContext
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{

		public <>c__DisplayClass14_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_1
	{

		public <>c__DisplayClass14_1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public SendOrPostCallback d; //Field offset: 0x10

		public <>c__DisplayClass16_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_1
	{
		public ManualResetEvent newSignal; //Field offset: 0x10
		public <>c__DisplayClass16_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass16_1() { }

		internal void <Send>b__0(object x) { }

	}

	[CompilerGenerated]
	private sealed class <SignaledCoroutine>d__13
	{

	}

	private class SynchronizationContextBehavoir : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class <Start>d__3 : IEnumerator<Object>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private object <>2__current; //Field offset: 0x18
			public SynchronizationContextBehavoir <>4__this; //Field offset: 0x20
			private Tuple<SendOrPostCallback, Object> <entry>5__1; //Field offset: 0x28
			private Queue<Tuple`2<SendOrPostCallback, Object>> <>s__2; //Field offset: 0x30
			private bool <>s__3; //Field offset: 0x38
			private Exception <e>5__4; //Field offset: 0x40

			private override object System.Collections.Generic.IEnumerator<System.Object>.Current
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
			public <Start>d__3(int <>1__state) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		private Queue<Tuple`2<SendOrPostCallback, Object>> callbackQueue; //Field offset: 0x20

		public Queue<Tuple`2<SendOrPostCallback, Object>> CallbackQueue
		{
			 get { } //Length: 119
		}

		public SynchronizationContextBehavoir() { }

		public Queue<Tuple`2<SendOrPostCallback, Object>> get_CallbackQueue() { }

		[IteratorStateMachine(typeof(<Start>d__3))]
		[Preserve]
		private IEnumerator Start() { }

	}

	private static UnitySynchronizationContext _instance; //Field offset: 0x0
	private static Dictionary<Int32, ManualResetEvent> signalDictionary; //Field offset: 0x8
	private Queue<Tuple`2<SendOrPostCallback, Object>> queue; //Field offset: 0x18
	private SynchronizationContextBehavoir behavior; //Field offset: 0x20
	private int mainThreadId; //Field offset: 0x28

	private static UnitySynchronizationContext() { }

	private UnitySynchronizationContext(GameObject gameObject) { }

	public static void Create(GameObject gameObject) { }

	public static void Destroy() { }

	private ManualResetEvent GetThreadEvent() { }

	public virtual void Post(SendOrPostCallback d, object state) { }

	public virtual void Send(SendOrPostCallback d, object state) { }

}

