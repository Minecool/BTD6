namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class HideAttackDisplayIfPaused : AttackBehavior
{
	public HideAttackDisplayIfPaused parent; //Field offset: 0x88
	public int animationStateOnReveal; //Field offset: 0x90
	public string expAnimationStateOnReveal; //Field offset: 0x98

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 107
	}

	public HideAttackDisplayIfPaused() { }

	public virtual AttackBehaviorModel get_Def() { }

}

