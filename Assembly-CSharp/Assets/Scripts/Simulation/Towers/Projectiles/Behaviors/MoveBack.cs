namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class MoveBack : ProjectileBehavior
{
	public MoveBackModel moveBackModel; //Field offset: 0x68

	public MoveBack() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

