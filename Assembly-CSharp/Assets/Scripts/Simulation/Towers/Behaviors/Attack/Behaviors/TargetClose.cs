namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class TargetClose : TargetSupplier
{
	public TargetCloseModel targetCloseModel; //Field offset: 0x68

	public TargetClose() { }

	public virtual string GetName() { }

	public virtual Target GetTarget() { }

	public virtual IEnumerable<Target> GetTargets() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

