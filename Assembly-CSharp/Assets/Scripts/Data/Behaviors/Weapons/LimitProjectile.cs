namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "LimitProjectile", menuName = "BTD6/Behaviors/Weapons/LimitProjectile")]
public class LimitProjectile : WeaponBehavior
{
	public Projectile projectile; //Field offset: 0x30
	public int limit; //Field offset: 0x38
	public float delay; //Field offset: 0x3C
	public bool limitByDestroyedPriorProjectile; //Field offset: 0x40
	public bool globalForPlayer; //Field offset: 0x41

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 242
	}

	public LimitProjectile() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

