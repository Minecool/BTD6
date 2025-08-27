namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class TrackTargetWithinTime : TrackTarget
{
	public float time; //Field offset: 0x110
	public string expTime; //Field offset: 0x118

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 302
	}

	public TrackTargetWithinTime() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

