namespace Assets.Scripts.Simulation.Artifacts.Behaviors;

public class ProjectileCarouselBehavior : ItemArtifactBehavior
{
	[CompilerGenerated]
	private sealed class <GetTowerModelsWithProjectiles>d__5 : IEnumerable<TowerModel>, IEnumerable, IEnumerator<TowerModel>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private TowerModel <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private IEnumerable<Tower> towers; //Field offset: 0x28
		public IEnumerable<Tower> <>3__towers; //Field offset: 0x30
		private IEnumerator<Tower> <>7__wrap1; //Field offset: 0x38

		private override TowerModel System.Collections.Generic.IEnumerator<Assets.Scripts.Models.Towers.TowerModel>.Current
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
		public <GetTowerModelsWithProjectiles>d__5(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<TowerModel> System.Collections.Generic.IEnumerable<Assets.Scripts.Models.Towers.TowerModel>.GetEnumerator() { }

		[DebuggerHidden]
		private override TowerModel System.Collections.Generic.IEnumerator<Assets.Scripts.Models.Towers.TowerModel>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public ProjectileCarouselBehaviorModel projectileCarouselBehaviorModel; //Field offset: 0x78

	public ProjectileCarouselBehavior() { }

	public virtual ProjectileModel GetModifiedTowerEmittedProjectileModel(ProjectileModel projectileModel, Tower tower, Weapon entityWeapon) { }

	[IteratorStateMachine(typeof(<GetTowerModelsWithProjectiles>d__5))]
	private IEnumerable<TowerModel> GetTowerModelsWithProjectiles(IEnumerable<Tower> towers) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

