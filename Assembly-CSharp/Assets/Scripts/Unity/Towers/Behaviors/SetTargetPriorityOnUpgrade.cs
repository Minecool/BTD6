namespace Assets.Scripts.Unity.Towers.Behaviors;

public class SetTargetPriorityOnUpgrade : TowerBehavior
{
	public SetTargetPriorityOnUpgrade parent; //Field offset: 0x98
	public int firstPath; //Field offset: 0xA0
	public string expFirstPath; //Field offset: 0xA8
	public int secondPath; //Field offset: 0xB0
	public string expSecondPath; //Field offset: 0xB8
	public int thirdPath; //Field offset: 0xC0
	public string expThirdPath; //Field offset: 0xC8
	public string targetTypeId; //Field offset: 0xD0
	public string expTargetTypeId; //Field offset: 0xD8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 163
	}

	public SetTargetPriorityOnUpgrade() { }

	public virtual TowerBehaviorModel get_Def() { }

}

