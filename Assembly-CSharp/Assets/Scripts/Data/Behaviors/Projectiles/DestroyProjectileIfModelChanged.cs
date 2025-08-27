namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "DestroyProjectileIfModelChanged", menuName = "BTD6/Behaviors/Projectiles/DestroyProjectileIfModelChanged")]
public class DestroyProjectileIfModelChanged : ProjectileBehavior
{

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 97
	}

	public DestroyProjectileIfModelChanged() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

