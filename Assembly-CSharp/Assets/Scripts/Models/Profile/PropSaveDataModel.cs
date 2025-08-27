namespace Assets.Scripts.Models.Profile;

public class PropSaveDataModel
{
	public string uniqueId; //Field offset: 0x10
	public ObjectId IdLastSave; //Field offset: 0x18
	public bool isDisabled; //Field offset: 0x1C
	public int createdAt; //Field offset: 0x20
	public Dictionary<String, String> metaData; //Field offset: 0x28

	public PropSaveDataModel() { }

	public bool HasValidSaveData() { }

}

