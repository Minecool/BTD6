namespace Assets.Scripts.Models.ContentBrowser;

public class MapEditorModel : IHasCustomMapModel, IContentBrowserData
{
	[JsonProperty]
	private CustomMapModel customMapModel; //Field offset: 0x10
	[JsonProperty]
	public string name; //Field offset: 0x18
	[JsonProperty]
	public string mode; //Field offset: 0x20
	[JsonProperty]
	public string difficulty; //Field offset: 0x28

	[JsonIgnore]
	public override CustomMapModel CustomMapModel
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public static MapEditorModel DefaultMapEditorModel
	{
		 get { } //Length: 221
	}

	public MapEditorModel() { }

	public override CustomMapModel get_CustomMapModel() { }

	public static MapEditorModel get_DefaultMapEditorModel() { }

	public void set_CustomMapModel(CustomMapModel value) { }

}

