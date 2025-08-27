namespace Assets.Scripts.Unity.Towers.Behaviors;

public class TowerExpireOnParentUpgraded : TowerBehavior
{
	public TowerExpireOnParentDestroyed parent; //Field offset: 0x98

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 268
	}

	public TowerExpireOnParentUpgraded() { }

	public virtual TowerBehaviorModel get_Def() { }

}

