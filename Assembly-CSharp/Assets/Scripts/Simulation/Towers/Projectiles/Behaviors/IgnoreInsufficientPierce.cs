namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class IgnoreInsufficientPierce : ProjectileBehavior
{
	public IgnoreInsufficientPierceModel ignoreInsufficientPierceModel; //Field offset: 0x68

	public IgnoreInsufficientPierce() { }

	public virtual bool FilterCollision(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

