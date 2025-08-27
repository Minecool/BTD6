namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "MutateProjectileOnAbility", menuName = "BTD6/Behaviors/Abilities/MutateProjectileOnAbility")]
public class MutateProjectileOnAbility : AbilityBehavior
{
	public float lifespan; //Field offset: 0x30
	public string mutatorId; //Field offset: 0x38
	public int damageIncrease; //Field offset: 0x40
	public bool cantBeAbsorbed; //Field offset: 0x44
	public int mutatorPriority; //Field offset: 0x48
	public ProjectileBehavior projectileBehavior; //Field offset: 0x50
	public Projectile projectile; //Field offset: 0x58
	public GameObject buffDisplay; //Field offset: 0x60
	public Effect initialEffect; //Field offset: 0x68

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 457
	}

	public MutateProjectileOnAbility() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

