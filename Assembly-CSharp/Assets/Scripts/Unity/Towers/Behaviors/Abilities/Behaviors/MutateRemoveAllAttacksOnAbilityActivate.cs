namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class MutateRemoveAllAttacksOnAbilityActivate : AbilityBehavior
{
	public MutateRemoveAllAttacksOnAbilityActivate parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public bool excludeAbilityAttacks; //Field offset: 0xA0
	public string expExcludeAbilityAttacks; //Field offset: 0xA8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 166
	}

	public MutateRemoveAllAttacksOnAbilityActivate() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

