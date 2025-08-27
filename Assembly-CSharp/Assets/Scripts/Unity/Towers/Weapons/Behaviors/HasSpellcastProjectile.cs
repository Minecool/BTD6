namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class HasSpellcastProjectile : WeaponBehavior
{
	private HasSpellcastProjectileModel def; //Field offset: 0x90
	public Projectile projectile; //Field offset: 0x98

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 128
	}

	public HasSpellcastProjectile() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

