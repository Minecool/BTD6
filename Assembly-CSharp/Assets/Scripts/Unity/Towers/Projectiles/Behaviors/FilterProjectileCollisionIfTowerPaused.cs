namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class FilterProjectileCollisionIfTowerPaused : ProjectileBehavior
{
	public FilterProjectileCollisionIfTowerPaused parent; //Field offset: 0x88

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public FilterProjectileCollisionIfTowerPaused() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

