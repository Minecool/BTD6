namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class ChipMapBasedObject : ProjectileBehavior
{
	public ChipMapBasedObjectModel chipMapBasedObjectModel; //Field offset: 0x68

	public ChipMapBasedObject() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

