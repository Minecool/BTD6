namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "TrackTargetWithinTime", menuName = "BTD6/Behaviors/Projectiles/TrackTargetWithinTime")]
public class TrackTargetWithinTime : TrackTarget
{
	public float time; //Field offset: 0x48

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 275
	}

	public TrackTargetWithinTime() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

