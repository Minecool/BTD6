namespace Assets.Scripts.Unity.Towers.Behaviors;

public class AcidicMixtureCheck : TowerBehavior
{
	public AcidicMixtureCheck parent; //Field offset: 0x98
	public int maxCount; //Field offset: 0xA0
	public string expMaxCount; //Field offset: 0xA8
	public string mutationId; //Field offset: 0xB0
	public string expMutationId; //Field offset: 0xB8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 133
	}

	public AcidicMixtureCheck() { }

	public virtual TowerBehaviorModel get_Def() { }

}

