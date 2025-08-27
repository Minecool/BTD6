namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "HasSpellcastProjectile", menuName = "BTD6/Behaviors/Weapons/HasSpellcastProjectile")]
public class HasSpellcastProjectile : WeaponBehavior
{
	public Projectile projectile; //Field offset: 0x30

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 137
	}

	public HasSpellcastProjectile() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

