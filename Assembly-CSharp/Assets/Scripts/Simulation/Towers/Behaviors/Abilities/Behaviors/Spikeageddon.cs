namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class Spikeageddon : AbilityBehavior
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Projectile, Boolean> <>9__9_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <StartAttack>b__9_0(Projectile x) { }

	}

	public SpikeaggedonModel spikeaggedonModel; //Field offset: 0x68
	private Emission emission; //Field offset: 0x70
	private List<Projectile> projectiles; //Field offset: 0x78
	private bool isActive; //Field offset: 0x80
	public Entity effectDuringAttack; //Field offset: 0x88
	private bool isPendingStart; //Field offset: 0x90
	private List<Projectile> emittedProjectiles; //Field offset: 0x98
	private List<Path> pathsWithProjectiles; //Field offset: 0xA0

	public Spikeageddon() { }

	public virtual void Activate() { }

	private void CreateBaseProjectiles() { }

	private void CreateProjectile(Path path, float distance) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnProjectilePathChanged(Projectile projectile, Path pathBefore, Path pathAfter) { }

	private void Process(int elapsed) { }

	private void StartAttack() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

