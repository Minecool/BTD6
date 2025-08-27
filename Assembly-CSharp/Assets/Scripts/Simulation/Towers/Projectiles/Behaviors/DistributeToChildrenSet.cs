namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class DistributeToChildrenSet : ProjectileBehavior
{
	public DistributeToChildrenSetModel distributeToChildrenSetModel; //Field offset: 0x68
	public int lifespan; //Field offset: 0x70

	public DistributeToChildrenSet() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

