namespace Assets.Scripts.Models.ContentBrowser;

public class MapEditorPropData : CustomMapSortableObjectData, ICloneable<MapEditorPropData>
{
	public int id; //Field offset: 0x18
	public PositionalData positionalData; //Field offset: 0x20
	public bool disablePlacementOnLoad; //Field offset: 0x28
	public bool isAnimatorEnabled; //Field offset: 0x29
	public bool isSightAndPlacementBlockingDisabled; //Field offset: 0x2A
	public int groupLayer; //Field offset: 0x2C

	public virtual int CategoryLayerId
	{
		 get { } //Length: 4
	}

	public MapEditorPropData() { }

	public override MapEditorPropData Clone() { }

	public bool Compare(MapEditorPropData com) { }

	public MapEditorPropDataModel Def() { }

	public MapEditorPropDataModel Def(Prop prop) { }

	public virtual int get_CategoryLayerId() { }

}

