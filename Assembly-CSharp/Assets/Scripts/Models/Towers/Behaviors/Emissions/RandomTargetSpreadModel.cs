namespace Assets.Scripts.Models.Towers.Behaviors.Emissions;

[Implementation(typeof(RandomTargetSpread), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RandomTargetSpreadModel : EmissionModel
{
	public float spread; //Field offset: 0x38
	public ThrowMarkerOffsetModel[] throwMarkerOffsets; //Field offset: 0x40

	public RandomTargetSpreadModel(string name, float spread, EmissionBehaviorModel[] behaviors, ThrowMarkerOffsetModel[] throwMarkerOffsets) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

