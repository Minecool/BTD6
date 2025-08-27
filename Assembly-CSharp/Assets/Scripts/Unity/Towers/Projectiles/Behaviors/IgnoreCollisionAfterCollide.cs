namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class IgnoreCollisionAfterCollide : ProjectileBehavior
{
	public IgnoreCollisionAfterCollide parent; //Field offset: 0x88
	public float timeAfterCollide; //Field offset: 0x90
	public string expTimeAfterCollide; //Field offset: 0x98

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 139
	}

	public IgnoreCollisionAfterCollide() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

