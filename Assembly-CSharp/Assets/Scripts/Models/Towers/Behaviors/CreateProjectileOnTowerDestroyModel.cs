namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(CreateProjectileOnTowerDestroy), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateProjectileOnTowerDestroyModel : TowerBehaviorModel
{
	[ExtendedDrawer]
	[SerializeReference]
	public ProjectileModel projectileModel; //Field offset: 0x30
	[ExtendedDrawer]
	[SerializeReference]
	public EmissionModel emissionModel; //Field offset: 0x38
	public bool useTowerRotation; //Field offset: 0x40
	public bool setAgeZeroOnSell; //Field offset: 0x41
	public bool ignoreSubTowers; //Field offset: 0x42

	public CreateProjectileOnTowerDestroyModel(string name, ProjectileModel projectileModel, EmissionModel emissionModel, bool useTowerRotation, bool setAgeZeroOnSell, bool ignoreSubTowers) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

