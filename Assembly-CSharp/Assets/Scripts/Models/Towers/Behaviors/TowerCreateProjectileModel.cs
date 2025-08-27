namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(TowerCreateProjectile), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TowerCreateProjectileModel : TowerBehaviorModel
{
	public ProjectileModel projectileModel; //Field offset: 0x30
	public EmissionModel emissionModel; //Field offset: 0x38
	public float interval; //Field offset: 0x40
	public int intervalFrames; //Field offset: 0x44
	public bool useRoundTime; //Field offset: 0x48
	public float chance; //Field offset: 0x4C

	public TowerCreateProjectileModel(string name, ProjectileModel projectileModel, EmissionModel emissionModel, float interval, bool useRoundTime, float chance) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

