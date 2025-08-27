namespace Assets.Scripts.Simulation.Towers.Emissions;

public abstract class EmissionBehavior : EntityBehavior
{
	public Emission emission; //Field offset: 0x60

	protected EmissionBehavior() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public override Projectile OnEmit(Projectile projectile, ProjectileModel def, Vector3 ejectPoint, Target target, int elapsed, Tower owner, Weapon weapon, List<Projectile> created) { }

	public override float OnGetDirection(ProjectileModel def, Vector3 ejectPoint, Target target, int elapsed, Tower owner, Weapon weapon, List<Projectile> created, int projectileCount = 1, int projectileIndex = 0) { }

	public override ProjectileModel ProjectileModelMod(ProjectileModel def, Target target) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

