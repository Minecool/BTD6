namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class CreateTypedTowerCurrentIndex : WeaponCreateTower
{
	public CreateTypedTowerCurrentIndexModel createTypedTowerCurrentIndexModel; //Field offset: 0x70

	public CreateTypedTowerCurrentIndex() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual TowerModel GetTowerModel() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

