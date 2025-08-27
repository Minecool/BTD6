namespace Assets.Scripts.Unity.Towers.Behaviors;

public class BananaBonusCashZone : TowerBehavior
{
	public BananaBonusCashZone parent; //Field offset: 0x98
	public float multiplier; //Field offset: 0xA0
	public string expMultiplier; //Field offset: 0xA8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 109
	}

	public BananaBonusCashZone() { }

	public virtual TowerBehaviorModel get_Def() { }

}

