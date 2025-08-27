namespace NinjaKiwi.Common;

public static class LocalizationUtils
{
	[CompilerGenerated]
	private struct <LocalizeTextAndFontAsync>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ILocalizable text; //Field offset: 0x20
		public LocalizationManager locManager; //Field offset: 0x28
		public TMP_Text obj; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const Language kDefaultLanguage = 10; //Field offset: 0x0
	private const string resourcesFolder = "/resources/"; //Field offset: 0x0
	private const char ArabicBaseBlockLow = '\u600'; //Field offset: 0x0
	private const char ArabicBaseBlockHigh = '\u6FF'; //Field offset: 0x0
	private const char ArabicExtendedABlockLow = '\u8A0'; //Field offset: 0x0
	private const char ArabicExtendedABlockHigh = '\u8FF'; //Field offset: 0x0
	private const char ArabicExtendedBBlockLow = '\u870'; //Field offset: 0x0
	private const char ArabicExtendedBBlockHigh = '\u89F'; //Field offset: 0x0
	private const char ArabicPresentationFormsABlockLow = '\uFB50'; //Field offset: 0x0
	private const char ArabicPresentationFormsABlockHigh = '\uFDFF'; //Field offset: 0x0
	private const char ArabicPresentationFormsBBlockLow = '\uFE70'; //Field offset: 0x0
	private const char ArabicPresentationFormsBBlockHigh = '\uFEFF'; //Field offset: 0x0

	public static void EnableDisableFeatures(TMP_Text tmpText, bool enable, OTL_FeatureTag[] features) { }

	public static bool FindCultureInfo(Language language, out CultureInfo cultureInfo) { }

	private static bool IsArabicCharacter(char ch) { }

	public static bool IsCSV(string address) { }

	public static bool IsResourcesLocation(string address) { }

	public static bool IsRTLString(string input) { }

	public static bool IsXML(string text) { }

	public static LocAssetHandle<T> LoadAssetAsync(string address) { }

	private static void LocalizeText(ILocalizable text, ILocProvider locProvider) { }

	[AsyncStateMachine(typeof(<LocalizeTextAndFontAsync>d__2))]
	public static Task LocalizeTextAndFontAsync(ILocalizable text, TMP_Text obj, LocalizationManager locManager) { }

	public static Dictionary<String, String> ReadAsCSV(string text) { }

	public static Dictionary<String, String> ReadAsXML(string text) { }

	public static string ResourcesLocation(string address) { }

	public static string ReverseString(string input) { }

	private static string SanitizeXMLString(string str) { }

	private static void TryAddLocEntry(Dictionary<String, String> table, string key, string value) { }

}

