namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class LongArmOfLight : AbilityBehavior
{
	public LongArmOfLight parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public float multiplier; //Field offset: 0xA0
	public string expMultiplier; //Field offset: 0xA8
	public GameObject projectileDisplay; //Field offset: 0xB0
	public GameObject expProjectileDisplay; //Field offset: 0xB8
	public float projectileRadiusMultiplier; //Field offset: 0xC0
	public string expProjectileRadiusMultiplier; //Field offset: 0xC8
	public string damageType; //Field offset: 0xD0
	public string expDamageType; //Field offset: 0xD8
	public int damageIncrease; //Field offset: 0xE0
	public string expDamageIncrease; //Field offset: 0xE8
	public string mutatorId; //Field offset: 0xF0
	public string expMutatorId; //Field offset: 0xF8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 489
	}

	public LongArmOfLight() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

