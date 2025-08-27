namespace Assets.Scripts.Models.ContentBrowser;

public class MapEditorAreaData : MapEditorSplineData, ICloneable<MapEditorAreaData>
{
	public AreaData area; //Field offset: 0x28

	[JsonIgnore]
	public virtual bool IsHidden
	{
		 get { } //Length: 18
	}

	public MapEditorAreaData() { }

	public override MapEditorAreaData Clone() { }

	public bool Compare(MapEditorAreaData com) { }

	public MapEditorAreaDataModel Def(int categoryLayerId) { }

	public virtual bool get_IsHidden() { }

	public bool IsValid() { }

}

