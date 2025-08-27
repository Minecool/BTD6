namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class CashPerBananaFarmInRange : AbilityBehavior
{
	public CashPerBananaFarmInRange parent; //Field offset: 0x88
	public float baseCash; //Field offset: 0x90
	public string expBaseCash; //Field offset: 0x98
	public float cash; //Field offset: 0xA0
	public string expCash; //Field offset: 0xA8
	public float rangeIncrease; //Field offset: 0xB0
	public string expRangeIncrease; //Field offset: 0xB8
	public GameObject textDisplay; //Field offset: 0xC0
	public GameObject expTextDisplay; //Field offset: 0xC8
	public float textLifespan; //Field offset: 0xD0
	public string expTextLifespan; //Field offset: 0xD8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 1101
	}

	public CashPerBananaFarmInRange() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

