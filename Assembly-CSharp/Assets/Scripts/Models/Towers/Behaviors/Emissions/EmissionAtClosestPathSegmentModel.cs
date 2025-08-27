namespace Assets.Scripts.Models.Towers.Behaviors.Emissions;

[Implementation(typeof(EmissionAtClosestPathSegment), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EmissionAtClosestPathSegmentModel : EmissionModel
{
	public int count; //Field offset: 0x38
	public float spacing; //Field offset: 0x3C

	public EmissionAtClosestPathSegmentModel(string name, int count, float spacing, EmissionBehaviorModel[] behaviors) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

