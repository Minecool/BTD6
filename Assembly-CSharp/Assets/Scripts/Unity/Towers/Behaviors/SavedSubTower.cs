namespace Assets.Scripts.Unity.Towers.Behaviors;

public class SavedSubTower : TowerBehavior
{
	public SavedSubTower parent; //Field offset: 0x98

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public SavedSubTower() { }

	public virtual TowerBehaviorModel get_Def() { }

}

