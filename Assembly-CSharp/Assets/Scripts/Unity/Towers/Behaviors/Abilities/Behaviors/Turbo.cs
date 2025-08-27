namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class Turbo : AbilityBehavior
{
	public Turbo parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public float multiplier; //Field offset: 0xA0
	public string expMultiplier; //Field offset: 0xA8
	public GameObject projectileDisplay; //Field offset: 0xB0
	public GameObject expProjectileDisplay; //Field offset: 0xB8
	public int extraDamage; //Field offset: 0xC0
	public string expExtraDamage; //Field offset: 0xC8
	public float projectileRadiusScaleBonus; //Field offset: 0xD0
	public string expProjectileRadiusScaleBonus; //Field offset: 0xD8
	public bool dontRemoveMutatorOnDestroy; //Field offset: 0xE0
	public string expDontRemoveMutatorOnDestroy; //Field offset: 0xE8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 430
	}

	public Turbo() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

