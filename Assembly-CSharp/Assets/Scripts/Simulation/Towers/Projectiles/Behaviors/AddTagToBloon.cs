namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class AddTagToBloon : ProjectileBehavior
{
	public AddTagToBloonModel addTagToBloonModel; //Field offset: 0x68

	public AddTagToBloon() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

