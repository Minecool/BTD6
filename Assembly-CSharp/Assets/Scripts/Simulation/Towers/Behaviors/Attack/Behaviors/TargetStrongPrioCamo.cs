namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class TargetStrongPrioCamo : TargetCamo
{
	public TargetStrongPrioCamoModel targetStrongPrioCamoModel; //Field offset: 0x78

	public TargetStrongPrioCamo() { }

	public virtual string GetName() { }

	public virtual Target GetTarget() { }

	public virtual IEnumerable<Target> GetTargets() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private float OrderByCamoThenStrong(Target target) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

