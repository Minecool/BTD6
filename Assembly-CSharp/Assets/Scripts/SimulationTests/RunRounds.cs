namespace Assets.Scripts.SimulationTests;

public class RunRounds : ISimulationTestStep
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public SimulationTestEnvironment env; //Field offset: 0x10

		public <>c__DisplayClass14_0() { }

		internal void <SellAndCreateTowers>b__0(bool succeeded) { }

	}

	[CompilerGenerated]
	private sealed class <Run>d__11 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RunRounds <>4__this; //Field offset: 0x20
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
		public <Run>d__11(int <>1__state) { }

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
	private int startRound; //Field offset: 0x10
	[SerializeField]
	private int numRounds; //Field offset: 0x14
	[SerializeField]
	private float killAllBloonsAfterSeconds; //Field offset: 0x18
	[SerializeField]
	private bool autoActivateAbilities; //Field offset: 0x1C
	[SerializeField]
	private bool sellAndCreateTowers; //Field offset: 0x1D
	private Stopwatch stopwatch; //Field offset: 0x20
	private bool simulationComplete; //Field offset: 0x28
	private int completedRounds; //Field offset: 0x2C
	private int roundStartedAt; //Field offset: 0x30
	private SimulationTestEnvironment env; //Field offset: 0x38

	public RunRounds(int startRound, int numRounds, float killAllBloonsAfterSeconds, bool autoActivateAbilities, bool sellAndCreateTowers) { }

	private void AutoActivateAbilities(SimulationTestEnvironment env) { }

	private static bool CanSellTower(TowerToSimulation tts) { }

	private void OnLateRoundEnd(int completedRound, int highestCompletedRound) { }

	private void OnLost() { }

	[IteratorStateMachine(typeof(<Run>d__11))]
	public override IEnumerator Run(SimulationTestEnvironment env, SimulationTestBlackboard bb) { }

	private void SellAndCreateTowers(SimulationTestEnvironment env) { }

}

