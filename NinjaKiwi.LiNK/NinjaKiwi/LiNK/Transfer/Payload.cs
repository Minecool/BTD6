namespace NinjaKiwi.LiNK.Transfer;

[DataContract]
[IsReadOnly]
internal struct Payload
{
	[DataMember(Name = "data")]
	public readonly string data; //Field offset: 0x0
	[DataMember(Name = "auth")]
	public readonly Auth auth; //Field offset: 0x8
	[DataMember(Name = "sig")]
	public readonly string sig; //Field offset: 0x20
	[DataMember(Name = "nonce")]
	public readonly string nonce; //Field offset: 0x28

	public Payload(string data, Auth auth, string sig, string nonce) { }

}

