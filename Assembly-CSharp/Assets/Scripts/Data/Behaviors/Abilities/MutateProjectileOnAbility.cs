namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "MutateProjectileOnAbility", menuName = "BTD6/Behaviors/Abilities/MutateProjectileOnAbility")]
public class MutateProjectileOnAbility : AbilityBehavior
{
	public float lifespan; //Field offset: 0x30
	public string mutatorId; //Field offset: 0x38
	public int damageIncrease; //Field offset: 0x40
	public ProjectileBehavior projectileBehavior; //Field offset: 0x48
	public Projectile projectile; //Field offset: 0x50

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 253
	}

	public MutateProjectileOnAbility() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

