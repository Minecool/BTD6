namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(HasSpellcastProjectile), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class HasSpellcastProjectileModel : WeaponBehaviorModel
{
	public ProjectileModel projectile; //Field offset: 0x30

	public HasSpellcastProjectileModel(string name, ProjectileModel projectile) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

