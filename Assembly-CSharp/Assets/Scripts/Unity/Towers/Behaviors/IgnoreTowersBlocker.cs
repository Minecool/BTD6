namespace Assets.Scripts.Unity.Towers.Behaviors;

public class IgnoreTowersBlocker : TowerBehavior
{
	public IgnoreTowersBlocker parent; //Field offset: 0x98
	public string whitelistedTowers; //Field offset: 0xA0
	public string expWhitelistedTowers; //Field offset: 0xA8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 162
	}

	public IgnoreTowersBlocker() { }

	public virtual TowerBehaviorModel get_Def() { }

}

