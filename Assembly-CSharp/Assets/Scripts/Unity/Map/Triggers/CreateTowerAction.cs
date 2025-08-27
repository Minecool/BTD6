namespace Assets.Scripts.Unity.Map.Triggers;

public class CreateTowerAction : MapAction
{
	public GameObject preferredReleaseMarker; //Field offset: 0x20
	public GameObject preferredReverseReleaseMarker; //Field offset: 0x28
	public string towerId; //Field offset: 0x30
	public float minDistance; //Field offset: 0x38
	public float maxDistance; //Field offset: 0x3C
	public float pointDistance; //Field offset: 0x40
	public float idealDistanceWithinTrack; //Field offset: 0x44
	public float delay; //Field offset: 0x48
	public bool forceReleaseMarker; //Field offset: 0x4C
	public float rotationY; //Field offset: 0x50
	private CreateTowerActionModel def; //Field offset: 0x58

	public virtual MapActionModel Def
	{
		 get { } //Length: 942
	}

	public CreateTowerAction() { }

	public virtual MapActionModel get_Def() { }

}

