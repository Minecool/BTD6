namespace Assets.Scripts.Simulation.Towers.Emissions.Behaviors;

internal class EmissionArcRotationOffDisplayDirection : EmissionBehavior
{
	public EmissionArcRotationOffDisplayDirectionModel emissionArcRotationOffDisplayDirectionModel; //Field offset: 0x68

	public EmissionArcRotationOffDisplayDirection() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual float OnGetDirection(ProjectileModel def, Vector3 ejectPoint, Target target, int elapsed, Tower owner, Weapon weapon, List<Projectile> created, int projectileCount, int projectileIndex) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

