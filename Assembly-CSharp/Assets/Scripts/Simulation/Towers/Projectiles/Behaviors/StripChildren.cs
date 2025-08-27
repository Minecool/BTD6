namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class StripChildren : ProjectileBehavior
{
	public StripChildrenModel stripChildrenModel; //Field offset: 0x68

	public StripChildren() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

