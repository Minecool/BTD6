namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class RotateToTargetAirUnit : RotateToTarget
{
	public RotateToTargetAirUnitModel rotateToTargetAirUnitModel; //Field offset: 0x88
	public List<RotateToTargetAirUnit> rotateToTargets; //Field offset: 0x90
	public bool appliedRotation; //Field offset: 0x98

	public RotateToTargetAirUnit() { }

	protected virtual void ApplyRotation() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

