namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class MarkedToPopProjectileBehavior : ProjectileBehavior
{
	public MarkedToPopProjectileBehaviorModel markedToPopProjectileBehaviorModel; //Field offset: 0x68

	public MarkedToPopProjectileBehavior() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void SetTarget(Target target) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

