namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class ContentBrowserDisplayInfo : ICloneable
{
	private ContentBrowserQuery query; //Field offset: 0x10
	[CompilerGenerated]
	private ElasticQueryOptions <Options>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Hint>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <Page>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private int <TotalPages>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private int <MaxPagesToDisplay>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private SelectionType <SelectionType>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private WinRateDisplayType <WinRateDisplayType>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private IEnumerable<String> <PlayerContentIds>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private AdvancedSearchValues <AdvancedSearchValues>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private int <PanelsPerPage>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private bool <CanShowDeletedContent>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	private bool <IsCurationBrowser>k__BackingField; //Field offset: 0x55
	[CompilerGenerated]
	private string <CurationSearchValue>k__BackingField; //Field offset: 0x58

	public private AdvancedSearchValues AdvancedSearchValues
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private bool CanShowDeletedContent
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private string CurationSearchValue
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private string Hint
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public bool IsCurationBrowser
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool IsValid
	{
		 get { } //Length: 22
	}

	public private int MaxPagesToDisplay
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private ElasticQueryOptions Options
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private int Page
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int PanelsPerPage
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private IEnumerable<String> PlayerContentIds
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public ContentBrowserQuery Query
	{
		 get { } //Length: 376
	}

	public int QueryOffset
	{
		 get { } //Length: 20
	}

	public SelectionType SelectionType
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private int TotalPages
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private WinRateDisplayType WinRateDisplayType
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public ContentBrowserDisplayInfo() { }

	public override object Clone() { }

	public void DecreasePage() { }

	[CompilerGenerated]
	public AdvancedSearchValues get_AdvancedSearchValues() { }

	[CompilerGenerated]
	public bool get_CanShowDeletedContent() { }

	[CompilerGenerated]
	public string get_CurationSearchValue() { }

	[CompilerGenerated]
	public string get_Hint() { }

	[CompilerGenerated]
	public bool get_IsCurationBrowser() { }

	public bool get_IsValid() { }

	[CompilerGenerated]
	public int get_MaxPagesToDisplay() { }

	[CompilerGenerated]
	public ElasticQueryOptions get_Options() { }

	[CompilerGenerated]
	public int get_Page() { }

	[CompilerGenerated]
	public int get_PanelsPerPage() { }

	[CompilerGenerated]
	public IEnumerable<String> get_PlayerContentIds() { }

	public ContentBrowserQuery get_Query() { }

	public int get_QueryOffset() { }

	[CompilerGenerated]
	public SelectionType get_SelectionType() { }

	[CompilerGenerated]
	public int get_TotalPages() { }

	[CompilerGenerated]
	public WinRateDisplayType get_WinRateDisplayType() { }

	public void IncreasePage() { }

	public void Reset() { }

	public void ResetTotalPages() { }

	public void Set(ContentBrowserQuery query, ElasticQueryOptions options, string hint, SelectionType selectionType, WinRateDisplayType winRateDisplayType, AdvancedSearchValues advancedSearchValues, int maxPanels, int maxPages, IEnumerable<String> contentIds = null, bool canShowDeletedContent = false) { }

	[CompilerGenerated]
	private void set_AdvancedSearchValues(AdvancedSearchValues value) { }

	[CompilerGenerated]
	private void set_CanShowDeletedContent(bool value) { }

	[CompilerGenerated]
	private void set_CurationSearchValue(string value) { }

	[CompilerGenerated]
	private void set_Hint(string value) { }

	[CompilerGenerated]
	public void set_IsCurationBrowser(bool value) { }

	[CompilerGenerated]
	private void set_MaxPagesToDisplay(int value) { }

	[CompilerGenerated]
	private void set_Options(ElasticQueryOptions value) { }

	[CompilerGenerated]
	private void set_Page(int value) { }

	[CompilerGenerated]
	private void set_PanelsPerPage(int value) { }

	[CompilerGenerated]
	private void set_PlayerContentIds(IEnumerable<String> value) { }

	[CompilerGenerated]
	public void set_SelectionType(SelectionType value) { }

	[CompilerGenerated]
	private void set_TotalPages(int value) { }

	[CompilerGenerated]
	private void set_WinRateDisplayType(WinRateDisplayType value) { }

	public void SetCuration(ContentType contentType, bool hideCurated, List<String> curatedIds, string searchValue = null) { }

	public void SetFirstPage() { }

	public void SetLastPage() { }

	public void SetTotalPages(int totalPages) { }

}

