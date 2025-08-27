namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class FlagshipAttackSpeedIncrease : TowerBehaviorGlobalBuff
{
	public FlagshipAttackSpeedIncrease parent; //Field offset: 0xC8
	public float damageIncrease; //Field offset: 0xD0
	public string expDamageIncrease; //Field offset: 0xD8
	public bool onlyAffectParagon; //Field offset: 0xE0
	public string expOnlyAffectParagon; //Field offset: 0xE8
	public bool dontAffectSelf; //Field offset: 0xF0
	public string expDontAffectSelf; //Field offset: 0xF8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 212
	}

	public FlagshipAttackSpeedIncrease() { }

	public virtual TowerBehaviorModel get_Def() { }

}

