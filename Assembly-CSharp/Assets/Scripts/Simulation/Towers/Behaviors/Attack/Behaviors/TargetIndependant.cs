namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class TargetIndependant : TargetSupplier
{
	public TargetIndependantModel targetIndependantModel; //Field offset: 0x68
	private RotateToPointer rotateToPointer; //Field offset: 0x70
	private Nullable<Vector2> lastTargetPos; //Field offset: 0x78

	public TargetIndependant() { }

	public virtual string GetName() { }

	private TargetSupplier GetSubTargetSupplier() { }

	public virtual Target GetTarget() { }

	public virtual IEnumerable<Target> GetTargets() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnSwitchedFrom() { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

