namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class ChallengeBrowserSearchPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<DateTimeOffset> <>9__42_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal DateTimeOffset <GetDefaultSearchValues>b__42_0() { }

	}

	public Button clickOutsidePanelCloserBtn; //Field offset: 0x20
	public Toggle includeOldVersionsTog; //Field offset: 0x28
	public Toggle last24HoursTog; //Field offset: 0x30
	public Toggle lastWeekTog; //Field offset: 0x38
	public Toggle lastMonthTog; //Field offset: 0x40
	public Toggle allTimeTog; //Field offset: 0x48
	public Toggle hideCompletedTog; //Field offset: 0x50
	public NK_TextMeshProUGUI minRoundsTitle; //Field offset: 0x58
	public Slider minRoundsSlider; //Field offset: 0x60
	public Button minRoundsLeftBtn; //Field offset: 0x68
	public Button minRoundsRightBtn; //Field offset: 0x70
	public NK_TextMeshProUGUI maxRoundsTitle; //Field offset: 0x78
	public Slider maxRoundsSlider; //Field offset: 0x80
	public Button maxRoundsLeftBtn; //Field offset: 0x88
	public Button maxRoundsRightBtn; //Field offset: 0x90
	public Action OnApplySearchOptions; //Field offset: 0x98
	private bool requiresRefresh; //Field offset: 0xA0
	private bool isInitialized; //Field offset: 0xA1
	private ContentType currentContentType; //Field offset: 0xA2

	private ContentBrowserSettings ChallengeBrowserSettings
	{
		private get { } //Length: 150
	}

	public bool HideCompleted
	{
		 get { } //Length: 30
	}

	private string MaxRoundsLocKey
	{
		private get { } //Length: 77
	}

	private string MinRoundsLocKey
	{
		private get { } //Length: 77
	}

	private ContentType SelectedTab
	{
		private get { } //Length: 81
	}

	public ChallengeBrowserSearchPanel() { }

	[CompilerGenerated]
	private void <Start>b__23_0() { }

	[CompilerGenerated]
	private void <Start>b__23_1() { }

	[CompilerGenerated]
	private void <Start>b__23_2() { }

	[CompilerGenerated]
	private void <Start>b__23_3() { }

	private ContentBrowserSettings get_ChallengeBrowserSettings() { }

	public bool get_HideCompleted() { }

	private string get_MaxRoundsLocKey() { }

	private string get_MinRoundsLocKey() { }

	private ContentType get_SelectedTab() { }

	public static AdvancedSearchValues GetDefaultSearchValues(ContentType contentType) { }

	private TabSettings GetSelectionSettings(SelectionType selectionType) { }

	public void Hide() { }

	public void Initialize() { }

	public void InitializeWithValues(AdvancedSearchValues previousValues, ContentType contentType) { }

	private void MaxRoundsChanged(float value) { }

	private void MinRoundsChanged(float value) { }

	public void SetDefaults(SelectionType selectionType, ContentType contentType) { }

	private void SetMaxRoundsText(float value) { }

	private void SetMinRoundsText(float value) { }

	private void SetRefresh(bool _) { }

	public void Show() { }

	private void Start() { }

	public AdvancedSearchValues ToValues(ContentType contentType) { }

}

