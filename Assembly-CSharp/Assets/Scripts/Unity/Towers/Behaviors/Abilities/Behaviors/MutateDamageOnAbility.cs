namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class MutateDamageOnAbility : AbilityBehavior
{
	public MutateDamageOnAbility parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public int damageIncrease; //Field offset: 0xA0
	public string expDamageIncrease; //Field offset: 0xA8
	public Damage targetDamage; //Field offset: 0xB0
	public Damage expTargetDamage; //Field offset: 0xB8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 213
	}

	public MutateDamageOnAbility() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

