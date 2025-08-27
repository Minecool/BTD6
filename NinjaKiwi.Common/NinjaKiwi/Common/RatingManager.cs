namespace NinjaKiwi.Common;

public class RatingManager
{
	private RatingPromptSettings ratingSettings; //Field offset: 0x10
	private RatingStatTracking ratingStats; //Field offset: 0x18

	public RatingManager() { }

	public bool GetIsAllowedToPrompt() { }

	public void IncreaseSignificantEventCount(int increment) { }

	public void SetNeverPromptAgain(bool neverAgain) { }

	public void Setup(RatingPromptSettings ratingSettings, RatingStatTracking playerRatingStats) { }

	public void UserPrompted() { }

}

