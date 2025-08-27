namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class HasSpellcastProjectile : WeaponBehavior
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Projectile> <>9__5_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <ProjectilesCreated>b__5_0(Projectile x) { }

	}

	public HasSpellcastProjectileModel spellcastModel; //Field offset: 0x68
	public Projectile activeProjectile; //Field offset: 0x70
	public Action onActiveProjectileCreated; //Field offset: 0x78

	public HasSpellcastProjectile() { }

	private void ActiveProjectile_OnDestroyEvent(RootObject obj) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

