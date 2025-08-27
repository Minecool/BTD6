namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "RotateToDefaultPosition", menuName = "BTD6/Behaviors/Attacks/RotateToDefaultPosition")]
public class RotateToDefaultPosition : AttackBehavior
{
	public float rotation; //Field offset: 0x30

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 106
	}

	public RotateToDefaultPosition() { }

	public virtual AttackBehaviorModel get_Def() { }

}

