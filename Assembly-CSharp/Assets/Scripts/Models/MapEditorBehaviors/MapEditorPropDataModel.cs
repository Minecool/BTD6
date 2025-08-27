namespace Assets.Scripts.Models.MapEditorBehaviors;

public class MapEditorPropDataModel : Model
{
	public PropModel propModel; //Field offset: 0x30
	public PositionalData positionalData; //Field offset: 0x38
	public bool disablePlacementOnLoad; //Field offset: 0x40
	public bool isAnimatorEnabled; //Field offset: 0x41
	public bool isSightAndPlacementBlockingDisabled; //Field offset: 0x42
	public int groupLayer; //Field offset: 0x44
	public bool isCustomProp; //Field offset: 0x48

	public MapEditorPropDataModel(string name, PropModel propModel, PositionalData positionalData, bool disablePlacementOnLoad, bool isAnimatorEnabled, bool isSightAndPlacementBlockingDisabled, int groupLayer, bool isCustomProp) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

