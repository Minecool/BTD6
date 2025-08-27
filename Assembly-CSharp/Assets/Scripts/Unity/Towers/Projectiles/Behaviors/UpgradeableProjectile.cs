namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class UpgradeableProjectile : ProjectileBehavior
{
	public float cost; //Field offset: 0x88

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 118
	}

	public UpgradeableProjectile() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

