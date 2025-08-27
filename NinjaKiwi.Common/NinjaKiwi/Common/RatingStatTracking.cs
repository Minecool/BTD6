namespace NinjaKiwi.Common;

public class RatingStatTracking
{
	public int significantEventCount; //Field offset: 0x10
	public int appUseCount; //Field offset: 0x14
	public DateTime ratingPromptLastSeenTime; //Field offset: 0x18
	public int promptCount; //Field offset: 0x20
	public string ratingLastPromptVersion; //Field offset: 0x28
	public bool neverPromptAgain; //Field offset: 0x30

	public RatingStatTracking() { }

}

