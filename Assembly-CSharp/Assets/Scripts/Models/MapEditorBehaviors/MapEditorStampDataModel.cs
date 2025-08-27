namespace Assets.Scripts.Models.MapEditorBehaviors;

public class MapEditorStampDataModel : Model
{
	public StampTextureModel stampTextureModel; //Field offset: 0x30
	public PositionalData positionalData; //Field offset: 0x38
	public int layer; //Field offset: 0x40
	public int orderInLayer; //Field offset: 0x44
	public int stampLayer; //Field offset: 0x48
	public bool disablePlacementOnLoad; //Field offset: 0x4C

	public MapEditorStampDataModel(string name, StampTextureModel stampTextureModel, PositionalData positionalData, bool disablePlacementOnLoad, int layer, int orderInLayer, int stampLayer) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

