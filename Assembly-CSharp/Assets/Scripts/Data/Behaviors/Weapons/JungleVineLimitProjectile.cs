namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "JungleVineLimitProjectile", menuName = "BTD6/Behaviors/Weapons/JungleVineLimitProjectile")]
public class JungleVineLimitProjectile : WeaponBehavior
{
	public int limit; //Field offset: 0x30
	public float delay; //Field offset: 0x34

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 138
	}

	public JungleVineLimitProjectile() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

