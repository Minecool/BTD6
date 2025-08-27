namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class TargetLastSharedRange : TargetSupplierSharedRange
{
	public TargetLastSharedRangeModel targetLastSharedRangeModel; //Field offset: 0x80

	public TargetLastSharedRange() { }

	public virtual string GetName() { }

	public virtual IEnumerable<Target> GetTargets() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

