namespace Assets.Scripts.SimulationTests;

public class RunReplay : ISimulationTestStep
{
	[CompilerGenerated]
	private sealed class <Run>d__5 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RunReplay <>4__this; //Field offset: 0x20
		public SimulationTestEnvironment env; //Field offset: 0x28
		private long <frameTimeInTicks>5__2; //Field offset: 0x30
		private long <ticksRemaining>5__3; //Field offset: 0x38
		private int <contiguousSteps>5__4; //Field offset: 0x40

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

	private Replay replay; //Field offset: 0x10
	private bool simulationComplete; //Field offset: 0x18
	private SimulationTestEnvironment env; //Field offset: 0x20
	private Stopwatch stopwatch; //Field offset: 0x28

	public RunReplay(Replay replay) { }

	private void OnLateRoundEnd(int completedRound, int highestCompletedRound) { }

	private void OnLost() { }

	private void OnWon() { }

	[IteratorStateMachine(typeof(<Run>d__5))]
	public override IEnumerator Run(SimulationTestEnvironment env, SimulationTestBlackboard bb) { }

}

