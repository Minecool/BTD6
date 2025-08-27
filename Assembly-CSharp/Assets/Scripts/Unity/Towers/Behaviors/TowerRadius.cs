namespace Assets.Scripts.Unity.Towers.Behaviors;

public class TowerRadius : TowerBehavior
{
	public Bank parent; //Field offset: 0x98

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public TowerRadius() { }

	public virtual TowerBehaviorModel get_Def() { }

}

