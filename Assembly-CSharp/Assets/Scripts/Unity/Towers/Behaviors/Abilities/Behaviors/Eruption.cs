namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class Eruption : AbilityBehavior
{
	public Eruption parent; //Field offset: 0x88
	public float projectileLifespanMult; //Field offset: 0x90
	public string expProjectileLifespanMult; //Field offset: 0x98
	public GameObject display; //Field offset: 0xA0
	public GameObject expDisplay; //Field offset: 0xA8
	public GameObject projectileToSwapDisplay; //Field offset: 0xB0
	public GameObject expProjectileToSwapDisplay; //Field offset: 0xB8
	public GameObject projectileDisplay; //Field offset: 0xC0
	public GameObject expProjectileDisplay; //Field offset: 0xC8
	public GameObject subProjectileToSwapDisplay; //Field offset: 0xD0
	public GameObject expSubProjectileToSwapDisplay; //Field offset: 0xD8
	public GameObject subProjectileDisplay; //Field offset: 0xE0
	public GameObject expSubProjectileDisplay; //Field offset: 0xE8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 587
	}

	public Eruption() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

