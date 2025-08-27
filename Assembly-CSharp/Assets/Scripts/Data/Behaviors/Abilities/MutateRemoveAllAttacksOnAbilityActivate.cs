namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "MutateRemoveAllAttacksOnAbilityActivate", menuName = "BTD6/Behaviors/Abilities/MutateRemoveAllAttacksOnAbilityActivate")]
public class MutateRemoveAllAttacksOnAbilityActivate : AbilityBehavior
{
	public float lifespan; //Field offset: 0x30
	public bool excludeAbilityAttacks; //Field offset: 0x34

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 130
	}

	public MutateRemoveAllAttacksOnAbilityActivate() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

