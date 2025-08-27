namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CollideOnlyWithTarget : ProjectileBehavior
{
	public CollideOnlyWithTargetModel collideOnlyWithTargetModel; //Field offset: 0x68
	private bool ignoreFirstCheck; //Field offset: 0x70

	public CollideOnlyWithTarget() { }

	public virtual bool FilterCollision(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void SetTarget(Target target) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

