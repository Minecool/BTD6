namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class TargetClosePrioCamo : TargetCamo
{
	public TargetClosePrioCamoModel targetClosePrioCamoModel; //Field offset: 0x78

	public TargetClosePrioCamo() { }

	public virtual string GetName() { }

	public virtual Target GetTarget() { }

	public virtual IEnumerable<Target> GetTargets() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

