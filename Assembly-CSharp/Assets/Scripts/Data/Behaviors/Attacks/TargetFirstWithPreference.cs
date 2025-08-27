namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "TargetFirstWithPreference", menuName = "BTD6/Behaviors/Attacks/TargetFirstWithPreference")]
public class TargetFirstWithPreference : TargetTypeBehavior
{
	public string priorityBloonTags; //Field offset: 0x38

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 151
	}

	public TargetFirstWithPreference() { }

	public virtual AttackBehaviorModel get_Def() { }

}

