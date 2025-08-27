namespace Assets.Scripts.Simulation.Towers.Projectiles;

public abstract class ProjectileBehaviorOnEmit : ProjectileBehavior
{

	protected ProjectileBehaviorOnEmit() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public override void OnEmit() { }

}

