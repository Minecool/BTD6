namespace Assets.Scripts.Models.Towers.Behaviors.Emissions;

[Implementation(typeof(EmissionClosestOffset), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EmissionClosestOffsetModel : EmissionModel
{
	public bool rotateProjectileWithTower; //Field offset: 0x38
	public ThrowMarkerOffsetModel[] throwMarkerOffsetModels; //Field offset: 0x40
	public int animationOriginState; //Field offset: 0x48
	public EffectModel effectModel; //Field offset: 0x50

	public EmissionClosestOffsetModel(string id, bool rotateProjectileWithTower, ThrowMarkerOffsetModel[] throwMarkerOffsetModels, EmissionBehaviorModel[] behaviors, int animationOriginState, EffectModel effectModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

