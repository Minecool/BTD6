namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class AddHeatAction : BloonBehaviorAction
{
	public AddHeatActionModel addHeatModel; //Field offset: 0x78

	public AddHeatAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

