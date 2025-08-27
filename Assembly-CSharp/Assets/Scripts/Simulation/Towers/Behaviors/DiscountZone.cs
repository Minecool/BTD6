namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class DiscountZone : TowerBehaviorBuff
{
	public DiscountZoneModel discountZoneModel; //Field offset: 0x70

	public DiscountZone() { }

	private BuffQuery CheckUpgradePathForBuffViability(BuffQuery result, string upgrade) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual BuffQuery TestPlacementTowerBuff(TowerModel placementModel, Vector3 placementPosition, int owner) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

