namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(CreateEffectOnUpgrade), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateEffectOnUpgradeModel : TowerBehaviorModel
{
	public EffectModel effectModel; //Field offset: 0x30
	public bool createOnAirUnit; //Field offset: 0x38

	public CreateEffectOnUpgradeModel(string name, EffectModel effectModel, bool createOnAirUnit) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

