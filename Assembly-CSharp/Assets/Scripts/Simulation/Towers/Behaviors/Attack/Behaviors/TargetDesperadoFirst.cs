namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class TargetDesperadoFirst : TargetDesperado
{
	public TargetDesperadoFirstModel targetDesperadoFirstModel; //Field offset: 0x90

	public TargetDesperadoFirst() { }

	public virtual string GetName() { }

	public virtual Target GetTarget() { }

	public virtual IEnumerable<Target> GetTargets() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

