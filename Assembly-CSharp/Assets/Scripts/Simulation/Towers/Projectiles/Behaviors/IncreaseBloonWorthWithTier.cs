namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class IncreaseBloonWorthWithTier : ProjectileBehavior
{
	public IncreaseBloonWorthWithTierModel increaseBloonWorthWithTierModel; //Field offset: 0x68

	public IncreaseBloonWorthWithTier() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

