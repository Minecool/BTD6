namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class SellIncreaseZone : TowerBehaviorBuff
{
	public SellIncreaseZoneModel sellIncreaseZoneModel; //Field offset: 0x70
	private List<RootBehavior> createdBehaviors; //Field offset: 0x78

	public SellIncreaseZone() { }

	public bool CheckBehavior(Tower tower) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual BuffQuery TestPlacementTowerBuff(TowerModel placementModel, Vector3 placementPosition, int owner) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

