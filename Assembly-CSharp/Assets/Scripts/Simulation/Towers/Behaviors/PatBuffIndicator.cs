namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class PatBuffIndicator : TowerBehaviorBuff
{
	private const float defaultRange = 30; //Field offset: 0x0
	public PatBuffIndicatorModel patBuffIndicatorModel; //Field offset: 0x70

	public PatBuffIndicator() { }

	public virtual float GetBuffRange() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual BuffQuery TestPlacementTowerBuff(TowerModel placementModel, Vector3 placementPosition, int owner) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

