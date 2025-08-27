namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class EmergencyUnlockSimBehavior : SimulationBehavior
{
	public EmergencyUnlockSimBehaviorModel emergencyUnlockSimBehaviorModel; //Field offset: 0x58
	public Dictionary<Int32, Int32> activatedAtForPlayer; //Field offset: 0x60

	public EmergencyUnlockSimBehavior() { }

	public bool CanUseAbility(EmergencyUnlockModel emergencyUnlockModel, int owner) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void OnActivate(EmergencyUnlockModel emergencyUnlockModel, int owner) { }

	protected virtual void OnDestroy() { }

	private void OnTargetTypeChanged(Tower tower, TargetType targetType) { }

	private void OnTowerUpgraded(Tower tower, TowerModel def, float upgradecost, int pathupgraded, double cashbefore, double cashafter, bool playUpgradeEffect, bool isParagon, bool leveledFromEndOfRoundXp, double nonUpgradeCashInvestment) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

