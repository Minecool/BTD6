namespace Assets.Scripts.Unity.Towers.Behaviors;

public class IgnoreTower : TowerBehavior
{
	public IgnoreTower parent; //Field offset: 0x98
	public string ignoreId; //Field offset: 0xA0
	public string expIgnoreId; //Field offset: 0xA8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 108
	}

	public IgnoreTower() { }

	public virtual TowerBehaviorModel get_Def() { }

}

