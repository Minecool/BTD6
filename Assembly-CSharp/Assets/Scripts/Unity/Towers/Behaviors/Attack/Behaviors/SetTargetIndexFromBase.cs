namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class SetTargetIndexFromBase : AttackBehavior
{
	public SetTargetIndexFromBase parent; //Field offset: 0x88
	public int indexOffset; //Field offset: 0x90
	public string expIndexOffset; //Field offset: 0x98

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 107
	}

	public SetTargetIndexFromBase() { }

	public virtual AttackBehaviorModel get_Def() { }

}

