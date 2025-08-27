namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class CreateEffectOnAirUnitDestroy : TowerBehavior
{
	public CreateEffectOnAirUnitDestroyModel createEffectOnAirUnitDestroyModel; //Field offset: 0x68
	private TransformBehavior airUnitTransform; //Field offset: 0x70

	public CreateEffectOnAirUnitDestroy() { }

	public virtual void Attatched() { }

	private void CreateEffect() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

