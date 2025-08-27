namespace Assets.Scripts.Models.Profile;

public class MapEditorCreatorModel : ICreatorModel
{
	[JsonProperty]
	private MapEditorModel mapEditorModel; //Field offset: 0x10
	[JsonProperty]
	private string sharedId; //Field offset: 0x18
	[JsonProperty]
	private string creationId; //Field offset: 0x20

	[JsonIgnore]
	public override string CreationId
	{
		 get { } //Length: 5
	}

	[JsonIgnore]
	public override CustomMapModel CustomMapModel
	{
		 get { } //Length: 27
	}

	[JsonIgnore]
	public MapEditorModel MapEditorModel
	{
		 get { } //Length: 5
	}

	[JsonIgnore]
	public override string Name
	{
		 get { } //Length: 27
	}

	[JsonIgnore]
	public override string SharedId
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public MapEditorCreatorModel(MapEditorModel model) { }

	[Conditional("NK_DEBUG")]
	public void DEBUG_SetModel(MapEditorModel model) { }

	public override string get_CreationId() { }

	public override CustomMapModel get_CustomMapModel() { }

	public MapEditorModel get_MapEditorModel() { }

	public override string get_Name() { }

	public override string get_SharedId() { }

	public void set_SharedId(string value) { }

	[OnDeserialized]
	public void Validate(StreamingContext context = null) { }

}

