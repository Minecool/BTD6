namespace Assets.Scripts.Models.MapEditorBehaviors.EditorLayerBehaviors;

[Implementation(typeof(ToggleMapEditorLayer), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ToggleMapEditorLayerModel : EntityActionModel
{
	public LayerType layerType; //Field offset: 0x38
	public bool isVisible; //Field offset: 0x3C
	public int layerId; //Field offset: 0x40

	public ToggleMapEditorLayerModel(int layerId, LayerType layerType, bool isVisible) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

