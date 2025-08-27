namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class RoundBasedAttackSpeed : TowerBehavior
{
	public RoundBasedAttackSpeed parent; //Field offset: 0x98
	public float maxWeaponAttackSpeed; //Field offset: 0xA0
	public string expMaxWeaponAttackSpeed; //Field offset: 0xA8
	public float bonusAttackSpeedPerRoundPercent; //Field offset: 0xB0
	public string expBonusAttackSpeedPerRoundPercent; //Field offset: 0xB8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 136
	}

	public RoundBasedAttackSpeed() { }

	public virtual TowerBehaviorModel get_Def() { }

}

