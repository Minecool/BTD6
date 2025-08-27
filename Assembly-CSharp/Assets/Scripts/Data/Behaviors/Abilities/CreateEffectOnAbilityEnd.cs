namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "CreateEffectOnAbilityEnd", menuName = "BTD6/Behaviors/Abilities/CreateEffectOnAbilityEnd")]
public class CreateEffectOnAbilityEnd : AbilityBehavior
{
	public Effect effect; //Field offset: 0x30
	public float lifespan; //Field offset: 0x38

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 262
	}

	public CreateEffectOnAbilityEnd() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

