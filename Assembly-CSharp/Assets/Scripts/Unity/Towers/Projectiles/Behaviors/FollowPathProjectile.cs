namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class FollowPathProjectile : ProjectileBehavior
{
	public FollowPathProjectile parent; //Field offset: 0x88
	public PointSource path; //Field offset: 0x90
	public PointSource expPath; //Field offset: 0x98
	public PointSource easePath; //Field offset: 0xA0
	public PointSource expEasePath; //Field offset: 0xA8
	public float speed; //Field offset: 0xB0
	public string expSpeed; //Field offset: 0xB8
	public string destroyAtEndOfPath; //Field offset: 0xC0
	public string expDestroyAtEndOfPath; //Field offset: 0xC8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 413
	}

	public FollowPathProjectile() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

