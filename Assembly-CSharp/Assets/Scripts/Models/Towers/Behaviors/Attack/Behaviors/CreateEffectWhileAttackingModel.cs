namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(CreateEffectWhileAttacking), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateEffectWhileAttackingModel : AttackBehaviorModel
{
	public EffectModel effectModel; //Field offset: 0x30
	public EffectModel exitEffectModel; //Field offset: 0x38

	public CreateEffectWhileAttackingModel(string name, EffectModel effectModel, EffectModel exitEffectModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

