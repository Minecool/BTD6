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
	public bool cantBeAbsorbed; //Field offset: 0xC0
	public string expCantBeAbsorbed; //Field offset: 0xC8
	public int mutatorPriority; //Field offset: 0xD0
	public string expMutatorPriority; //Field offset: 0xD8
	public ProjectileBehavior projectileBehavior; //Field offset: 0xE0
	public Projectile projectile; //Field offset: 0xE8
	public GameObject buffDisplay; //Field offset: 0xF0
	public GameObject expBuffDisplay; //Field offset: 0xF8
	public Effect initialEffect; //Field offset: 0x100
	public Effect expInitialEffect; //Field offset: 0x108

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 462
	}

	public MutateProjectileOnAbility() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

