namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class ProjectileHeight : ProjectileBehavior
{
	public ProjectileHeight parent; //Field offset: 0x88
	public PointSource height; //Field offset: 0x90
	public PointSource expHeight; //Field offset: 0x98

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 201
	}

	public ProjectileHeight() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

