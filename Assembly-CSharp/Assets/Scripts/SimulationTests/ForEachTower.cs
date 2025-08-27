namespace Assets.Scripts.SimulationTests;

public class ForEachTower : CompositeSimulationStep, ISimulationTestStep
{
	[CompilerGenerated]
	private sealed class <Run>d__7 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public SimulationTestEnvironment env; //Field offset: 0x20
		public ForEachTower <>4__this; //Field offset: 0x28
		private TowerModel[] <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38

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
		public <Run>d__7(int <>1__state) { }

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

	[Flags]
	internal enum TowerFilter
	{
		AllTowers = 0,
		BaseTowers = 1,
		Heros = 2,
		Paragons = 4,
	}

	[SerializeField]
	private TowerFilter filter; //Field offset: 0x10
	[SerializeField]
	[TowerType]
	private string baseType; //Field offset: 0x18
	[SerializeReference]
	private ISimulationTestStep[] steps; //Field offset: 0x20

	protected virtual IEnumerable<ISimulationTestStep> Steps
	{
		 get { } //Length: 5
	}

	public ForEachTower(TowerFilter filter, string baseType, ISimulationTestStep[] steps) { }

	private bool FilterTower(TowerModel tower) { }

	protected virtual IEnumerable<ISimulationTestStep> get_Steps() { }

	[IteratorStateMachine(typeof(<Run>d__7))]
	public override IEnumerator Run(SimulationTestEnvironment env, SimulationTestBlackboard bb) { }

}

