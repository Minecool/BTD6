namespace NinjaKiwi.LiNK.Client.Caching;

[DataContract]
public class DataAndEtag
{
	[DataMember(Name = "Data")]
	public Byte[] data; //Field offset: 0x10
	[DataMember(Name = "Etag")]
	public string etag; //Field offset: 0x18

	public DataAndEtag() { }

}

