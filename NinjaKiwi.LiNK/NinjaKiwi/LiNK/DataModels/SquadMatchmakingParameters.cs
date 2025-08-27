namespace NinjaKiwi.LiNK.DataModels;

[DataContract]
public class SquadMatchmakingParameters
{
	[DataMember(Name = "metadata")]
	public readonly JObject metadata; //Field offset: 0x10
	[DataMember(Name = "additionalData")]
	public readonly JObject additionalData; //Field offset: 0x18
	[DataMember(Name = "countryCode")]
	public readonly string countryCode; //Field offset: 0x20

	[JsonConstructor]
	internal SquadMatchmakingParameters() { }

	public SquadMatchmakingParameters(string matchmakingVersion) { }

}

