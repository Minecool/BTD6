namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "RoundBasedAttackSpeed", menuName = "BTD6/Behaviors/Towers/RoundBasedAttackSpeed")]
public class RoundBasedAttackSpeed : TowerBehavior
{
	public float maxWeaponAttackSpeed; //Field offset: 0x30
	public float bonusAttackSpeedPerRoundPercent; //Field offset: 0x34

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 130
	}

	public RoundBasedAttackSpeed() { }

	public virtual TowerBehaviorModel get_Def() { }

}

