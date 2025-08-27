namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(CreateTowerActionSimBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateTowerActionSimBehaviorModel : SimulationBehaviorModel
{
	public float releaseOriginX; //Field offset: 0x30
	public float releaseOriginY; //Field offset: 0x34
	public float reverseReleaseOriginX; //Field offset: 0x38
	public float reverseReleaseOriginY; //Field offset: 0x3C
	public string towerId; //Field offset: 0x40
	public float minDistance; //Field offset: 0x48
	public float maxDistance; //Field offset: 0x4C
	public float pointDistance; //Field offset: 0x50
	public float idealDistanceWithinTrack; //Field offset: 0x54
	public bool forceReleaseMarker; //Field offset: 0x58
	public float rotationY; //Field offset: 0x5C
	[SerializeField]
	private float delay; //Field offset: 0x60
	public int delayFrames; //Field offset: 0x64

	public CreateTowerActionSimBehaviorModel(string name, float releaseOriginX, float releaseOriginY, float reverseReleaseOriginX, float reverseReleaseOriginY, string towerId, float minDistance, float maxDistance, float pointDistance, float idealDistanceWithinTrack, float delay, bool forceReleaseMarker, float rotationY) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

