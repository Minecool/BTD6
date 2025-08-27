namespace Assets.Scripts.Models.ContentBrowser;

public class MapEditorStampData : CustomMapSortableObjectData, ICloneable<MapEditorStampData>
{
	public int id; //Field offset: 0x18
	public PositionalData positionalData; //Field offset: 0x20
	public bool disablePlacementOnLoad; //Field offset: 0x28
	public int stampLayer; //Field offset: 0x2C

	public virtual int CategoryLayerId
	{
		 get { } //Length: 4
	}

	public MapEditorStampData() { }

	public override MapEditorStampData Clone() { }

	public bool Compare(MapEditorStampData com) { }

	public MapEditorStampDataModel Def() { }

	public virtual int get_CategoryLayerId() { }

}

