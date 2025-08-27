namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(CreateEffectOnAbility), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateEffectOnAbilityModel : AbilityBehaviorModel
{
	public EffectModel effectModel; //Field offset: 0x30
	public bool randomRotation; //Field offset: 0x38
	public bool centerEffect; //Field offset: 0x39
	public bool destroyOnEnd; //Field offset: 0x3A
	public bool useAttackTransform; //Field offset: 0x3B
	public bool canSave; //Field offset: 0x3C

	public CreateEffectOnAbilityModel(string name, EffectModel effectModel, bool randomRotation, bool centerEffect, bool destroyOnEnd, bool useAttackTransform, bool canSave) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

