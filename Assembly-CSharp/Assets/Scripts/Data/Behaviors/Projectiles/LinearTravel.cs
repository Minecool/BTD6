namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "LinearTravel", menuName = "BTD6/Behaviors/Projectiles/LinearTravel")]
public class LinearTravel : ProjectileBehavior
{
	public float speed; //Field offset: 0x30
	public float lifespan; //Field offset: 0x34
	public bool dontDestroyOnTargetLoss; //Field offset: 0x38
	public bool forceCollisionOnSnap; //Field offset: 0x39

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 170
	}

	public LinearTravel() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

