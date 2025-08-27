namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "AlternateProjectile", menuName = "BTD6/Behaviors/Weapons/AlternateProjectile")]
public class AlternateProjectile : WeaponBehavior
{
	public Projectile projectile; //Field offset: 0x30
	public Emission alternateEmission; //Field offset: 0x38
	public int interval; //Field offset: 0x40
	public int alternateAnimation; //Field offset: 0x44

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 289
	}

	public AlternateProjectile() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

