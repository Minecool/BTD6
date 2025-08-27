namespace Assets.Scripts.Unity.Towers.Behaviors;

public class AddBehaviorToTowerSupport : SupportBehavior
{
	public AddBehaviorToTowerSupport parent; //Field offset: 0xC8
	public string mutationId; //Field offset: 0xD0
	public string expMutationId; //Field offset: 0xD8
	public TowerBehavior behavior; //Field offset: 0xE0

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 376
	}

	public AddBehaviorToTowerSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

