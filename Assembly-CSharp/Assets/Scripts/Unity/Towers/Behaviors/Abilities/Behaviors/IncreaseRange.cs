namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class IncreaseRange : AbilityBehavior
{
	public IncreaseRange parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public float multiplier; //Field offset: 0xA0
	public string expMultiplier; //Field offset: 0xA8
	public float addative; //Field offset: 0xB0
	public string expAddative; //Field offset: 0xB8
	public bool endOnDefeatScreen; //Field offset: 0xC0
	public string expEndOnDefeatScreen; //Field offset: 0xC8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 196
	}

	public IncreaseRange() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

