namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "TargetWererabbit", menuName = "BTD6/Behaviors/Attacks/TargetWererabbit")]
public class TargetWererabbit : TargetTypeBehavior
{
	public float timeUntilIdle; //Field offset: 0x38

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 148
	}

	public TargetWererabbit() { }

	public virtual AttackBehaviorModel get_Def() { }

}

