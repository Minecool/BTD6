namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "RotateToTargetAttackOffset", menuName = "BTD6/Behaviors/Attacks/RotateToTargetAttackOffset")]
public class RotateToTargetAttackOffset : RotateToTarget
{
	public float ignoreParentRotationTime; //Field offset: 0x40
	public float startRotation; //Field offset: 0x44
	public bool alwaysIgnoreParentRotation; //Field offset: 0x48

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 260
	}

	public RotateToTargetAttackOffset() { }

	public virtual AttackBehaviorModel get_Def() { }

}

