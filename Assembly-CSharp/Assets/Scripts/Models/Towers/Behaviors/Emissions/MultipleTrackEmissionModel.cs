namespace Assets.Scripts.Models.Towers.Behaviors.Emissions;

[Implementation(typeof(MultipleTrackEmission), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MultipleTrackEmissionModel : EmissionModel
{
	public float offset; //Field offset: 0x38
	public int count; //Field offset: 0x3C
	public float offsetStart; //Field offset: 0x40

	public MultipleTrackEmissionModel(string name, int count, float offset, EmissionBehaviorModel[] behaviors) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

