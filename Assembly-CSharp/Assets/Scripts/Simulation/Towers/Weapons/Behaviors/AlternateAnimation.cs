namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class AlternateAnimation : WeaponBehavior
{
	private AlternateAnimationModel alternateAnimationModel; //Field offset: 0x68
	private int emissionCount; //Field offset: 0x70

	public AlternateAnimation() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

