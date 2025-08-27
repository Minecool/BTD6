namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class AnimateOnBeastHandler : AttackBehavior
{
	public AnimateOnBeastHandler parent; //Field offset: 0x88
	public int animationStateMinParent; //Field offset: 0x90
	public string expAnimationStateMinParent; //Field offset: 0x98
	public int animationStateMaxParent; //Field offset: 0xA0
	public string expAnimationStateMaxParent; //Field offset: 0xA8
	public int animationStateMinContributor; //Field offset: 0xB0
	public string expAnimationStateMinContributor; //Field offset: 0xB8
	public int animationStateMaxContributor; //Field offset: 0xC0
	public string expAnimationStateMaxContributor; //Field offset: 0xC8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 161
	}

	public AnimateOnBeastHandler() { }

	public virtual AttackBehaviorModel get_Def() { }

}

