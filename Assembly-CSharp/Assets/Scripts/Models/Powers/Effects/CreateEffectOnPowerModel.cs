namespace Assets.Scripts.Models.Powers.Effects;

[Implementation(typeof(CreateEffectOnPower), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateEffectOnPowerModel : PowerBehaviorModel
{
	public EffectModel effectModel; //Field offset: 0x30

	public CreateEffectOnPowerModel(string name, EffectModel effectModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

