namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "PowerProjectile", menuName = "BTD6/Behaviors/Projectiles/PowerProjectile")]
public class PowerProjectile : ProjectileBehavior
{

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public PowerProjectile() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

