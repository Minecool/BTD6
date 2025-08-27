namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "RotateToTarget", menuName = "BTD6/Behaviors/Attacks/RotateToTarget")]
public class RotateToTarget : AttackBehavior
{
	public bool onlyRotateDuringThrow; //Field offset: 0x30
	public bool useThrowMarkerHeight; //Field offset: 0x31
	public bool rotateOnlyOnThrow; //Field offset: 0x32
	public int additionalRotation; //Field offset: 0x34
	public bool dontRotateTower; //Field offset: 0x38
	public bool useMainAttackRotation; //Field offset: 0x39

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 187
	}

	public RotateToTarget() { }

	public virtual AttackBehaviorModel get_Def() { }

}

