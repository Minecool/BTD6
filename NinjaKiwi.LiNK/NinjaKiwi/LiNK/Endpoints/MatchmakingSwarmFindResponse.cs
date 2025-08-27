namespace NinjaKiwi.LiNK.Endpoints;

[DataContract]
public class MatchmakingSwarmFindResponse
{
	[DataMember(Name = "success")]
	public bool success; //Field offset: 0x10
	[DataMember(Name = "swarm")]
	public SwarmModel swarm; //Field offset: 0x18
	[DataMember(Name = "playerLocalID")]
	public int playerLocalID; //Field offset: 0x20

	public MatchmakingSwarmFindResponse() { }

}

