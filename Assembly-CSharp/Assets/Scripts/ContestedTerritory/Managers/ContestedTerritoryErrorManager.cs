namespace Assets.Scripts.ContestedTerritory.Managers;

public static class ContestedTerritoryErrorManager
{
	private class CtErrorDetails
	{
		public string code; //Field offset: 0x10
		public string debugMessage; //Field offset: 0x18
		public string userSafeMessage; //Field offset: 0x20

		public CtErrorDetails(string code, string debugMessage = "", string userSafeMessage = "") { }

	}

	private static readonly IReadOnlyDictionary<CtError, CtErrorDetails> errorMap; //Field offset: 0x0

	private static LocalizationManager Locs
	{
		private get { } //Length: 48
	}

	private static ContestedTerritoryErrorManager() { }

	private static void CloseContestedTerritory() { }

	private static LocalizationManager get_Locs() { }

	public static void ShowApiError(CtApiActionResult apiError) { }

	public static void ShowError(CtError error) { }

	public static void ShowError(string ctApiError) { }

}

