namespace Assets.Scripts.Models.MapEditorBehaviors;

public class MapEditorPowerDataModel : Model
{
	public PowerModel powerModel; //Field offset: 0x30
	public PositionalData positionData; //Field offset: 0x38

	public MapEditorPowerDataModel(string name, PowerModel powerModel, PositionalData positionData) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

