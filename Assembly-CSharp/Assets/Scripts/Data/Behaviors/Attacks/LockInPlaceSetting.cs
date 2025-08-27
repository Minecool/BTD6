namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "LockInPlaceSetting", menuName = "BTD6/Behaviors/Attacks/LockInPlaceSetting")]
public class LockInPlaceSetting : TargetTypeBehavior
{
	public PrefabReference display; //Field offset: 0x38

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 151
	}

	public LockInPlaceSetting() { }

	public virtual AttackBehaviorModel get_Def() { }

}

