namespace NinjaKiwi.LiNK.DataModels;

[DataContract]
public class SessionModel
{
	[DataMember(Name = "sessionID", EmitDefaultValue = False)]
	public string sessionID; //Field offset: 0x10
	[DataMember(Name = "encryptedSessionID", EmitDefaultValue = False)]
	public string encryptedSessionID; //Field offset: 0x18
	[DataMember(Name = "expires")]
	public long expires; //Field offset: 0x20

	public SessionModel() { }

	[OnDeserialized]
	internal void OnDeserialized(StreamingContext context) { }

}

