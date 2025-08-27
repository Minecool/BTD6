namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class AgeRandom : Age
{
	public AgeRandomModel randomAgeModel; //Field offset: 0x80

	public AgeRandom() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

