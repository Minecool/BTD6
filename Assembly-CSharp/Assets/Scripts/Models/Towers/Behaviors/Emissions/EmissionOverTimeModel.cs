namespace Assets.Scripts.Models.Towers.Behaviors.Emissions;

[Implementation(typeof(EmissionOverTime), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EmissionOverTimeModel : EmissionModel
{
	public int count; //Field offset: 0x38
	public float timeBetween; //Field offset: 0x3C

	public EmissionOverTimeModel(string id, int count, float timeBetween, EmissionBehaviorModel[] behaviors) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

