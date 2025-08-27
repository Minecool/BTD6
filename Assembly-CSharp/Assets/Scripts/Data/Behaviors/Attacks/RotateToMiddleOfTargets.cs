namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "RotateToMiddleOfTargets", menuName = "BTD6/Behaviors/Attacks/RotateToMiddleOfTargets")]
public class RotateToMiddleOfTargets : AttackBehavior
{
	public bool onlyRotateDuringThrow; //Field offset: 0x30

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 106
	}

	public RotateToMiddleOfTargets() { }

	public virtual AttackBehaviorModel get_Def() { }

}

