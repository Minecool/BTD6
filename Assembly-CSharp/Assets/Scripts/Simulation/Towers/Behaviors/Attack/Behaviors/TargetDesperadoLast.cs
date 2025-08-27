namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class TargetDesperadoLast : TargetDesperado
{
	public TargetDesperadoLastModel targetDesperadoFirstLast; //Field offset: 0x90

	public TargetDesperadoLast() { }

	public virtual string GetName() { }

	public virtual Target GetTarget() { }

	public virtual IEnumerable<Target> GetTargets() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

