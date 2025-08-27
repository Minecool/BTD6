namespace Assets.Scripts.Unity.Towers.Behaviors;

public class RemoveMutatorOnUpgrade : TowerBehavior
{
	public RemoveMutatorOnUpgrade parent; //Field offset: 0x98
	public string mutatorId; //Field offset: 0xA0
	public string expMutatorId; //Field offset: 0xA8
	public int firstPath; //Field offset: 0xB0
	public string expFirstPath; //Field offset: 0xB8
	public int secondPath; //Field offset: 0xC0
	public string expSecondPath; //Field offset: 0xC8
	public int thirdPath; //Field offset: 0xD0
	public string expThirdPath; //Field offset: 0xD8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 161
	}

	public RemoveMutatorOnUpgrade() { }

	public virtual TowerBehaviorModel get_Def() { }

}

