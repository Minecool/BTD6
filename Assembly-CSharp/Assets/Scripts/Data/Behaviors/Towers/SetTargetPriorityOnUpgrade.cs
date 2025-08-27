namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "SetTargetPriorityOnUpgrade", menuName = "BTD6/Behaviors/Towers/SetTargetPriorityOnUpgrade")]
public class SetTargetPriorityOnUpgrade : TowerBehavior
{
	public int firstPath; //Field offset: 0x30
	public int secondPath; //Field offset: 0x34
	public int thirdPath; //Field offset: 0x38
	public string targetTypeId; //Field offset: 0x40

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 151
	}

	public SetTargetPriorityOnUpgrade() { }

	public virtual TowerBehaviorModel get_Def() { }

}

