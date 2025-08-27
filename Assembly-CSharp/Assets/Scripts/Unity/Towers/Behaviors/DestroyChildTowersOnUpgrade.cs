namespace Assets.Scripts.Unity.Towers.Behaviors;

public class DestroyChildTowersOnUpgrade : TowerBehavior
{
	public DestroyChildTowersOnUpgrade parent; //Field offset: 0x98
	public string towerId; //Field offset: 0xA0
	public string expTowerId; //Field offset: 0xA8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 108
	}

	public DestroyChildTowersOnUpgrade() { }

	public virtual TowerBehaviorModel get_Def() { }

}

