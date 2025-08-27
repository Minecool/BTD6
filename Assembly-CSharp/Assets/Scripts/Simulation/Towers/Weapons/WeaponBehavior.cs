namespace Assets.Scripts.Simulation.Towers.Weapons;

public abstract class WeaponBehavior : EntityBehavior, IWeaponBehavior, IEntityBehavior
{
	[CompilerGenerated]
	private sealed class <GetBuffs>d__13 : IEnumerable<BuffQuery>, IEnumerable, IEnumerator<BuffQuery>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private BuffQuery <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x40

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
		public <GetBuffs>d__13(int <>1__state) { }

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

	public Weapon weapon; //Field offset: 0x60

	protected WeaponBehavior() { }

	public override bool CanFire() { }

	public virtual void Cleanup() { }

	public override void EmissionStarted() { }

	public override Nullable<Vector3> EmitPosition() { }

	public override Nullable<Single> EmitRotation() { }

	public override bool FilterEmission() { }

	public override Nullable<Int32> GetAnimation(int currentAnimation) { }

	[IteratorStateMachine(typeof(<GetBuffs>d__13))]
	public override IEnumerable<BuffQuery> GetBuffs() { }

	public override Emission GetEmission(Emission currentEmissionDef, bool doubleShot = false) { }

	public override ProjectileModel GetProjectile(ProjectileModel currentProjectileDef, bool doubleShot = false) { }

	public override float GetRate(float rate) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public override bool OnPreEmissionCheck() { }

	public override void ProjectilesCreated(List<Projectile> projectiles) { }

}

