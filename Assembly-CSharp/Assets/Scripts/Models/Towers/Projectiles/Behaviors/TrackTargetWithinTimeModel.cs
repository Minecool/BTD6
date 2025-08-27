namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(TrackTargetWithinTime), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TrackTargetWithinTimeModel : TrackTargetModel
{
	public float timeInFrames; //Field offset: 0x50

	public TrackTargetWithinTimeModel(string name, float distance, bool trackNewTargets, bool onlyAquireNewTargetIfInvalid, float maxSeekAngle, bool ignoreSeekAngle, float turnRate, bool overrideRotation, float timeInFrames, bool useLifetimeAsDistance) { }

	public virtual Model Clone() { }

}

