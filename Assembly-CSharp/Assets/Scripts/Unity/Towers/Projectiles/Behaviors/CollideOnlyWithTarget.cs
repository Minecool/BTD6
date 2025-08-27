namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class CollideOnlyWithTarget : ProjectileBehavior
{
	public CollideOnlyWithTarget parent; //Field offset: 0x88
	public bool collideWithFirstIfInvalidTarget; //Field offset: 0x90
	public string expCollideWithFirstIfInvalidTarget; //Field offset: 0x98

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 109
	}

	public CollideOnlyWithTarget() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

