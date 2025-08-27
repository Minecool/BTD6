namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(CreateEffectOnPlace), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateEffectOnPlaceModel : TowerBehaviorModel
{
	public EffectModel effectModel; //Field offset: 0x30

	public CreateEffectOnPlaceModel(string name, EffectModel effectModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

