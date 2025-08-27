namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class MutateProjectileOnAbility : AbilityBehavior
{
	public MutateProjectileOnAbility parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public string mutatorId; //Field offset: 0xA0
	public string expMutatorId; //Field offset: 0xA8
	public int damageIncrease; //Field offset: 0xB0
	public string expDamageIncrease; //Field offset: 0xB8
	public ProjectileBehavior projectileBehavior; //Field offset: 0xC0
	public Projectile projectile; //Field offset: 0xC8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 251
	}

	public MutateProjectileOnAbility() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

