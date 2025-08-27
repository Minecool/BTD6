namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(AlternateProjectile), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AlternateProjectileModel : WeaponBehaviorModel
{
	public ProjectileModel projectile; //Field offset: 0x30
	public EmissionModel emissionModel; //Field offset: 0x38
	public int interval; //Field offset: 0x40
	public int alternateAnimation; //Field offset: 0x44

	public AlternateProjectileModel(string name, ProjectileModel projectile, EmissionModel emissionModel, int interval, int alternateAnimation = -1) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

