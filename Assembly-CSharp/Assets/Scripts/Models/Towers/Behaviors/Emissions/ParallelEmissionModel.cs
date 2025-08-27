namespace Assets.Scripts.Models.Towers.Behaviors.Emissions;

[Implementation(typeof(ParallelEmission), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ParallelEmissionModel : EmissionModel
{
	public float spreadLength; //Field offset: 0x38
	public float yOffset; //Field offset: 0x3C
	public int count; //Field offset: 0x40
	public bool linear; //Field offset: 0x44
	public float offsetStart; //Field offset: 0x48

	public ParallelEmissionModel(string name, int count, float spreadLength, float yOffset, bool linear, EmissionBehaviorModel[] behaviors) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

