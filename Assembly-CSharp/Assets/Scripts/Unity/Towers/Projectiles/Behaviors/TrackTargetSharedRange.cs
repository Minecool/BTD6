namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class TrackTargetSharedRange : ProjectileBehavior
{
	public bool sharedRangeEnabled; //Field offset: 0x88
	public string expSharedRangeEnabled; //Field offset: 0x90
	public float turnRate; //Field offset: 0x98
	public string expTurnRate; //Field offset: 0xA0
	public float reaquireTargetDelay; //Field offset: 0xA8
	public string expReaquireTargetDelay; //Field offset: 0xB0

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 160
	}

	public TrackTargetSharedRange() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

