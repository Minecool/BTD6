namespace Assets.Scripts.Unity.Towers.Behaviors;

public class CentralMarketBuff : TowerBehaviorBuff
{
	public CentralMarketBuff parent; //Field offset: 0xB8
	public float multiplier; //Field offset: 0xC0
	public string expMultiplier; //Field offset: 0xC8
	public string mutatorId; //Field offset: 0xD0
	public string expMutatorId; //Field offset: 0xD8
	public int maxStackCount; //Field offset: 0xE0
	public string expMaxStackCount; //Field offset: 0xE8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 190
	}

	public CentralMarketBuff() { }

	public virtual TowerBehaviorModel get_Def() { }

}

