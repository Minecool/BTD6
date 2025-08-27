namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class IgnoreInsufficientPierce : ProjectileBehavior
{
	public IgnoreInsufficientPierce parent; //Field offset: 0x88

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public IgnoreInsufficientPierce() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

