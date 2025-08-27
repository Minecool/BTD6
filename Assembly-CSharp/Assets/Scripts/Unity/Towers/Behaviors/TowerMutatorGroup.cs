namespace Assets.Scripts.Unity.Towers.Behaviors;

public class TowerMutatorGroup : TowerBehavior
{
	public TowerMutatorGroup parent; //Field offset: 0x98

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 158
	}

	public TowerMutatorGroup() { }

	public virtual TowerBehaviorModel get_Def() { }

}

