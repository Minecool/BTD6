namespace Assets.Scripts.Unity.Towers.Behaviors;

public class Hero : TowerBehavior
{
	public Hero parent; //Field offset: 0x98
	public float xpScale; //Field offset: 0xA0
	public string expXpScale; //Field offset: 0xA8
	public float costPerXpToLevel; //Field offset: 0xB0
	public string expCostPerXpToLevel; //Field offset: 0xB8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 136
	}

	public Hero() { }

	public virtual TowerBehaviorModel get_Def() { }

}

