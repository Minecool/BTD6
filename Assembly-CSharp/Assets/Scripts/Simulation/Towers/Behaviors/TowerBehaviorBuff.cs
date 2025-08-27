namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class TowerBehaviorBuff : TowerBehavior
{
	public TowerBehaviorBuffModel towerBehaviorBuffModel; //Field offset: 0x68

	public TowerBehaviorBuff() { }

	public override float GetBuffRange() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public override BuffQuery TestPlacementTowerBuff(TowerModel placementModel, Vector3 placementPosition, int owner) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

