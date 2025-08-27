namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class OnBloonInRangeOfHeroDialogueTrigger : SimulationBehavior
{
	private OnBloonInRangeOfHeroDialogueTriggerModel onBloonInRangeOfHeroDialogueTriggerModel; //Field offset: 0x58
	private Tower towerToTrack; //Field offset: 0x60

	public OnBloonInRangeOfHeroDialogueTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTowerCreated(Tower createdTower, TowerModel def, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	private void OnTowerDestroyed(Tower soldTower) { }

	public void Process(int ellapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

