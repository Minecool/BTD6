namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class CreateEffectOnAirUnit : TowerBehavior
{
	public CreateEffectOnAirUnitModel createEffectOnAirUnitModel; //Field offset: 0x68
	private Entity effect; //Field offset: 0x70
	private TransformBehavior airUnitTransform; //Field offset: 0x78

	public CreateEffectOnAirUnit() { }

	public virtual void Attatched() { }

	private void CreateEffect() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void TowerSuspendedStateChanged() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

