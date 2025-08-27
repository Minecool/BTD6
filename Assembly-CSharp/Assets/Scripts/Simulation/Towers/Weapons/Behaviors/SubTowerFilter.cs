namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class SubTowerFilter : WeaponBehavior
{
	public SubTowerFilterModel subTowerFilterModel; //Field offset: 0x68
	public readonly List<Tower> createdSubTowers; //Field offset: 0x70
	public readonly List<Projectile> createdProjectiles; //Field offset: 0x78

	public SubTowerFilter() { }

	public virtual void Attatched() { }

	public virtual bool FilterEmission() { }

	public int GetCurrentCount() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void OnTowerCreated(Tower createdTower, TowerModel def, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	public void OnTowerDestroyed(Tower tower) { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

