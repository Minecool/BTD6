namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "DestroyIfTargetLost", menuName = "BTD6/Behaviors/Projectiles/DestroyIfTargetLost")]
public class DestroyIfTargetLost : ProjectileBehavior
{

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public DestroyIfTargetLost() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

