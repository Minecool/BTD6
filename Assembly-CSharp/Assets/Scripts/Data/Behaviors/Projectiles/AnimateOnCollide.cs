namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "AnimateOnCollide", menuName = "BTD6/Behaviors/Projectiles/AnimateOnCollide")]
public class AnimateOnCollide : ProjectileBehavior
{
	public int animationState; //Field offset: 0x30

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 104
	}

	public AnimateOnCollide() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

