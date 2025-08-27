namespace NinjaKiwi.GUTS.Models.ContentBrowser;

[Flags]
public enum AvailabilityScoreComponent
{
	ReplayValidationStatus = 1,
	TextValidationStatus = 2,
	ImageValidationStatus = 4,
	AdminPassed = 8,
}

