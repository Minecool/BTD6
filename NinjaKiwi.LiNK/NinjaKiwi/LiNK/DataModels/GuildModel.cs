namespace NinjaKiwi.LiNK.DataModels;

[DataContract]
public class GuildModel
{
	[DataMember]
	public string guildID; //Field offset: 0x10
	[DataMember]
	public string shortcode; //Field offset: 0x18
	[DataMember]
	public string name; //Field offset: 0x20
	[DataMember]
	public string owner; //Field offset: 0x28
	[DataMember]
	public int numMembers; //Field offset: 0x30
	[DataMember]
	public int numMembersPending; //Field offset: 0x34
	[DataMember]
	public bool full; //Field offset: 0x38
	[DataMember]
	public int maximumMembers; //Field offset: 0x3C
	[DataMember]
	public string tagline; //Field offset: 0x40
	[DataMember]
	public long lastUpdated; //Field offset: 0x48
	[DataMember]
	public int activityRating; //Field offset: 0x50
	[DataMember]
	public string safeName; //Field offset: 0x58
	public GuildStatus status; //Field offset: 0x60

	public bool CanAutoJoin
	{
		 get { } //Length: 8
	}

	public bool CanJoin
	{
		 get { } //Length: 8
	}

	public bool IsActive
	{
		 get { } //Length: 8
	}

	[DataMember(Name = "statusInfo")]
	internal JObject RawStatus
	{
		internal set { } //Length: 130
	}

	public GuildModel() { }

	public bool get_CanAutoJoin() { }

	public bool get_CanJoin() { }

	public bool get_IsActive() { }

	internal void set_RawStatus(JObject value) { }

}

