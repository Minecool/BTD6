namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class VagrantWeaponBehavior : WeaponBehavior
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static ForEachDelegate<Tower> <>9__3_0; //Field offset: 0x8
		public static ForEachDelegate<Tower> <>9__3_1; //Field offset: 0x10
		public static ForEachDelegate<Bloon> <>9__3_2; //Field offset: 0x18
		public static ForEachDelegate<Bloon> <>9__3_3; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal void <Initialise>b__3_0(Tower _) { }

		internal void <Initialise>b__3_1(Tower _) { }

		internal void <Initialise>b__3_2(Bloon _) { }

		internal void <Initialise>b__3_3(Bloon _) { }

	}

	[CompilerGenerated]
	private sealed class <GetBuffs>d__10 : IEnumerable<BuffQuery>, IEnumerable, IEnumerator<BuffQuery>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private BuffQuery <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x40
		public VagrantWeaponBehavior <>4__this; //Field offset: 0x48

		private override BuffQuery System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.BuffQuery>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 29
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 89
		}

		[DebuggerHidden]
		public <GetBuffs>d__10(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<BuffQuery> System.Collections.Generic.IEnumerable<Assets.Scripts.Simulation.BuffQuery>.GetEnumerator() { }

		[DebuggerHidden]
		private override BuffQuery System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.BuffQuery>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public VagrantWeaponBehaviorModel vagrantWeaponBehaviorModel; //Field offset: 0x68
	private Zoned<Tower> towerZone; //Field offset: 0x70
	private Zoned<Bloon> bloonZone; //Field offset: 0x78

	public VagrantWeaponBehavior() { }

	private bool Filter(RootBehavior rootBehavior) { }

	[IteratorStateMachine(typeof(<GetBuffs>d__10))]
	public virtual IEnumerable<BuffQuery> GetBuffs() { }

	public virtual float GetRate(float rate) { }

	private float GetRateBloons(float rate) { }

	private float GetRateTowers(float rate) { }

	private float GetTowerRange() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

