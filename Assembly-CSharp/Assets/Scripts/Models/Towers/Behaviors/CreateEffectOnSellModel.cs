namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(CreateEffectOnSell), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateEffectOnSellModel : TowerBehaviorModel
{
	public EffectModel effectModel; //Field offset: 0x30

	public CreateEffectOnSellModel(string name, EffectModel effectModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

