namespace NinjaKiwi.GUTS.Models.ContentBrowser;

public class PlayerContentInfo
{
	public string id; //Field offset: 0x10
	public string owner; //Field offset: 0x18
	[JsonProperty("challengeName")]
	public string contentName; //Field offset: 0x20
	public string map; //Field offset: 0x28
	public int gameVersionNumber; //Field offset: 0x30
	public string gameVersion; //Field offset: 0x38
	public int latestVersionBeaten; //Field offset: 0x40
	public PlayerContentStats stats; //Field offset: 0x48
	public bool pageFile; //Field offset: 0x50
	public bool isUnlosable; //Field offset: 0x51
	public bool isUnwinable; //Field offset: 0x52
	public bool isDeleted; //Field offset: 0x53
	public PlayerContentProperties properties; //Field offset: 0x58
	public ContentType contentType; //Field offset: 0x60
	public int odysseyDifficulty; //Field offset: 0x64
	public bool isArcadePlayer; //Field offset: 0x68
	public bool isNetflixPlayer; //Field offset: 0x69
	public AvailabilityScore availabilityScore; //Field offset: 0x6C
	public HashSet<CurationVote> curations; //Field offset: 0x70
	public int validationCount; //Field offset: 0x78
	public int rejectionCount; //Field offset: 0x7C
	public Dictionary<String, Int64> rawAccolades; //Field offset: 0x80
	[JsonProperty(NullValueHandling = NullValueHandling::Ignore (1))]
	public Dictionary<String, String> topContributors; //Field offset: 0x88

	public PlayerContentInfo() { }

}

