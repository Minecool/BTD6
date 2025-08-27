namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class FrozenCascade : AbilityBehavior
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public Vector2 silasPosition; //Field offset: 0x10
		public Func<Tower, Single> <>9__0; //Field offset: 0x18

		public <>c__DisplayClass9_0() { }

		internal float <Activate>b__0(Tower t) { }

	}

	[CompilerGenerated]
	private sealed class <FindTowersToAffect>d__10 : IEnumerable<Tower>, IEnumerable, IEnumerator<Tower>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Tower <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public FrozenCascade <>4__this; //Field offset: 0x28
		private IEnumerator<Tower> <>7__wrap1; //Field offset: 0x30

		private override Tower System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Towers.Tower>.Current
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
		public <FindTowersToAffect>d__10(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Tower> System.Collections.Generic.IEnumerable<Assets.Scripts.Simulation.Towers.Tower>.GetEnumerator() { }

		[DebuggerHidden]
		private override Tower System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Towers.Tower>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public FrozenCascadeModel frozenCascadeModel; //Field offset: 0x68
	private Emission emission; //Field offset: 0x70
	private readonly List<Tower> towersToExplode; //Field offset: 0x78
	private int startedAt; //Field offset: 0x80

	public FrozenCascade() { }

	public virtual void Activate() { }

	public virtual bool CanUseAbility() { }

	[IteratorStateMachine(typeof(<FindTowersToAffect>d__10))]
	private IEnumerable<Tower> FindTowersToAffect() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

