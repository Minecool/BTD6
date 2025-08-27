namespace NinjaKiwi.LiNK.DataModels;

[DataContract]
public class StorageMetadataModel
{
	[DataMember(Name = "deviceID")]
	public string deviceID; //Field offset: 0x10

	public StorageMetadataModel() { }

}

