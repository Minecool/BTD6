namespace Assets.Scripts.Models.Towers.Behaviors.Emissions.Behaviors;

[Implementation(typeof(AcidPoolEmission), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AcidPoolEmissionModel : EmissionBehaviorModel
{
	public int alwaysPoolOnCount; //Field offset: 0x30

	public AcidPoolEmissionModel(string name, int alwaysPoolOnCount) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

