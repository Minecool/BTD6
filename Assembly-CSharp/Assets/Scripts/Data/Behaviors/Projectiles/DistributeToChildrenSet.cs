namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "DistributeToChildrenSet", menuName = "BTD6/Behaviors/Projectiles/DistributeToChildrenSet")]
public class DistributeToChildrenSet : ProjectileBehavior
{
	public int layers; //Field offset: 0x30

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 113
	}

	public DistributeToChildrenSet() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

