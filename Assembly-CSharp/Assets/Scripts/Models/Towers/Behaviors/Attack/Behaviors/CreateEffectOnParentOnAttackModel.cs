namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(CreateEffectOnParentOnAttack), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateEffectOnParentOnAttackModel : AttackBehaviorModel
{
	public EffectModel effectModel; //Field offset: 0x30
	public EffectModel exitEffectModel; //Field offset: 0x38
	public bool cancelIfTowerHidden; //Field offset: 0x40

	public CreateEffectOnParentOnAttackModel(string name, EffectModel effectModel, EffectModel exitEffectModel, bool cancelIfTowerHidden) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

