namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class FighterPilotPattern : PathSupplier
{
	[CompilerGenerated]
	private sealed class <GetTargets>d__10 : IEnumerable<Target>, IEnumerable, IEnumerator<Target>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Target <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x60
		public FighterPilotPattern <>4__this; //Field offset: 0x68

		private override Target System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Towers.Target>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 45
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 107
		}

		[DebuggerHidden]
		public <GetTargets>d__10(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Target> System.Collections.Generic.IEnumerable<Assets.Scripts.Simulation.Towers.Target>.GetEnumerator() { }

		[DebuggerHidden]
		private override Target System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Towers.Target>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private const int updateTargetTimeFrames = 15; //Field offset: 0x0
	public FighterPilotPatternFirstModel fighterPilotPatternModel; //Field offset: 0xA0
	protected Tower parentTower; //Field offset: 0xA8
	private Target attackTarget; //Field offset: 0xB0
	private int targetLastUpdatedAt; //Field offset: 0xF8

	public FighterPilotPattern() { }

	public virtual string GetName() { }

	public virtual Vector2[] GetPath() { }

	protected override Vector2 GetPursuitDestination() { }

	public virtual Target GetTarget() { }

	[IteratorStateMachine(typeof(<GetTargets>d__10))]
	public virtual IEnumerable<Target> GetTargets() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private bool IsBloonValidAndCamo(Bloon bloon) { }

	private void SearchForTarget() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

