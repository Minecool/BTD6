namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class IncreaseBloonWorth : ProjectileBehavior
{
	public IncreaseBloonWorthModel increaseBloonWorthModel; //Field offset: 0x68
	private Filter bloonFilter; //Field offset: 0x70

	public IncreaseBloonWorth() { }

	public bool CheckRegrowParameters(Bloon bloon) { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

