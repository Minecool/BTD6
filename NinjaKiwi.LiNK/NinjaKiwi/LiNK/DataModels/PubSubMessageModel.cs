namespace NinjaKiwi.LiNK.DataModels;

[DataContract]
public class PubSubMessageModel
{
	[DataMember(Name = "id")]
	public string id; //Field offset: 0x10
	[DataMember(Name = "sender")]
	public string sender; //Field offset: 0x18
	[DataMember(Name = "createdAt")]
	[JsonConverter(typeof(UnixEpochToDateTimeConverter))]
	public DateTime createdAt; //Field offset: 0x20
	[DataMember(Name = "expiresAt")]
	[JsonConverter(typeof(UnixEpochToDateTimeConverter))]
	public DateTime expiresAt; //Field offset: 0x28
	[DataMember(Name = "expiresIn")]
	[JsonConverter(typeof(MillisecondsToTimeSpanConverter))]
	public TimeSpan expiresIn; //Field offset: 0x30
	[DataMember(Name = "isPublic")]
	public bool isPublic; //Field offset: 0x38
	[DataMember(Name = "type")]
	public int type; //Field offset: 0x3C
	[CompilerGenerated]
	private string <Payload>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private JObject <MessageData>k__BackingField; //Field offset: 0x48

	public JObject MessageData
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public string Payload
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[DataMember(Name = "messageData")]
	public JObject RawMessageData
	{
		 set { } //Length: 173
	}

	public PubSubMessageModel() { }

	[CompilerGenerated]
	public JObject get_MessageData() { }

	[CompilerGenerated]
	public string get_Payload() { }

	[CompilerGenerated]
	protected void set_MessageData(JObject value) { }

	[CompilerGenerated]
	protected void set_Payload(string value) { }

	public void set_RawMessageData(JObject value) { }

}

