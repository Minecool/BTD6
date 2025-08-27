namespace Assets.Scripts.SimulationTests;

public abstract class CompositeSimulationStep
{
	[CompilerGenerated]
	private sealed class <RunSteps>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CompositeSimulationStep <>4__this; //Field offset: 0x20
		public SimulationTestEnvironment env; //Field offset: 0x28
		public SimulationTestBlackboard bb; //Field offset: 0x30
		private long <currentGC>5__2; //Field offset: 0x38
		private IEnumerator<ISimulationTestStep> <>7__wrap2; //Field offset: 0x40

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
		public <RunSteps>d__2(int <>1__state) { }

		private void <>m__Finally1() { }

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


	private long CurrentGCAllocated
	{
		private get { } //Length: 31
	}

	protected abstract IEnumerable<ISimulationTestStep> Steps
	{
		 get { } //Length: 0
	}

	protected CompositeSimulationStep() { }

	private string BytesToStr(long bytes) { }

	private static void GC_disable() { }

	private static void GC_enable() { }

	private static void GC_gcollect() { }

	private static long GC_get_free_bytes() { }

	private static long GC_get_heap_size() { }

	private long get_CurrentGCAllocated() { }

	protected abstract IEnumerable<ISimulationTestStep> get_Steps() { }

	[IteratorStateMachine(typeof(<RunSteps>d__2))]
	protected IEnumerator RunSteps(SimulationTestEnvironment env, SimulationTestBlackboard bb) { }

}

