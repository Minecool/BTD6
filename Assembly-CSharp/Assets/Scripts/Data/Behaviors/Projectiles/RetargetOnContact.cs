namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "RetargetOnContact", menuName = "BTD6/Behaviors/Projectiles/RetargetOnContact")]
public class RetargetOnContact : ProjectileBehavior
{
	public float distance; //Field offset: 0x30
	public float minDistance; //Field offset: 0x34
	public int maxBounces; //Field offset: 0x38
	public string targetType; //Field offset: 0x40
	public float delay; //Field offset: 0x48
	public bool expireIfNoTargetFound; //Field offset: 0x4C

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 212
	}

	public RetargetOnContact() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

