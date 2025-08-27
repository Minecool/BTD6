namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "TravelTowardsEmitTower", menuName = "BTD6/Behaviors/Projectiles/TravelTowardsEmitTower")]
public class TravelTowardsEmitTower : ProjectileBehavior
{
	public bool lockRotation; //Field offset: 0x30
	public float speed; //Field offset: 0x34
	public float range; //Field offset: 0x38
	public bool delayedActivation; //Field offset: 0x3C

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 172
	}

	public TravelTowardsEmitTower() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

