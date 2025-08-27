namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "MutateDamageOnAbility", menuName = "BTD6/Behaviors/Abilities/MutateDamageOnAbility")]
public class MutateDamageOnAbility : AbilityBehavior
{
	public float lifespan; //Field offset: 0x30
	public int damageIncrease; //Field offset: 0x34
	public Damage targetDamage; //Field offset: 0x38

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 204
	}

	public MutateDamageOnAbility() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

