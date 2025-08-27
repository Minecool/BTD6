namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class RandomTarget : TargetSupplier
{
	public RandomTargetModel randomTargetModel; //Field offset: 0x68
	private Target lastTarget; //Field offset: 0x70
	private List<RandomTarget> randomTargets; //Field offset: 0xB8

	public RandomTarget() { }

	public virtual string GetName() { }

	public virtual Target GetTarget() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

