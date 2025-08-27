namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class EjectMultipleTestEffect : WeaponBehavior
{
	public EjectMultipleTestEffectModel ejectMultipleTestEffectModel; //Field offset: 0x68

	public EjectMultipleTestEffect() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

