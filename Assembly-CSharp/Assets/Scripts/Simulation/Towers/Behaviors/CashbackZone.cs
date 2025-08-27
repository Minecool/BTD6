namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class CashbackZone : TowerBehaviorBuff
{
	public CashbackZoneModel cashbackZoneModel; //Field offset: 0x70

	public CashbackZone() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual BuffQuery TestPlacementTowerBuff(TowerModel placementModel, Vector3 placementPosition, int owner) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

