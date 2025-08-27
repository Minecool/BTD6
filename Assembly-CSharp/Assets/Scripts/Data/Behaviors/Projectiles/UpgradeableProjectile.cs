namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "UpgradeableProjectile", menuName = "BTD6/Behaviors/Projectiles/UpgradeableProjectile")]
public class UpgradeableProjectile : ProjectileBehavior
{
	public float cost; //Field offset: 0x30

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 115
	}

	public UpgradeableProjectile() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

