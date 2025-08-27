namespace Assets.Scripts.Models.Towers.Behaviors.Emissions.Behaviors;

[Implementation(typeof(EmissionPositionOffset), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EmissionPositionOffsetModel : EmissionBehaviorModel
{
	public float minOffset; //Field offset: 0x30
	public float maxOffset; //Field offset: 0x34
	public float yOffset; //Field offset: 0x38

	public EmissionPositionOffsetModel(string name, float minOffset, float maxOffset, float yOffset) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

