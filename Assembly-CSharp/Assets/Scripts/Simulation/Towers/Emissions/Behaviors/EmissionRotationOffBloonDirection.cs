namespace Assets.Scripts.Simulation.Towers.Emissions.Behaviors;

internal class EmissionRotationOffBloonDirection : EmissionBehavior
{
	public EmissionRotationOffBloonDirectionModel emissionRotationOffBloonDirectionModel; //Field offset: 0x68
	public AirUnit airUnit; //Field offset: 0x70

	public EmissionRotationOffBloonDirection() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual Projectile OnEmit(Projectile projectile, ProjectileModel def, Vector3 ejectPoint, Target target, int elapsed, Tower owner, Weapon weapon, List<Projectile> created) { }

	public virtual float OnGetDirection(ProjectileModel def, Vector3 ejectPoint, Target target, int elapsed, Tower owner, Weapon weapon, List<Projectile> created, int projectileCount = 1, int projectileIndex = 0) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

