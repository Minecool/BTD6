namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "TargetTag", menuName = "BTD6/Behaviors/Attacks/TargetTag")]
public class TargetTag : TargetTypeBehavior
{
	public string tagValue; //Field offset: 0x38
	public bool findStrongest; //Field offset: 0x40

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 154
	}

	public TargetTag() { }

	public virtual AttackBehaviorModel get_Def() { }

}

