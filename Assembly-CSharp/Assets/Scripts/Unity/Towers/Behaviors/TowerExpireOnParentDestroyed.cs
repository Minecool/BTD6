namespace Assets.Scripts.Unity.Towers.Behaviors;

public class TowerExpireOnParentDestroyed : TowerBehavior
{
	public TowerExpireOnParentDestroyed parent; //Field offset: 0x98

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public TowerExpireOnParentDestroyed() { }

	public virtual TowerBehaviorModel get_Def() { }

}

