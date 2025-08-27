namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class TargetFirstWithPreference : TargetSupplier
{
	public TargetFirstWithPreferenceModel targetFirstWithPreferenceModel; //Field offset: 0x68

	public TargetFirstWithPreference() { }

	public virtual string GetName() { }

	public virtual Target GetTarget() { }

	public virtual IEnumerable<Target> GetTargets() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private int TargetPriority(Target target) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

