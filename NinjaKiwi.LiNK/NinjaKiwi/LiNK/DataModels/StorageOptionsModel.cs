namespace NinjaKiwi.LiNK.DataModels;

[DataContract]
public class StorageOptionsModel
{
	[DataMember(Name = "metadata")]
	public string metadata; //Field offset: 0x10
	[DataMember(Name = "isPublic")]
	public bool isPublic; //Field offset: 0x18
	[DataMember(Name = "compress")]
	public bool compress; //Field offset: 0x19
	[DataMember(Name = "decode")]
	public bool decode; //Field offset: 0x1A
	[DataMember(Name = "reducedRedundancy")]
	public bool reducedRedundancy; //Field offset: 0x1B
	[DataMember(Name = "stephen")]
	public bool stephen; //Field offset: 0x1C
	[DataMember(Name = "expiresIn")]
	public long expiresIn; //Field offset: 0x20
	[DataMember(Name = "render")]
	public string render; //Field offset: 0x28
	[DataMember(Name = "contentType")]
	public string contentType; //Field offset: 0x30

	public StorageOptionsModel() { }

}

