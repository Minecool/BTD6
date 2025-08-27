namespace NinjaKiwi.GUTS.Models.ContentBrowser;

public class ContentBrowserServerSettings
{
	[CompilerGenerated]
	private Dictionary<ContentType, ContentTypeSettings> <ContentTypeSettings>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private TitleSettings <TitleSettings>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private ContentCurationSettings <CurationSettings>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private ContentAnalysisSettings <AnalysisSettings>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private MapEditorSettings <MapEditorSettings>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private Int32[] <AccoladeIapQuantities>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private byte <MaxTopContributors>k__BackingField; //Field offset: 0x40

	public Int32[] AccoladeIapQuantities
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public ContentAnalysisSettings AnalysisSettings
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public Dictionary<ContentType, ContentTypeSettings> ContentTypeSettings
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public ContentCurationSettings CurationSettings
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public MapEditorSettings MapEditorSettings
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public byte MaxTopContributors
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public TitleSettings TitleSettings
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public ContentBrowserServerSettings() { }

	[CompilerGenerated]
	public Int32[] get_AccoladeIapQuantities() { }

	[CompilerGenerated]
	public ContentAnalysisSettings get_AnalysisSettings() { }

	[CompilerGenerated]
	public Dictionary<ContentType, ContentTypeSettings> get_ContentTypeSettings() { }

	[CompilerGenerated]
	public ContentCurationSettings get_CurationSettings() { }

	[CompilerGenerated]
	public MapEditorSettings get_MapEditorSettings() { }

	[CompilerGenerated]
	public byte get_MaxTopContributors() { }

	[CompilerGenerated]
	public TitleSettings get_TitleSettings() { }

	[CompilerGenerated]
	public void set_AccoladeIapQuantities(Int32[] value) { }

	[CompilerGenerated]
	public void set_AnalysisSettings(ContentAnalysisSettings value) { }

	[CompilerGenerated]
	public void set_ContentTypeSettings(Dictionary<ContentType, ContentTypeSettings> value) { }

	[CompilerGenerated]
	public void set_CurationSettings(ContentCurationSettings value) { }

	[CompilerGenerated]
	public void set_MapEditorSettings(MapEditorSettings value) { }

	[CompilerGenerated]
	public void set_MaxTopContributors(byte value) { }

	[CompilerGenerated]
	public void set_TitleSettings(TitleSettings value) { }

	[OnDeserialized]
	public void Validate(StreamingContext context = null) { }

}

