namespace NinjaKiwi.GUTS.Models.ContentBrowser;

[Flags]
public enum RejectionReason
{
	OffensiveGraphics = 1,
	OffensiveLanguage = 2,
	OffensiveAreas = 4,
	IDontLikeIt = 8,
	TooEasy = 16,
	TooDifficult = 32,
	OffensiveInteractable = 64,
}

