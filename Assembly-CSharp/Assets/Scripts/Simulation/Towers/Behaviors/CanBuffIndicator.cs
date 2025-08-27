namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class CanBuffIndicator : TowerBehaviorBuff
{
	public CanBuffIndicatorModel canBuffIndicatorModel; //Field offset: 0x70

	public CanBuffIndicator() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual BuffQuery TestPlacementTowerBuff(TowerModel placementModel, Vector3 placementPosition, int owner) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

