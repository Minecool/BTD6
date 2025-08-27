namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "LeakDangerAttackSpeed", menuName = "BTD6/Behaviors/Weapons/LeakDangerAttackSpeed")]
public class LeakDangerAttackSpeed : WeaponBehavior
{
	public float maxRateIncreasePercent; //Field offset: 0x30

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 106
	}

	public LeakDangerAttackSpeed() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

