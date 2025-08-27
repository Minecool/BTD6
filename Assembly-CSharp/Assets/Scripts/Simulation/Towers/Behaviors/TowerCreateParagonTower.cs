namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class TowerCreateParagonTower : TowerBehavior
{
	public TowerCreateParagonTowerModel behaviourModel; //Field offset: 0x68
	private bool towerAdded; //Field offset: 0x70
	private ParagonTower paragonTower; //Field offset: 0x78

	public TowerCreateParagonTower() { }

	private TowerModel GetParagonTowerModelTier() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void OnTowerCreated(Tower createdTower, TowerModel def, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

