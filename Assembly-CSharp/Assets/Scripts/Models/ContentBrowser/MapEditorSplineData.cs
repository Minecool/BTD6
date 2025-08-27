namespace Assets.Scripts.Models.ContentBrowser;

public abstract class MapEditorSplineData : CustomMapSortableObjectData
{
	public List<PathNode> nodes; //Field offset: 0x18
	public int textureId; //Field offset: 0x20
	public bool sharpCorners; //Field offset: 0x24

	[JsonIgnore]
	public abstract bool IsHidden
	{
		 get { } //Length: 0
	}

	protected MapEditorSplineData() { }

	public bool Compare(MapEditorSplineData com) { }

	public abstract bool get_IsHidden() { }

}

