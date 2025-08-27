namespace NinjaKiwi.GUTS.Models.ContentBrowser;

public class PlayerContentStats : IEquatable<PlayerContentStats>
{
	public int plays; //Field offset: 0x10
	public int playsUnique; //Field offset: 0x14
	public int wins; //Field offset: 0x18
	public int winsUnique; //Field offset: 0x1C
	public int losses; //Field offset: 0x20
	public int lossesUnique; //Field offset: 0x24
	public int upvotes; //Field offset: 0x28
	public int restarts; //Field offset: 0x2C
	public string firstWin; //Field offset: 0x30
	public string latestWin; //Field offset: 0x38

	public PlayerContentStats() { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(PlayerContentStats other) { }

	public virtual int GetHashCode() { }

}

