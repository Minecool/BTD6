namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class ChangeProjectileDisplay : AbilityBehavior
{
	public ChangeProjectileDisplay parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public GameObject display; //Field offset: 0xA0
	public GameObject expDisplay; //Field offset: 0xA8
	public GameObject projectile; //Field offset: 0xB0
	public GameObject expProjectile; //Field offset: 0xB8
	public string mutatorId; //Field offset: 0xC0
	public string expMutatorId; //Field offset: 0xC8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 390
	}

	public ChangeProjectileDisplay() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

