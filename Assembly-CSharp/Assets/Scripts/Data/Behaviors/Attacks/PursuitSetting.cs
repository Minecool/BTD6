namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "PursuitSetting", menuName = "BTD6/Behaviors/Attacks/PursuitSetting")]
public class PursuitSetting : TargetTypeBehavior
{
	public float pursuitDistance; //Field offset: 0x38

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 148
	}

	public PursuitSetting() { }

	public virtual AttackBehaviorModel get_Def() { }

}

