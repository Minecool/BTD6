namespace NinjaKiwi.LiNK.DataModels;

[DataContract]
public class StorageModel
{
	[DataMember(Name = "success")]
	public bool success; //Field offset: 0x10
	[DataMember(Name = "filename")]
	public string filename; //Field offset: 0x18
	[DataMember(Name = "data")]
	public string data; //Field offset: 0x20
	[DataMember(Name = "url")]
	public string url; //Field offset: 0x28
	[DataMember(Name = "etag")]
	public string etag; //Field offset: 0x30
	[DataMember(Name = "storageOptions")]
	public StorageOptionsModel storageOptions; //Field offset: 0x38

	public StorageModel() { }

}

