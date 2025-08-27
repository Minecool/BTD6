namespace Assets.Scripts.SimulationTests;

public class CreateTower : ISimulationTestStep
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Boolean> <>9__6_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Run>b__6_0(bool succeeded) { }

	}

	[CompilerGenerated]
	private sealed class <Run>d__6 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CreateTower <>4__this; //Field offset: 0x20
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
		public <Run>d__6(int <>1__state) { }

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
	[SerializeField]
	private Vector2 position; //Field offset: 0x18
	[SerializeField]
	private bool ignorePlacementChecks; //Field offset: 0x20
	private SimulationTestEnvironment env; //Field offset: 0x28
	private SimulationTestBlackboard bb; //Field offset: 0x30

	public CreateTower(string tower, Vector2 position, bool ignorePlacementChecks) { }

	private void OnTowerCreated(TowerToSimulation tts) { }

	[IteratorStateMachine(typeof(<Run>d__6))]
	public override IEnumerator Run(SimulationTestEnvironment env, SimulationTestBlackboard bb) { }

}

