namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class SubTowerFilter : WeaponBehavior
{
	public SubTowerFilterModel subTowerFilterModel; //Field offset: 0x68
	public List<Tower> createdSubTowers; //Field offset: 0x70

	public SubTowerFilter() { }

	public virtual void Attatched() { }

	public virtual bool FilterEmission() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void OnTowerCreated(Tower createdTower, TowerModel def, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	public void OnTowerDestroyed(Tower tower) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

