namespace Assets.Scripts.Unity.Towers.Behaviors;

public class BonusCashZone : TowerBehavior
{
	public BonusCashZone parent; //Field offset: 0x98
	public float multiplier; //Field offset: 0xA0
	public string expMultiplier; //Field offset: 0xA8
	public int stackLimit; //Field offset: 0xB0
	public string expStackLimit; //Field offset: 0xB8
	public string stackName; //Field offset: 0xC0
	public string expStackName; //Field offset: 0xC8
	public string groupName; //Field offset: 0xD0
	public string expGroupName; //Field offset: 0xD8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 179
	}

	public BonusCashZone() { }

	public virtual TowerBehaviorModel get_Def() { }

}

