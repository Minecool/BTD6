namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class TargetDesperadoStrong : TargetDesperado
{
	public TargetDesperadoStrongModel targetDesperadoStrongModel; //Field offset: 0x90

	public TargetDesperadoStrong() { }

	public virtual string GetName() { }

	public virtual Target GetTarget() { }

	public virtual IEnumerable<Target> GetTargets() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual float SortTarget(Target target) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

