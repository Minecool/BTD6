namespace Assets.Scripts.Simulation.Towers.Emissions.Behaviors;

internal class EmissionRotationOffTowerDirection : EmissionBehavior
{
	public EmissionRotationOffTowerDirectionModel emissionRotationOffTowerDirectionModel; //Field offset: 0x68

	public EmissionRotationOffTowerDirection() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual Projectile OnEmit(Projectile projectile, ProjectileModel def, Vector3 ejectPoint, Target target, int elapsed, Tower owner, Weapon weapon, List<Projectile> created) { }

	public virtual float OnGetDirection(ProjectileModel def, Vector3 ejectPoint, Target target, int elapsed, Tower owner, Weapon weapon, List<Projectile> created, int projectileCount, int projectileIndex) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

