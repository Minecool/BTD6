namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class Wind : ProjectileBehavior
{
	public WindModel windModel; //Field offset: 0x68

	public Wind() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

