namespace NinjaKiwi.LiNK.Transfer;

[DataContract]
internal class Response
{
	[DataMember(Name = "error")]
	public InvalidRequestException error; //Field offset: 0x10
	[DataMember(Name = "sig")]
	public string sig; //Field offset: 0x18
	[DataMember(Name = "data")]
	public string data; //Field offset: 0x20

	public Response() { }

}

