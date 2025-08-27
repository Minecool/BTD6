namespace NinjaKiwi.LiNK.Transfer;

[DataContract]
[IsReadOnly]
internal struct Auth
{
	[DataMember(Name = "session")]
	public readonly string session; //Field offset: 0x0
	[DataMember(Name = "appID")]
	public readonly int appID; //Field offset: 0x8
	[DataMember(Name = "skuID")]
	public readonly int skuID; //Field offset: 0xC
	[DataMember(Name = "device")]
	public readonly string deviceID; //Field offset: 0x10

	public Auth(string session, int appID, int skuID, string deviceID) { }

}

