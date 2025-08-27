namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(LinkProjectileRadiusToTowerRange), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class LinkProjectileRadiusToTowerRangeModel : TowerBehaviorModel
{
	public ProjectileModel projectileModel; //Field offset: 0x30
	public float baseTowerRange; //Field offset: 0x38
	public float projectileRadiusOffset; //Field offset: 0x3C
	public float displayRadius; //Field offset: 0x40

	public LinkProjectileRadiusToTowerRangeModel(string name, ProjectileModel projectileModel, float baseTowerRange, float projectileRadiusOffset, float displayRadius) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

