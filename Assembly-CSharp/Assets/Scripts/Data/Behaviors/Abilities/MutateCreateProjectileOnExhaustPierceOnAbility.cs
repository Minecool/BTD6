namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "MutateCreateProjectileOnExhaustPierceOnAbility", menuName = "BTD6/Behaviors/Abilities/MutateCreateProjectileOnExhaustPierceOnAbility")]
public class MutateCreateProjectileOnExhaustPierceOnAbility : AbilityBehavior
{
	public float lifespan; //Field offset: 0x30
	public int countIncrease; //Field offset: 0x34
	public CreateProjectileOnExhaustPierce targetBehavior; //Field offset: 0x38

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 204
	}

	public MutateCreateProjectileOnExhaustPierceOnAbility() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

