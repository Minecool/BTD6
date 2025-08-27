namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class UsePresetTarget : TargetSupplier
{
	public UsePresetTargetModel targetModel; //Field offset: 0x68
	private List<Target> targets; //Field offset: 0x70

	public UsePresetTarget() { }

	public virtual string GetName() { }

	public virtual IEnumerable<Target> GetTargets() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void SetTarget(Target target) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

