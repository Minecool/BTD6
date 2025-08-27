namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class TargetOpposite : TargetSupplier
{
	public TargetOppositeModel targetOppositeModel; //Field offset: 0x68

	public TargetOpposite() { }

	public virtual string GetName() { }

	private TargetSupplier GetOpposite() { }

	public virtual Target GetTarget() { }

	public virtual IEnumerable<Target> GetTargets() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

