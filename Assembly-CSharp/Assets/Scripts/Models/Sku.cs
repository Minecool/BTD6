namespace Assets.Scripts.Models;

public class Sku : IContentBrowserSettings, ISweepstakesSkuSettings
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<FeaturedContentEvent, DateTime> <>9__25_1; //Field offset: 0x8
		public static Func<FeaturedContentEvent, String> <>9__25_2; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal DateTime <ParseFeaturedContentIds>b__25_1(FeaturedContentEvent x) { }

		internal string <ParseFeaturedContentIds>b__25_2(FeaturedContentEvent x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public List<Type> disabledEventTypes; //Field offset: 0x10

		public <>c__DisplayClass19_0() { }

		internal bool <Validate>b__1(BaseServerEvent e) { }

		internal bool <Validate>g__isEventDisabled|0(BaseServerEvent baseServerEvent) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public DateTime currentTime; //Field offset: 0x10
		public ContentType contentType; //Field offset: 0x18

		public <>c__DisplayClass25_0() { }

		internal bool <ParseFeaturedContentIds>b__0(FeaturedContentEvent x) { }

	}

	[IsReadOnly]
	private struct FeaturedContentCache
	{
		[CompilerGenerated]
		private readonly IReadOnlyCollection<String> <FeaturedIds>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private readonly DateTime <CacheTime>k__BackingField; //Field offset: 0x8

		public DateTime CacheTime
		{
			[CompilerGenerated]
			 get { } //Length: 291
		}

		public IReadOnlyCollection<String> FeaturedIds
		{
			[CompilerGenerated]
			 get { } //Length: 4
		}

		public FeaturedContentCache(List<String> featuredIds) { }

		[CompilerGenerated]
		public DateTime get_CacheTime() { }

		[CompilerGenerated]
		public IReadOnlyCollection<String> get_FeaturedIds() { }

		public bool IsRecent() { }

	}

	public BaseServerEvent[] events; //Field offset: 0x10
	public ServerSettings settings; //Field offset: 0x18
	public GameEvents gameEvents; //Field offset: 0x20
	public TrophyStoreSKU trophyStore; //Field offset: 0x28
	public Dictionary<String, String> primeDrops; //Field offset: 0x30
	public IapStoreSettings iapStore; //Field offset: 0x38
	public TestingSettings testing; //Field offset: 0x40
	public VersionSettings versions; //Field offset: 0x48
	public String[] compatibleSave; //Field offset: 0x50
	[JsonIgnore]
	public bool isOfflineSku; //Field offset: 0x58
	[JsonIgnore]
	public ServerMaintenanceEvent[] serverMaintenanceEvents; //Field offset: 0x60
	[CompilerGenerated]
	private ContentBrowserServerSettings <ContentBrowserServer>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private SweepstakesSettings <Sweepstakes>k__BackingField; //Field offset: 0x70
	[JsonIgnore]
	private readonly Dictionary<ContentType, FeaturedContentCache> featuredContentCaches; //Field offset: 0x78

	public override ContentBrowserServerSettings ContentBrowserServer
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public override SweepstakesSettings Sweepstakes
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public Sku() { }

	[CompilerGenerated]
	public override ContentBrowserServerSettings get_ContentBrowserServer() { }

	[CompilerGenerated]
	public override SweepstakesSettings get_Sweepstakes() { }

	private static List<Type> GetDisabledEventTypes(GameEvents gameEvents, SweepstakesSettings sweepstakesSettings) { }

	public IReadOnlyCollection<String> GetFeaturedContentIds(ContentType contentType) { }

	public bool HasFeaturedContent(ContentType contentType) { }

	public bool IsFeaturedContent(ContentType contentType, string contentId) { }

	private List<String> ParseFeaturedContentIds(ContentType contentType) { }

	[CompilerGenerated]
	public override void set_ContentBrowserServer(ContentBrowserServerSettings value) { }

	[CompilerGenerated]
	public override void set_Sweepstakes(SweepstakesSettings value) { }

	[OnDeserialized]
	public void Validate(StreamingContext context = null) { }

}

