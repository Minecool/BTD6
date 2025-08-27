namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class ProjectileZeroRotation : ProjectileBehavior
{
	public RefreshPierce parent; //Field offset: 0x88

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public ProjectileZeroRotation() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

