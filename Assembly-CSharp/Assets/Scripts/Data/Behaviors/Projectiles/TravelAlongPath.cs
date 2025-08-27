namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "TravelAlongPath", menuName = "BTD6/Behaviors/Projectiles/TravelAlongPath")]
public class TravelAlongPath : ProjectileBehavior
{
	public float range; //Field offset: 0x30
	public float speed; //Field offset: 0x34
	public bool reverse; //Field offset: 0x38
	public bool disableRotateWithPathDirection; //Field offset: 0x39
	public float rotationLerp; //Field offset: 0x3C

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 197
	}

	public TravelAlongPath() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

