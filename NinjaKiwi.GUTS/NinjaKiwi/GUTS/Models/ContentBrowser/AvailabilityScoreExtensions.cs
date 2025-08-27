namespace NinjaKiwi.GUTS.Models.ContentBrowser;

[Extension]
public static class AvailabilityScoreExtensions
{

	[Extension]
	public static AdminPassStatus GetAdminPassStatus(ref AvailabilityScore availabilityScore) { }

	[Extension]
	public static ValidationStatus GetImageValidationStatus(ref AvailabilityScore availabilityScore) { }

	public static int GetMinimumRawScoreWithAdminPass() { }

	public static int GetMinimumRawScoreWithAutomatedCurationPass() { }

	[Extension]
	public static ValidationStatus GetReplayValidationStatus(ref AvailabilityScore availabilityScore) { }

	[Extension]
	public static ValidationStatus GetTextValidationStatus(ref AvailabilityScore availabilityScore) { }

	[Extension]
	public static void SetAdminPassStatus(ref AvailabilityScore availabilityScore, AdminPassStatus adminPassStatus) { }

	[Extension]
	public static void SetImageValidationStatus(ref AvailabilityScore availabilityScore, ValidationStatus validationStatus) { }

	[Extension]
	public static void SetReplayValidationStatus(ref AvailabilityScore availabilityScore, ValidationStatus validationStatus) { }

	[Extension]
	public static void SetTextValidationStatus(ref AvailabilityScore availabilityScore, ValidationStatus validationStatus) { }

}

