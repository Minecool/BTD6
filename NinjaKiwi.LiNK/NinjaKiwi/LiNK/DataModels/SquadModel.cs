namespace NinjaKiwi.LiNK.DataModels;

[DataContract]
public class SquadModel
{
	[DataContract]
	internal class SquadSwarmMessageModel : PubSubMessageModel
	{
		private const string KEY_TYPE = "type"; //Field offset: 0x0
		private const string KEY_SWARM = "swarm"; //Field offset: 0x0
		private const string TYPE_JOIN = "joinSwarm"; //Field offset: 0x0
		public string squadMessageType; //Field offset: 0x50
		[CompilerGenerated]
		private SwarmModel <Swarm>k__BackingField; //Field offset: 0x58

		public virtual JObject SetMessageDataDuringDeserialising
		{
			 set { } //Length: 480
		}

		public SwarmModel Swarm
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 5
		}

		public SquadSwarmMessageModel() { }

		[CompilerGenerated]
		public SwarmModel get_Swarm() { }

		public virtual void set_SetMessageDataDuringDeserialising(JObject value) { }

		[CompilerGenerated]
		protected void set_Swarm(SwarmModel value) { }

	}

	[DataMember(Name = "partyID")]
	public string ID; //Field offset: 0x10
	[DataMember(Name = "host")]
	public string hostID; //Field offset: 0x18
	[DataMember(Name = "matchmakingParameters")]
	public SquadMatchmakingParameters matchmakingParameters; //Field offset: 0x20
	[DataMember(Name = "partyStatus")]
	public string squadStatus; //Field offset: 0x28
	[DataMember(Name = "partyType")]
	public string squadType; //Field offset: 0x30
	[DataMember(Name = "players")]
	public String[] memberIDs; //Field offset: 0x38
	[DataMember(Name = "matchID")]
	public string matchID; //Field offset: 0x40
	[DataMember(Name = "relayUUID")]
	public string relayUuid; //Field offset: 0x48
	[DataMember(Name = "relay")]
	public RelayModel relay; //Field offset: 0x50
	[DataMember(Name = "playerSlots")]
	public Dictionary<String, Int32> playerSlots; //Field offset: 0x58
	[DataMember(Name = "events")]
	public SquadSwarmMessageModel[] events; //Field offset: 0x60

	public SquadModel() { }

	[OnDeserialized]
	internal void OnDeserialised(StreamingContext streamingContext) { }

}

