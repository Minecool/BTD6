namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class TargetCloseSharedRange : TargetSupplierSharedRange
{
	public TargetCloseSharedRangeModel targetCloseSharedRangeModel; //Field offset: 0x80

	public TargetCloseSharedRange() { }

	public virtual string GetName() { }

	public virtual IEnumerable<Target> GetTargets() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

