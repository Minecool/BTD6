namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class AnimateOnCollide : ProjectileBehavior
{
	public AnimateOnCollide parent; //Field offset: 0x88
	public int animationState; //Field offset: 0x90

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 107
	}

	public AnimateOnCollide() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

