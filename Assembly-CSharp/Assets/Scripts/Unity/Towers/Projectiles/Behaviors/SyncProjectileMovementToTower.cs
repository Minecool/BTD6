namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class SyncProjectileMovementToTower : ProjectileBehavior
{
	private SyncProjectileMovementToTowerModel def; //Field offset: 0x88

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 138
	}

	public SyncProjectileMovementToTower() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

