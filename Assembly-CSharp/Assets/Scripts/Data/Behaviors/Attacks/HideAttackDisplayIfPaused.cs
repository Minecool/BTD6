namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "HideAttackDisplayIfPaused", menuName = "BTD6/Behaviors/Attacks/HideAttackDisplayIfPaused")]
public class HideAttackDisplayIfPaused : AttackBehavior
{
	public int animationStateOnReveal; //Field offset: 0x30

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 104
	}

	public HideAttackDisplayIfPaused() { }

	public virtual AttackBehaviorModel get_Def() { }

}

