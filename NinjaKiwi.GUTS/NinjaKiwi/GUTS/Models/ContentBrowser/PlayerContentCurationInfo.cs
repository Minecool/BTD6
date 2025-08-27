namespace NinjaKiwi.GUTS.Models.ContentBrowser;

public class PlayerContentCurationInfo : PlayerContentInfo, IComparable<PlayerContentCurationInfo>, IComparer<PlayerContentCurationInfo>
{
	public List<ReportInfo> reports; //Field offset: 0x90
	[JsonConverter(typeof(UnixDateTimeConverter))]
	[JsonProperty("createdAt")]
	public DateTime creationTime; //Field offset: 0x98

	[JsonIgnore]
	public int ReportsCount
	{
		 get { } //Length: 64
	}

	public PlayerContentCurationInfo() { }

	public override int Compare(PlayerContentCurationInfo x, PlayerContentCurationInfo y) { }

	public override int CompareTo(PlayerContentCurationInfo other) { }

	public int get_ReportsCount() { }

}

