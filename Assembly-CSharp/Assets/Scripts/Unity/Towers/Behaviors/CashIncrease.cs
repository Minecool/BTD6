namespace Assets.Scripts.Unity.Towers.Behaviors;

public class CashIncrease : TowerBehavior
{
	public CashIncrease parent; //Field offset: 0x98
	public float increase; //Field offset: 0xA0
	public string expIncrease; //Field offset: 0xA8
	public float multiplier; //Field offset: 0xB0
	public string expMultiplier; //Field offset: 0xB8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 136
	}

	public CashIncrease() { }

	public virtual TowerBehaviorModel get_Def() { }

}

