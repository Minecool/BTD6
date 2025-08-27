namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "TargetFriendly", menuName = "BTD6/Behaviors/Attacks/TargetFriendly")]
public class TargetFriendly : TargetTypeBehavior
{
	public string ignoreList; //Field offset: 0x38
	public string mutationId; //Field offset: 0x40
	public bool mustHaveWeapon; //Field offset: 0x48

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 176
	}

	public TargetFriendly() { }

	public virtual AttackBehaviorModel get_Def() { }

}

