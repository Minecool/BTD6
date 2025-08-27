namespace Assets.Scripts.Unity.Towers.Behaviors;

public class MonkeyCity : TowerBehavior
{
	public MonkeyCity parent; //Field offset: 0x98
	public int roundsTillMultiplier; //Field offset: 0xA0
	public string expRoundsTillMultiplier; //Field offset: 0xA8
	public string towerId; //Field offset: 0xB0
	public string expTowerId; //Field offset: 0xB8
	public float multiplier; //Field offset: 0xC0
	public string expMultiplier; //Field offset: 0xC8
	public string mutatorId; //Field offset: 0xD0
	public string expMutatorId; //Field offset: 0xD8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 181
	}

	public MonkeyCity() { }

	public virtual TowerBehaviorModel get_Def() { }

}

