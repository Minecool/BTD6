namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "AnimateOnBeastHandler", menuName = "BTD6/Behaviors/Attacks/AnimateOnBeastHandler")]
public class AnimateOnBeastHandler : AttackBehavior
{
	public int animationStateMinParent; //Field offset: 0x30
	public int animationStateMaxParent; //Field offset: 0x34
	public int animationStateMinContributor; //Field offset: 0x38
	public int animationStateMaxContributor; //Field offset: 0x3C

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 149
	}

	public AnimateOnBeastHandler() { }

	public virtual AttackBehaviorModel get_Def() { }

}

