namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class TargetFirst : TargetSupplier
{
	public TargetFirstModel targetFirstModel; //Field offset: 0x68

	public TargetFirst() { }

	public virtual string GetName() { }

	public virtual Target GetTarget() { }

	public virtual IEnumerable<Target> GetTargets() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

