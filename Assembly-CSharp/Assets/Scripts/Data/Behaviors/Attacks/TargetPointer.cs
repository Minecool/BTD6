namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "TargetPointer", menuName = "BTD6/Behaviors/Attacks/TargetPointer")]
public class TargetPointer : TargetTypeBehavior
{
	public string customName; //Field offset: 0x38
	public bool setOnAttached; //Field offset: 0x40

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 156
	}

	public TargetPointer() { }

	public virtual AttackBehaviorModel get_Def() { }

}

