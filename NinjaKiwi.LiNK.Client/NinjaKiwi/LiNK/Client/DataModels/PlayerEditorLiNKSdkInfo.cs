namespace NinjaKiwi.LiNK.Client.DataModels;

[DataContract]
public class PlayerEditorLiNKSdkInfo
{
	[DataMember]
	public Parameters parameters; //Field offset: 0x10
	[DataMember]
	public string version; //Field offset: 0x20
	[DataMember]
	public string saveFileName; //Field offset: 0x28
	[DataMember]
	public string storagePath; //Field offset: 0x30
	[DataMember]
	public Strategy storageStrategy; //Field offset: 0x38
	[DataMember]
	public string identityStorageOverride; //Field offset: 0x40
	[DataMember]
	public string dataStorageOverride; //Field offset: 0x48

	public PlayerEditorLiNKSdkInfo() { }

}

