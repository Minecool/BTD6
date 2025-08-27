namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class MutateCreateProjectileOnExhaustPierceOnAbility : AbilityBehavior
{
	public MutateCreateProjectileOnExhaustPierceOnAbility parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public int countIncrease; //Field offset: 0xA0
	public string expCountIncrease; //Field offset: 0xA8
	public CreateProjectileOnExhaustPierce targetBehavior; //Field offset: 0xB0
	public CreateProjectileOnExhaustPierce expTargetBehavior; //Field offset: 0xB8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 213
	}

	public MutateCreateProjectileOnExhaustPierceOnAbility() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

