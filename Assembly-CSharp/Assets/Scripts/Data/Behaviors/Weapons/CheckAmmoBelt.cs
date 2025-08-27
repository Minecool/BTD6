namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "CheckAmmoBelt", menuName = "BTD6/Behaviors/Weapons/CheckAmmoBelt")]
public class CheckAmmoBelt : WeaponBehavior
{
	public float fireRate; //Field offset: 0x30

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 106
	}

	public CheckAmmoBelt() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

