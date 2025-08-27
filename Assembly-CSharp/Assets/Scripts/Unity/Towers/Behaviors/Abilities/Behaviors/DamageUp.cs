namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class DamageUp : AbilityBehavior
{
	public DamageUp parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public int additionalDamage; //Field offset: 0xA0
	public string expAdditionalDamage; //Field offset: 0xA8
	public GameObject projectileDisplay; //Field offset: 0xB0
	public GameObject expProjectileDisplay; //Field offset: 0xB8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 297
	}

	public DamageUp() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

