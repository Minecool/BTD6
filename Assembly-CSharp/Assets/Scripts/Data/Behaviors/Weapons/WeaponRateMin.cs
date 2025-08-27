namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "WeaponRateMin", menuName = "BTD6/Behaviors/Weapons/WeaponRateMin")]
public class WeaponRateMin : WeaponBehavior
{
	public float min; //Field offset: 0x30

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 106
	}

	public WeaponRateMin() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

