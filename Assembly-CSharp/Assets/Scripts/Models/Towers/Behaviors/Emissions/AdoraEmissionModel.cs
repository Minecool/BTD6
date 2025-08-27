namespace Assets.Scripts.Models.Towers.Behaviors.Emissions;

[Implementation(typeof(AdoraEmission), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AdoraEmissionModel : EmissionModel
{
	public int count; //Field offset: 0x38
	public float angleBetween; //Field offset: 0x3C

	public AdoraEmissionModel(string name, int count, float angleBetween, EmissionBehaviorModel[] behaviors) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

