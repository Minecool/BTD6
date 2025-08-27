namespace Assets.Scripts.Simulation.Towers.Emissions.Behaviors;

internal class EmissionArcRotationOffTowerDirection : EmissionBehavior
{
	public EmissionArcRotationOffTowerDirectionModel emissionArcRotationOffTowerDirectionModel; //Field offset: 0x68

	public EmissionArcRotationOffTowerDirection() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual Projectile OnEmit(Projectile projectile, ProjectileModel def, Vector3 ejectPoint, Target target, int elapsed, Tower owner, Weapon weapon, List<Projectile> created) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

