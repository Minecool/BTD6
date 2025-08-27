namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class ClearHitBloonsWhenNoLongerColliding : ProjectileBehavior
{
	public ClearHitBloonsWhenNoLongerColliding parent; //Field offset: 0x88
	public float interval; //Field offset: 0x90
	public string expInterval; //Field offset: 0x98

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 109
	}

	public ClearHitBloonsWhenNoLongerColliding() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

