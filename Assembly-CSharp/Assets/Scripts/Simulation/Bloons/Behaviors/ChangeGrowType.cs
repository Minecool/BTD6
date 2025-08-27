namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class ChangeGrowType : BloonBehavior
{
	public ChangeGrowTypeModel changeGrowTypeModel; //Field offset: 0x70

	public ChangeGrowType() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

