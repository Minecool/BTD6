namespace Assets.Scripts.Models.Towers.Behaviors.Emissions.Behaviors;

[Implementation(typeof(EmissionRotationOffset), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EmissionRotationOffsetModel : EmissionBehaviorModel
{
	public float offsetRotation; //Field offset: 0x30

	public EmissionRotationOffsetModel(string name, float offsetRotation) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

