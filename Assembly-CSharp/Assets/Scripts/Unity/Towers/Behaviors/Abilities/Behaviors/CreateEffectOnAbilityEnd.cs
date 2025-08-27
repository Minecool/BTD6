namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class CreateEffectOnAbilityEnd : AbilityBehavior
{
	public CreateEffectOnAbilityEnd parent; //Field offset: 0x88
	public Effect effect; //Field offset: 0x90
	public Effect expEffect; //Field offset: 0x98
	public float lifespan; //Field offset: 0xA0
	public string expLifespan; //Field offset: 0xA8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 259
	}

	public CreateEffectOnAbilityEnd() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

