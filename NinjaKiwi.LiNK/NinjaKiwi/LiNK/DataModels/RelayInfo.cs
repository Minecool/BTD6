namespace NinjaKiwi.LiNK.DataModels;

[DataContract]
public class RelayInfo
{
	public RelayDetails Details; //Field offset: 0x10
	[DataMember(Name = "relay_server_ip")]
	public string ip; //Field offset: 0x18
	[DataMember(Name = "relay_server_port")]
	public int port; //Field offset: 0x20
	[DataMember(Name = "relay_server_protocol")]
	public string protocol; //Field offset: 0x28

	public RelayInfo() { }

}

