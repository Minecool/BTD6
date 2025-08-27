namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class Color : BloonBehavior
{
	public ColorModel colorModel; //Field offset: 0x70

	public Color() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

