namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class HeroXpInjection : SimulationBehavior
{
	public HeroXpInjectionModel heroXpInjectionModel; //Field offset: 0x58

	public HeroXpInjection() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTowerCreated(Tower tower, TowerModel def, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

