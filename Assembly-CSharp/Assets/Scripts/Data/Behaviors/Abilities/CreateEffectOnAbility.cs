namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "CreateEffectOnAbility", menuName = "BTD6/Behaviors/Abilities/CreateEffectOnAbility")]
public class CreateEffectOnAbility : AbilityBehavior
{
	public Effect effect; //Field offset: 0x30
	public bool centerEffect; //Field offset: 0x38
	public bool randomRotation; //Field offset: 0x39
	public bool destroyOnEnd; //Field offset: 0x3A
	public bool useAttackTransform; //Field offset: 0x3B
	public bool canSave; //Field offset: 0x3C

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 348
	}

	public CreateEffectOnAbility() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

