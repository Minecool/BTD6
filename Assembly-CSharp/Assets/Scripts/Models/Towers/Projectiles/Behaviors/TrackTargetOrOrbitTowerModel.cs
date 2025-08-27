namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(TrackTargetOrOrbitTower), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TrackTargetOrOrbitTowerModel : ProjectileBehaviorModel
{
	public float maxTargetRange; //Field offset: 0x38
	public float rotation; //Field offset: 0x3C
	public float minimumSpeed; //Field offset: 0x40
	public float maximumSpeed; //Field offset: 0x44
	public float acceleration; //Field offset: 0x48
	public float accelerateInAngle; //Field offset: 0x4C
	public float startDeceleratingIfAngleGreaterThan; //Field offset: 0x50
	public float orbitSpeed; //Field offset: 0x54
	public float orbitDistance; //Field offset: 0x58
	public float orbitTolerance; //Field offset: 0x5C
	public string bloonTagFilter; //Field offset: 0x60
	public int searchDelayFrames; //Field offset: 0x68
	[SerializeField]
	private float searchDelay; //Field offset: 0x6C
	public readonly float minimumSpeedFrames; //Field offset: 0x70
	public readonly float maximumSpeedFrames; //Field offset: 0x74
	public readonly float accelerationFrames; //Field offset: 0x78
	public readonly String[] tagsToIgnore; //Field offset: 0x80

	public float SearchDelay
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public TrackTargetOrOrbitTowerModel(string name, float maxTargetRange, float rotation, float minimumSpeed, float maximumSpeed, float acceleration, float accelerateInAngle, float startDeceleratingIfAngleGreaterThan, float orbitSpeed, float orbitDistance, float orbitTolerance, float searchDelay, string bloonTagFilter) { }

	public virtual Model Clone() { }

	public float get_SearchDelay() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_SearchDelay(float value) { }

}

