namespace Assets.Scripts.Unity.Towers.Behaviors;

public class SupportStackCounter : SupportBehavior
{
	public SupportStackCounter parent; //Field offset: 0xC8
	public string mutatorId; //Field offset: 0xD0
	public string expMutatorId; //Field offset: 0xD8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 275
	}

	public SupportStackCounter() { }

	public virtual TowerBehaviorModel get_Def() { }

}

