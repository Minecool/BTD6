namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class SyncTargetPriorityWithSubTowers : TowerBehavior
{
	public SyncTargetPriorityWithSubTowersModel syncTargetPriorityWithSubTowersModel; //Field offset: 0x68

	public SyncTargetPriorityWithSubTowers() { }

	private bool GetPrioritiseCamo() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnChangeTargetPriority(TargetType targetType) { }

	protected virtual void OnDestroy() { }

	private void OnTowerCreated(Tower createdTower, TowerModel def, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	public void Sync() { }

	private void SyncTower(Tower towerToSync, bool prioritiseCamo) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

