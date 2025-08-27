namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "FlagshipAttackSpeedIncrease", menuName = "BTD6/Behaviors/Towers/FlagshipAttackSpeedIncrease")]
public class FlagshipAttackSpeedIncrease : TowerBehaviorGlobalBuff
{
	public float damageIncrease; //Field offset: 0x40
	public bool onlyAffectParagon; //Field offset: 0x44
	public bool dontAffectSelf; //Field offset: 0x45

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 194
	}

	public FlagshipAttackSpeedIncrease() { }

	public virtual TowerBehaviorModel get_Def() { }

}

