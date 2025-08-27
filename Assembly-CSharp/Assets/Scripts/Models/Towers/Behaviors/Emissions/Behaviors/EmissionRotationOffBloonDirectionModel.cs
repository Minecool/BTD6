namespace Assets.Scripts.Models.Towers.Behaviors.Emissions.Behaviors;

[Implementation(typeof(EmissionRotationOffBloonDirection), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EmissionRotationOffBloonDirectionModel : EmissionBehaviorModel
{
	public bool useAirUnitPosition; //Field offset: 0x30
	public bool dontSetAfterEmit; //Field offset: 0x31

	public EmissionRotationOffBloonDirectionModel(string name, bool useAirUnitPosition, bool dontSetAfterEmit) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

