namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "TargetEliteTargetting", menuName = "BTD6/Behaviors/Attacks/TargetEliteTargetting")]
public class TargetEliteTargetting : TargetTypeBehavior
{
	public float percentageThroughMap; //Field offset: 0x38

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 151
	}

	public TargetEliteTargetting() { }

	public virtual AttackBehaviorModel get_Def() { }

}

