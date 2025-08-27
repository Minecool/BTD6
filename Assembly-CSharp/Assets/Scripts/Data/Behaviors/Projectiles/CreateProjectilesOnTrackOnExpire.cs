namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "CreateProjectilesOnTrackOnExpire", menuName = "BTD6/Behaviors/Projectiles/CreateProjectilesOnTrackOnExpire")]
public class CreateProjectilesOnTrackOnExpire : ProjectileBehavior
{
	public Projectile projectile; //Field offset: 0x30
	public Emission emission; //Field offset: 0x38
	public bool useRotation; //Field offset: 0x40
	public int count; //Field offset: 0x44
	public float range; //Field offset: 0x48

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 254
	}

	public CreateProjectilesOnTrackOnExpire() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

