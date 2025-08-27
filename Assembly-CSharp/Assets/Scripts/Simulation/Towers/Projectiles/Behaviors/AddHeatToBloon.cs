namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class AddHeatToBloon : ProjectileBehavior
{
	public AddHeatToBloonModel addHeatModel; //Field offset: 0x68

	public AddHeatToBloon() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

