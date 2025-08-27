namespace Assets.Scripts.SimulationTests;

public class RunXTimes : CompositeSimulationStep, ISimulationTestStep
{
	[CompilerGenerated]
	private sealed class <Run>d__5 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RunXTimes <>4__this; //Field offset: 0x20
		public SimulationTestEnvironment env; //Field offset: 0x28
		private int <i>5__2; //Field offset: 0x30

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
		public <Run>d__5(int <>1__state) { }

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

	[SerializeField]
	private int count; //Field offset: 0x10
	[SerializeReference]
	private ISimulationTestStep[] steps; //Field offset: 0x18

	protected virtual IEnumerable<ISimulationTestStep> Steps
	{
		 get { } //Length: 5
	}

	public RunXTimes(int count, ISimulationTestStep[] steps) { }

	protected virtual IEnumerable<ISimulationTestStep> get_Steps() { }

	[IteratorStateMachine(typeof(<Run>d__5))]
	public override IEnumerator Run(SimulationTestEnvironment env, SimulationTestBlackboard bb) { }

}

