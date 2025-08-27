namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(TowerCreateProjectileOnCrit), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TowerCreateProjectileOnCritModel : TowerBehaviorModel
{
	public ProjectileModel projectileModel; //Field offset: 0x30
	public EmissionModel emissionModel; //Field offset: 0x38
	public float chance; //Field offset: 0x40

	public TowerCreateProjectileOnCritModel(string name, ProjectileModel projectileModel, EmissionModel emissionModel, float chance) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

