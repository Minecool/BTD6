namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class TargetZoneDefence : TargetSupplier
{
	public TargetZoneDefenceModel targetZoneDefenceModel; //Field offset: 0x68

	public TargetZoneDefence() { }

	public virtual void Attatched() { }

	public virtual string GetName() { }

	public virtual Target GetTarget() { }

	public virtual IEnumerable<Target> GetTargets() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

