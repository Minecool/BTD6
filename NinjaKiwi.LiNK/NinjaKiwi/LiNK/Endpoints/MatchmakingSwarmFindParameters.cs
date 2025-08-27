namespace NinjaKiwi.LiNK.Endpoints;

[DataContract]
public class MatchmakingSwarmFindParameters
{
	[DataMember(Name = "mmv")]
	public String[] matchmakingVersions; //Field offset: 0x10
	[DataMember(Name = "gameMode")]
	public string gameMode; //Field offset: 0x18
	[DataMember(Name = "scaleRule", EmitDefaultValue = False)]
	public SwarmScaleRule scaleRule; //Field offset: 0x20
	[DataMember(Name = "preferredSwarm", EmitDefaultValue = False)]
	public String[] preferredSwarm; //Field offset: 0x28

	public MatchmakingSwarmFindParameters() { }

}

