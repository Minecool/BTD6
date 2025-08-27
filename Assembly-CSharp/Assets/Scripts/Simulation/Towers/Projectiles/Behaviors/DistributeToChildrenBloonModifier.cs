namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class DistributeToChildrenBloonModifier : ProjectileBehavior
{
	public DistributeToChildrenBloonModifierModel distributeToChildrenBloonModifierModel; //Field offset: 0x68

	public DistributeToChildrenBloonModifier() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

