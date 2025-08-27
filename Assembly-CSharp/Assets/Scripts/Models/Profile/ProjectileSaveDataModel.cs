namespace Assets.Scripts.Models.Profile;

public class ProjectileSaveDataModel
{
	public float pierce; //Field offset: 0x10
	public string baseId; //Field offset: 0x18
	public Vector3 position; //Field offset: 0x20
	public float rotation; //Field offset: 0x2C
	public Dictionary<String, String> metaData; //Field offset: 0x30
	public int owner; //Field offset: 0x38
	public ObjectId emittedByTowerId; //Field offset: 0x3C
	public Vector3 emittedFrom; //Field offset: 0x40
	public bool isPowerProjectile; //Field offset: 0x4C
	public string powerId; //Field offset: 0x50
	public int createdAt; //Field offset: 0x58

	public ProjectileSaveDataModel() { }

}

