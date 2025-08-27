namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class CreateProjectileOnAbilityActivate : AbilityBehavior
{
	public CreateProjectileOnAbilityActivate parent; //Field offset: 0x88
	public Projectile projectile; //Field offset: 0x90
	public Projectile expProjectile; //Field offset: 0x98
	public Emission emission; //Field offset: 0xA0
	public Emission expEmission; //Field offset: 0xA8
	public float chance; //Field offset: 0xB0
	public string expChance; //Field offset: 0xB8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 210
	}

	public CreateProjectileOnAbilityActivate() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

