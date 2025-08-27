namespace Assets.Scripts.Models.Towers.Behaviors.Emissions.Behaviors;

[Implementation(typeof(EmissionRotationOffAlternateDisplay), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EmissionRotationOffAlternateDisplayModel : EmissionBehaviorModel
{
	public int offsetRotation; //Field offset: 0x30

	public EmissionRotationOffAlternateDisplayModel(string name, int offsetRotation) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

