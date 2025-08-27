namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(CreateTower), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateTowerModel : ProjectileBehaviorModel
{
	public TowerModel tower; //Field offset: 0x38
	public float height; //Field offset: 0x40
	public bool positionAtTarget; //Field offset: 0x44
	public bool destroySubTowersOnCreateNewTower; //Field offset: 0x45
	public bool useProjectileRotation; //Field offset: 0x46
	public bool useParentTargetPriority; //Field offset: 0x47
	public bool carryMutatorsFromDestroyedTower; //Field offset: 0x48

	public CreateTowerModel(string name, TowerModel tower, float height, bool positionAtTarget, bool destroySubTowersOnCreateNewTower, bool useProjectileRotation, bool useParentTargetPriority, bool carryMutatorsFromDestroyedTower) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

