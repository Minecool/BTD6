namespace Assets.Scripts.Models.Map.Actions;

[Implementation(typeof(CreateTowerAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateTowerActionModel : MapActionModel
{
	public float releaseOriginX; //Field offset: 0x38
	public float releaseOriginY; //Field offset: 0x3C
	public float reverseReleaseOriginX; //Field offset: 0x40
	public float reverseReleaseOriginY; //Field offset: 0x44
	public string towerId; //Field offset: 0x48
	public float minDistance; //Field offset: 0x50
	public float maxDistance; //Field offset: 0x54
	public float pointDistance; //Field offset: 0x58
	public float idealDistanceWithinTrack; //Field offset: 0x5C
	public float delay; //Field offset: 0x60
	public bool forceReleaseMarker; //Field offset: 0x64
	public float rotationY; //Field offset: 0x68

	public CreateTowerActionModel(string name, float releaseOriginX, float releaseOriginY, float reverseReleaseOriginX, float reverseReleaseOriginY, string towerId, float minDistance, float maxDistance, float pointDistance, float idealDistanceWithinTrack, float delay, bool forceReleaseMarker, float rotationY) { }

}

