namespace NinjaKiwi.LiNK.MatchMaking;

[DataContract]
public class MatchMakingRule
{
	[DataMember(Name = "parameter")]
	public readonly string parameterName; //Field offset: 0x10
	[DataMember(Name = "excludedValues")]
	public readonly List<String> mustNotMatch; //Field offset: 0x18
	[DataMember(Name = "allowedValues")]
	public readonly List<String> mustMatch; //Field offset: 0x20

	internal MatchMakingRule(string parameterName, List<String> mustMatch = null, List<String> mustNotMatch = null) { }

}

