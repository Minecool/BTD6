namespace Assets.Scripts.SimulationTests;

public class CreateRandomTowers : ISimulationTestStep
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public int workingCount; //Field offset: 0x10
		public SimulationTestEnvironment env; //Field offset: 0x18

		public <>c__DisplayClass3_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_1
	{
		public TowerModel tower; //Field offset: 0x10
		public <>c__DisplayClass3_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass3_1() { }

		internal void <Run>b__0(bool succeeded) { }

	}

	[CompilerGenerated]
	private sealed class <Run>d__3 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public SimulationTestEnvironment env; //Field offset: 0x20
		public CreateRandomTowers <>4__this; //Field offset: 0x28
		public SimulationTestBlackboard bb; //Field offset: 0x30
		private <>c__DisplayClass3_0 <>8__1; //Field offset: 0x38

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
		public <Run>d__3(int <>1__state) { }

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
	private SimulationTestBlackboard bb; //Field offset: 0x18

	public CreateRandomTowers(int count = 1) { }

	private void OnTowerCreated(TowerToSimulation tts) { }

	[IteratorStateMachine(typeof(<Run>d__3))]
	public override IEnumerator Run(SimulationTestEnvironment env, SimulationTestBlackboard bb) { }

}

