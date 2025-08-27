namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(CreateEffectOnAirUnitDestroy), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateEffectOnAirUnitDestroyModel : TowerBehaviorModel
{
	public EffectModel effectModel; //Field offset: 0x30
	public float rotation; //Field offset: 0x38
	public float scale; //Field offset: 0x3C

	public CreateEffectOnAirUnitDestroyModel(string name, EffectModel effectModel, float rotation, float scale) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

