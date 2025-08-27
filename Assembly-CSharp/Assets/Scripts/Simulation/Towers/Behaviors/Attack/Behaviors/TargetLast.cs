namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class TargetLast : TargetSupplier
{
	public TargetLastModel targetLastModel; //Field offset: 0x68

	public TargetLast() { }

	public virtual string GetName() { }

	public virtual Target GetTarget() { }

	public virtual IEnumerable<Target> GetTargets() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

