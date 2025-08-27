namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class TargetDesperadoClose : TargetDesperado
{
	public TargetDesperadoCloseModel targetDesperadoCloseModel; //Field offset: 0x90

	public TargetDesperadoClose() { }

	public virtual string GetName() { }

	public virtual Target GetTarget() { }

	public virtual IEnumerable<Target> GetTargets() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

