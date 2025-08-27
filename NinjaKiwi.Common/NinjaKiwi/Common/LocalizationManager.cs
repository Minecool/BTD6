namespace NinjaKiwi.Common;

[CreateAssetMenu(menuName = "Ninja Kiwi/Localization/Manager")]
public class LocalizationManager : ScriptableObjectSingleton<LocalizationManager>, ILocProvider
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public string prefix; //Field offset: 0x10

		public <>c__DisplayClass35_0() { }

		internal bool <GetKeysWithPrefix>b__0(string k) { }

		internal bool <GetKeysWithPrefix>b__1(string k) { }

	}

	[CompilerGenerated]
	private struct <LoadAsync>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalizationManager <>4__this; //Field offset: 0x20
		public Language language; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadLanguageAsync>d__59 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalizationManager <>4__this; //Field offset: 0x20
		public Language language; //Field offset: 0x28
		private TaskAwaiter<Dictionary`2<String, String>> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadTableAsync>d__58 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Dictionary`2<String, String>> <>t__builder; //Field offset: 0x8
		public LocalizationManager <>4__this; //Field offset: 0x20
		public Language language; //Field offset: 0x28
		private Dictionary<String, String> <table>5__2; //Field offset: 0x30
		private LocAssetHandle<TextAsset> <assetHandle>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateAllTextObjectsForLanguageAsync>d__61 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalizationManager <>4__this; //Field offset: 0x20
		private TMP_Text[] <>7__wrap1; //Field offset: 0x28
		private int <>7__wrap2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateLanguageAsync>d__60 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalizationManager <>4__this; //Field offset: 0x20
		public Language language; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateTextObjectFontAsync>d__63 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TMP_Text textObj; //Field offset: 0x20
		public LocalizationManager <>4__this; //Field offset: 0x28
		private TMP_FontAsset <font>5__2; //Field offset: 0x30
		private Material <material>5__3; //Field offset: 0x38
		private bool <usesFontMaterial>5__4; //Field offset: 0x40
		private LocAssetHandle<TMP_FontAsset> <assetHandle>5__5; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateTextObjectFontMaterialAsync>d__64 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalizationManager <>4__this; //Field offset: 0x20
		public string materialAddress; //Field offset: 0x28
		public TMP_Text textObj; //Field offset: 0x30
		private LocAssetHandle<Material> <assetHandle>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private class TextReplacer
	{
		public string replace; //Field offset: 0x10
		public string with; //Field offset: 0x18

		public TextReplacer() { }

	}

	private const string kLogTag = "<color=#99FFA7>[LocManager]</color>"; //Field offset: 0x0
	private const string fFmt = "N2"; //Field offset: 0x0
	private const string iFmt = "N0"; //Field offset: 0x0
	private const string kPrefKey = "Language"; //Field offset: 0x0
	private const string dFmt = "m"; //Field offset: 0x0
	private const string pFmt = "P0"; //Field offset: 0x0
	[CompilerGenerated]
	private bool <DebugLocalization>k__BackingField; //Field offset: 0x18
	private Dictionary<String, String> textTable; //Field offset: 0x20
	private Dictionary<String, String> defaultTable; //Field offset: 0x28
	private List<TextReplacer> textReplacers; //Field offset: 0x30
	private Dictionary<String, LocAssetHandle`1<TMP_FontAsset>> fontRefCache; //Field offset: 0x38
	private Dictionary<String, LocAssetHandle`1<Material>> materialRefCache; //Field offset: 0x40
	public bool AutoFormatNumbers; //Field offset: 0x48
	[SerializableDictionary]
	[SerializeField]
	public LanguageDict supportedLanguages; //Field offset: 0x50
	[CompilerGenerated]
	private Language <ActiveLanguage>k__BackingField; //Field offset: 0x58
	private CultureInfo cultureInfo; //Field offset: 0x60
	[CompilerGenerated]
	private Action OnLanguageChanged; //Field offset: 0x68

	public event Action OnLanguageChanged
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public private override Language ActiveLanguage
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public Language CachedLanguage
	{
		 get { } //Length: 146
		 set { } //Length: 156
	}

	public bool DebugLocalization
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public ICollection<Language> SupportedLanguages
	{
		 get { } //Length: 61
	}

	public LocalizationManager() { }

	[CompilerGenerated]
	public void add_OnLanguageChanged(Action value) { }

	public Language CachedLanguageOrDefault() { }

	public override bool ContainsKey(string key) { }

	public override bool ContainsKeyEnglish(string key) { }

	public string FontAssetName(Language language, string assetName, string extension) { }

	public override string Format(string key, Object[] args) { }

	private string FormatDate(DateTime value, CultureInfo culture, string format = "m") { }

	public string FormatDate(DateTime value, string format = "m") { }

	private string FormatDouble(double value, CultureInfo culture, string format = "N2") { }

	public string FormatDouble(double value, string format = "N2") { }

	public override string FormatEnglish(string key, Object[] args) { }

	private string FormatFloat(float value, CultureInfo culture, string format = "N2") { }

	public string FormatFloat(float value, string format = "N2") { }

	private string FormatInt(int value, CultureInfo culture, string format = "N0") { }

	public string FormatInt(int value, string format = "N0") { }

	private string FormatInternal(string formatStr, Object[] args) { }

	private string FormatLong(long value, CultureInfo culture, string format = "N0") { }

	public string FormatLong(long value, string format = "N0") { }

	public string FormatPercent(float value, string format = "P0") { }

	[CompilerGenerated]
	public override Language get_ActiveLanguage() { }

	public Language get_CachedLanguage() { }

	[CompilerGenerated]
	public bool get_DebugLocalization() { }

	public ICollection<Language> get_SupportedLanguages() { }

	public IEnumerable<String> GetKeysWithPrefix(string prefix) { }

	public override string GetText(string key) { }

	public override string GetTextEnglish(string key) { }

	public void Initialise(bool debug = false) { }

	public void InstallTextReplacer(string replace, string with) { }

	public bool IsSupported(Language language) { }

	[AsyncStateMachine(typeof(<LoadAsync>d__29))]
	public Task LoadAsync(Language language = -1) { }

	[AsyncStateMachine(typeof(<LoadLanguageAsync>d__59))]
	private Task LoadLanguageAsync(Language language) { }

	[AsyncStateMachine(typeof(<LoadTableAsync>d__58))]
	private Task<Dictionary`2<String, String>> LoadTableAsync(Language language) { }

	[CompilerGenerated]
	public void remove_OnLanguageChanged(Action value) { }

	private void Reset() { }

	[CompilerGenerated]
	private void set_ActiveLanguage(Language value) { }

	public void set_CachedLanguage(Language value) { }

	[CompilerGenerated]
	public void set_DebugLocalization(bool value) { }

	private Object[] TransformArgs(Object[] args, CultureInfo culture) { }

	public bool TryGetLanguageResource(Language language, out LanguageResource resource) { }

	[AsyncStateMachine(typeof(<UpdateAllTextObjectsForLanguageAsync>d__61))]
	private Task UpdateAllTextObjectsForLanguageAsync(Language language) { }

	[AsyncStateMachine(typeof(<UpdateLanguageAsync>d__60))]
	public Task UpdateLanguageAsync(Language language) { }

	[AsyncStateMachine(typeof(<UpdateTextObjectFontAsync>d__63))]
	public Task UpdateTextObjectFontAsync(TMP_Text textObj) { }

	[AsyncStateMachine(typeof(<UpdateTextObjectFontMaterialAsync>d__64))]
	public Task UpdateTextObjectFontMaterialAsync(TMP_Text textObj, string materialAddress) { }

}

