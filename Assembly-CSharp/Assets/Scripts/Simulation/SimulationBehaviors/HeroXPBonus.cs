namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class HeroXPBonus : SimulationBehavior
{
	public float xpBonus; //Field offset: 0x58
	private HeroXPBonusModel heroXPBonusModel; //Field offset: 0x60

	public HeroXPBonus() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTowerCreated(Tower tower, TowerModel def, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	private void OnTowerDestroyed(Tower tower) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

