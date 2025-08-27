namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class CreateEffectOnAbility : AbilityBehavior
{
	public CreateEffectOnAbility parent; //Field offset: 0x88
	public Effect effect; //Field offset: 0x90
	public Effect expEffect; //Field offset: 0x98
	public bool centerEffect; //Field offset: 0xA0
	public string expCenterEffect; //Field offset: 0xA8
	public bool randomRotation; //Field offset: 0xB0
	public string expRandomRotation; //Field offset: 0xB8
	public bool destroyOnEnd; //Field offset: 0xC0
	public string expDestroyOnEnd; //Field offset: 0xC8
	public bool useAttackTransform; //Field offset: 0xD0
	public string expUseAttackTransform; //Field offset: 0xD8
	public bool canSave; //Field offset: 0xE0
	public string expCanSave; //Field offset: 0xE8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 357
	}

	public CreateEffectOnAbility() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

