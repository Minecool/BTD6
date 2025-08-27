namespace Assets.Scripts.Models.Towers.Behaviors.Emissions;

[Implementation(typeof(AlternatingArcEmission), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AlternatingArcEmissionModel : EmissionModel
{
	public float angle; //Field offset: 0x38
	public int count; //Field offset: 0x3C
	public float offsetStart; //Field offset: 0x40
	public float sliceSize; //Field offset: 0x44
	public bool useParentRotation; //Field offset: 0x48

	public AlternatingArcEmissionModel(string name, int count, float angle, bool useParentRotation, EmissionBehaviorModel[] behaviors) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

