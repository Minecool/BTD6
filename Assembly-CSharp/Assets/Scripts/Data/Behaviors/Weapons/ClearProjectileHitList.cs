namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "ClearProjectileHitList", menuName = "BTD6/Behaviors/Weapons/ClearProjectileHitList")]
public class ClearProjectileHitList : WeaponBehavior
{
	public float rate; //Field offset: 0x30

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 106
	}

	public ClearProjectileHitList() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

