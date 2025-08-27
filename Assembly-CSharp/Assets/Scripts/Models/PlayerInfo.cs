namespace Assets.Scripts.Models;

[DataContract]
public class PlayerInfo
{
	[DataMember]
	public readonly string linkId; //Field offset: 0x10
	[DataMember]
	private readonly string displayName; //Field offset: 0x18
	[DataMember]
	private readonly string safeName; //Field offset: 0x20
	[DataMember]
	private readonly bool isArcadePlayer; //Field offset: 0x28
	[DataMember]
	private readonly bool isNetflixPlayer; //Field offset: 0x29
	[DataMember]
	public readonly int rank; //Field offset: 0x2C
	[DataMember]
	public readonly bool isVeteran; //Field offset: 0x30
	[DataMember]
	public string hero; //Field offset: 0x38
	[DataMember]
	public readonly List<String> requestedMods; //Field offset: 0x40
	[DataMember]
	public readonly int medalIndex; //Field offset: 0x48
	[DataMember]
	public readonly int medalCount; //Field offset: 0x4C
	[DataMember]
	public PlayerCosmeticInfo cosmetics; //Field offset: 0x50
	[DataMember]
	public readonly Dictionary<String, String> namedMonkeyNames; //Field offset: 0x58
	[DataMember]
	public readonly bool doubleCash; //Field offset: 0x60
	[DataMember]
	public string banner; //Field offset: 0x68
	[DataMember]
	public String[] availableHeroes; //Field offset: 0x70
	[DataMember]
	public bool initialAutoplaySetting; //Field offset: 0x78
	[DataMember]
	public bool fastTrack; //Field offset: 0x79

	[JsonIgnore]
	public string DisplayName
	{
		 get { } //Length: 137
	}

	[JsonConstructor]
	public PlayerInfo(string linkId, string displayName, string safeName, bool isArcadePlayer, bool isNetflixPlayer, int rank, bool isVeteran, string hero, List<String> requestedMods, int medalIndex, int medalCount, PlayerCosmeticInfo cosmetics, Dictionary<String, String> namedMonkeyNames, bool doubleCash, string banner, String[] availableHeroes, bool initialAutoplaySetting, bool fastTrack) { }

	public PlayerInfo(string hero, Dictionary<String, String> namedMonkeyNames, bool doubleCash, bool fastTrack) { }

	public string get_DisplayName() { }

}

