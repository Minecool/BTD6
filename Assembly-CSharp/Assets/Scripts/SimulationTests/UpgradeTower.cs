namespace Assets.Scripts.SimulationTests;

public class UpgradeTower : ISimulationTestStep
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public SimulationTestEnvironment env; //Field offset: 0x10
		public TowerToSimulation tts; //Field offset: 0x18
		public int path; //Field offset: 0x20
		public Action<Boolean> <>9__0; //Field offset: 0x28
		public Action<Boolean> <>9__1; //Field offset: 0x30

		public <>c__DisplayClass5_0() { }

		internal void <UpgradeTowerOnPath>b__0(bool success) { }

		internal void <UpgradeTowerOnPath>b__1(bool success) { }

	}

	[CompilerGenerated]
	private sealed class <Run>d__4 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public UpgradeTower <>4__this; //Field offset: 0x20
		public SimulationTestEnvironment env; //Field offset: 0x28
		public SimulationTestBlackboard bb; //Field offset: 0x30

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
		public <Run>d__4(int <>1__state) { }

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
	private string tower; //Field offset: 0x10
	[Min(0)]
	[SerializeField]
	private int path; //Field offset: 0x18
	[Min(0)]
	[SerializeField]
	private int count; //Field offset: 0x1C

	public UpgradeTower(string tower, int path, int count) { }

	[IteratorStateMachine(typeof(<Run>d__4))]
	public override IEnumerator Run(SimulationTestEnvironment env, SimulationTestBlackboard bb) { }

	public static void UpgradeTowerOnPath(string tower, int path, int count, SimulationTestEnvironment env, SimulationTestBlackboard bb) { }

}

