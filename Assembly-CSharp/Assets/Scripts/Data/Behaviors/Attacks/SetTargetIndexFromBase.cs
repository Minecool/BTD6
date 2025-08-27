namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "SetTargetIndexFromBase", menuName = "BTD6/Behaviors/Attacks/SetTargetIndexFromBase")]
public class SetTargetIndexFromBase : AttackBehavior
{
	public int indexOffset; //Field offset: 0x30

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 104
	}

	public SetTargetIndexFromBase() { }

	public virtual AttackBehaviorModel get_Def() { }

}

