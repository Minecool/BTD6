namespace Assets.Scripts.Models.Profile;

public class BloonSaveDataModel
{
	public string modelId; //Field offset: 0x10
	public double hp; //Field offset: 0x18
	public int emissionIndex; //Field offset: 0x20
	public int spawnRound; //Field offset: 0x24
	public string pathId; //Field offset: 0x28
	public float distanceTraveled; //Field offset: 0x30
	public int lowestLayerNumber; //Field offset: 0x34
	public Dictionary<String, String> metaData; //Field offset: 0x38
	public string cosmeticId; //Field offset: 0x40
	public ObjectId idLastSave; //Field offset: 0x48
	public bool disallowCosmetics; //Field offset: 0x4C

	public BloonSaveDataModel() { }

}

